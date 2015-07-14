using System;
using System.Collections.Generic;
using System.Linq;
using FormsAnimations.Comanding;
using FormsAnimations.GestureRecognizer;
using Xamarin.Forms;

namespace FormsAnimations
{
    public class App : Application
    {
        private readonly Dictionary<ExampleViewCellModel, Type> _pages;
        public static Size ScreenSize;

        public App()
        {
            _pages = new Dictionary<ExampleViewCellModel, Type>
            {
                {new ExampleViewCellModel {Title = "Button Animation"}, typeof (ButtonPage)},
                {new ExampleViewCellModel {Title = "Paper Button Animation"}, typeof (PaperButtonPage)},
                {new ExampleViewCellModel {Title = "Password Indicator Animation"}, typeof (PasswordIndicatorPage)}
            };

            var list = new ListView
            {
                ItemTemplate = new DataTemplate(typeof (ExampleViewCell)),
                ItemsSource = _pages.Keys.ToArray(),
                RowHeight = 50
            };

            list.ItemSelected += List_ItemSelected;
            
            var rootPage = new ContentPage
            {
                Title = "Forms Animation Examples",
                Content = list
            };

            Resources = new ResourceDictionary();
            SetGlobalStyles();
            MainPage = new NavigationPage(rootPage);
        }


        private void SetGlobalStyles()
        {
            var button = new Style(typeof (Button))
            {
                Setters =
                {
                    new Setter {Property = Button.BackgroundColorProperty, Value = Color.FromHex("3499DB")},
                    new Setter {Property = Button.TextColorProperty, Value = Color.White},
                }
            };

            // add button style
            Resources.Add(button);

            var page = new Style(typeof(ContentPage))
            {
                Setters =
                {
                    new Setter {Property = VisualElement.BackgroundColorProperty, Value = Color.White}
                }
            };

            // add page style
            Resources.Add(page);

            // create identical page styles
            foreach (var key in _pages.Values)
            {
                var derived = new Style(key)
                {
                    BasedOn = page
                };

                Resources.Add(derived);
            }
        }


        private async void List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var vm = e.SelectedItem as ExampleViewCellModel;
            var list = sender as ListView;

            if (vm == null || list == null)
            {
                return;
            }

            var pageType = _pages[vm];

            // create the page object
            var page = Activator.CreateInstance(pageType) as Page;

            if (page == null)
            {
                await MainPage.DisplayAlert("Error", "Couldn't display page.", "OK");
                return;
            }

            page.Title = vm.Title;

            var animation = vm.TappedAnimation as IAsyncCommand;
            var reset = vm.Reset;

            if (animation != null)
            {
                await animation.ExecuteAsync(null);
            }

            await MainPage.Navigation.PushAsync(page, true);
            list.SelectedItem = null;
            reset.Execute(null);
        }


        protected override void OnStart()
        {
            // Handle when your app starts
        }


        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        
        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
