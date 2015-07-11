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

            var tap = new AdvancedTapGestureRecognizer
            {
                Command =
                    new AsyncCommand(async o =>
                    {
                        await label.RelMoveHorizontally(25, 250, MoreEasing.BounceEaseOut);
                    })
            };

            label.GestureRecognizers.Add(tap);
            label.SetBinding(Label.TextProperty, new Binding { Source = BindingContext });

            View = new StackLayout
            {
                Padding = 10,

                Children =
                {
                    label,
                    new BoxView { HeightRequest = 1.0, BackgroundColor = Color.Silver}
                }
            };
        }
    }
}