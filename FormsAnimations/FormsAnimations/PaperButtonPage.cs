using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsAnimations
{
    public class PaperButtonPage : ContentPage
    {
        public PaperButtonPage()
        {
            Content = new StackLayout
            {
                Children = {
					new Label { Text = "Hello Paper Button Animation" }
				}
            };
        }
    }
}
