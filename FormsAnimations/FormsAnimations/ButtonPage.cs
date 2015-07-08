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


        private void Button_Clicked(object sender, EventArgs e)
        {
            var btn = sender as Button;
            AnimationPlayer.Grow(btn, TimeSpan.FromMilliseconds(300));
        }
    }
}
