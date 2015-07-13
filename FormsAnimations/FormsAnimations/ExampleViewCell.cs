using System.Threading.Tasks;
using FormsAnimations.GestureRecognizer;
using Xamarin.Forms;

namespace FormsAnimations
{
    public class ExampleViewCell : ViewCell
    {
        private readonly Label _label;


        public ExampleViewCell()
        {
            _label = new Label
            {
                FontFamily = Device.OS == TargetPlatform.iOS ? "[Nunito-Light]" : "fonts/Nunito-Light.ttf",
                TextColor = Color.Black,
                YAlign = TextAlignment.Center,
                VerticalOptions = LayoutOptions.FillAndExpand,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };

            _label.SetBinding(Label.TextProperty, "Title");
            
            View = new StackLayout
            {
                Padding = 10,

                Children =
                {
                    _label,
                    new BoxView { HeightRequest = 1.0, BackgroundColor = Color.Silver}
                }
            };
        }


        protected override void OnBindingContextChanged()
        {
            var vm = BindingContext as ExampleViewCellModel;

            if (vm != null)
            {
                vm.Animation = new AsyncCommand(async _ =>
                {
                    await _label.RelScaleTo(0.5, 250);
                    await Task.Delay(2000);
                });
            }

            base.OnBindingContextChanged();
        }
    }
}