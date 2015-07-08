using Xamarin.Forms;

namespace FormsAnimations
{
    public class ExampleViewCell : ViewCell
    {
        public ExampleViewCell()
        {
            var label = new Label
            {
                TextColor = Color.Black,
                YAlign = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            label.SetBinding(Label.TextProperty, new Binding { Source = BindingContext });
            
            View = new StackLayout
            {
                Children =
                {
                    label,
                    new BoxView { HeightRequest = 1.0, BackgroundColor = Color.Silver}
                }
            };
        }
    }
}
