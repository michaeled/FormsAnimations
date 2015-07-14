using System;
using Xamarin.Forms;

namespace FormsAnimations
{
    public class ButtonPage : ContentPage
    {
        public ButtonPage()
        {
            var btn = new Button
            {
                Text = "Log In",
                VerticalOptions = LayoutOptions.CenterAndExpand,
                HorizontalOptions = LayoutOptions.Center
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

            var original = btn.Scale;

            foreach (var i in new[] { 1,3 })
            {
                await btn.RelScaleTo(0.09 / i, 190, Easing.SpringOut);
                await btn.RelScaleTo(-0.09 / i, 140, Easing.SpringOut);

                btn.Scale = original;
            }
        }
    }
}
