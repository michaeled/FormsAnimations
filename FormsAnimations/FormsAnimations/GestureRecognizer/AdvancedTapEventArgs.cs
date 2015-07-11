using System;
using Xamarin.Forms;

namespace FormsAnimations.GestureRecognizer
{
    public class AdvancedTapEventArgs : EventArgs
    {
        public View Control { get; set; }
        public bool Handled { get; set; }
    }
}
