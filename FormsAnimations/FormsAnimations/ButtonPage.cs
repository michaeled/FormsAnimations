using System;
using System.Threading.Tasks;
using FormsAnimations.Animations;
using Xamarin.Forms;

namespace FormsAnimations
{
    public class ButtonPage : ContentPage
    {
        private bool _pulse = true;


        public ButtonPage()
        {
            var btn = new Button
            {
                Text = "Log In",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center,
                WidthRequest = 100,
                HeightRequest = 43
            };

            btn.Clicked += Button_Clicked;

            Content = new StackLayout
            {
                Children = 
                {
                    btn
				}
            };
        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn == null) return;

            btn.IsEnabled = false;

            if (_pulse)
            {
                await Pulse(btn);
            }
            else
            {
                await Spring(btn);
            }

            _pulse = !_pulse;

            btn.IsEnabled = true;
        }


        private async Task Pulse(Button btn)
        {
            var original = btn.Scale;

            foreach (var i in new[] { 1, 3 })
            {
                await btn.RelScaleTo(0.09 / i, 190, Easing.SpringOut);
                await btn.RelScaleTo(-0.09 / i, 140, Easing.SpringOut);

                btn.Scale = original;
            }
        }



        private async Task Spring(Button btn)
        {
            await btn.RelTranslateX(50, 200, MoreEasing.SinDampened);
        }
    }
}
