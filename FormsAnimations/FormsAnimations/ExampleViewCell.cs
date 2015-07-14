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
                }
            };
        }
        

        protected override void OnBindingContextChanged()
        {
            var vm = BindingContext as ExampleViewCellModel;

            if (vm != null)
            {
                vm.TappedAnimation = new AsyncCommand(async _ =>
                {
                    await _label.RotateYTo(-3.0, 80, Easing.Linear);
                });

                vm.Reset = new Command(() =>
                {
                    _label.RotationY = 0;
                });
            }

            base.OnBindingContextChanged();
        }
    }
}