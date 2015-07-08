using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsAnimations
{
    public class PasswordIndicatorPage : ContentPage
    {
        public PasswordIndicatorPage()
        {
            Content = new StackLayout
            {
                Children = {
					new Label { Text = "Hello PasswordIndicatorPage" }
				}
            };
        }
    }
}
