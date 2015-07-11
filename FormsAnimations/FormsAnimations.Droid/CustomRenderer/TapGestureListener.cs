using System;
using Android.Views;

namespace FormsAnimations.Droid.CustomRenderer
{
    public class TapGestureListener : GestureDetector.SimpleOnGestureListener
    {
        public override bool OnDown(MotionEvent e)
        {
            Console.WriteLine("OnDown");
            return base.OnDown(e);
        }
    }
}