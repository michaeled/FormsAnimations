using System.Diagnostics;
using FormsAnimations.GestureRecognizer;
using Xamarin.Forms;

namespace FormsAnimations
{
    public class ExampleViewCell : ViewCell
    {
        public ExampleViewCell()
        {
            var label = new Label
            {
                FontFamily = Device.OS == TargetPlatform.iOS ? "[Nunito-Light]" : "fonts/Nunito-Light.ttf",
                TextColor = Color.Black,
                YAlign = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };

            var tap = new AdvancedTapGestureRecognizer();

            tap.Command = new Command(async (p) =>
            {
                Debug.WriteLine(label.Text);
            });

            label.GestureRecognizers.Add(tap);

            label.SetBinding(Label.TextProperty, new Binding { Source = BindingContext });

            View = new StackLayout
            {
                Padding = 5,

                Children =
                {
                    label,
                    new BoxView { HeightRequest = 1.0, BackgroundColor = Color.Silver}
                }
            };
        }
    }
}