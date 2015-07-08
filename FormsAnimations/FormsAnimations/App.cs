using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace FormsAnimations
{
    public class App : Application
    {
        private readonly Dictionary<string, Type> _pages;
        public static Size ScreenSize;

        public App()
        {
            _pages = new Dictionary<string, Type>
            {
                {"Button Animation", typeof(ButtonPage)},
                {"Paper Button Animation", typeof(PaperButtonPage)},
                {"Password Indicator Animation", typeof(PasswordIndicatorPage)}
            };

            var list = new ListView
            {
                ItemTemplate = new DataTemplate(typeof (ExampleViewCell)),
                ItemsSource = _pages.Keys.ToArray()
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
            var key = e.SelectedItem as string;
            var type = _pages[key];

            // create the page object
            var page = Activator.CreateInstance(type) as Page;

            if (page == null)
            {
                await MainPage.DisplayAlert("Error", "Couldn't display page.", "OK");
                return;
            }
         
            page.Title = key;
            await MainPage.Navigation.PushAsync(page, true);
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
