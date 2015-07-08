using System;
using System.Diagnostics;
using Xamarin.Forms;

namespace FormsAnimations
{
    internal static class AnimationLibrary
    {
        private static double QuinticEaseOut(double arg)
        {
            int c = 1;
            double t = arg;
            int d = 1;

            return  c * ((t = t / d - 1) * t * t * t * t + 1);
        }


        private static double LinearEaseOut(double arg)
        {
            return arg;
        }


        internal static Animation Grow(VisualElement element, uint startAt, uint endAt)
        {
            var qeo = new Easing(QuinticEaseOut);
            
            var oWidth = element.Width;
            var oHeight = element.Height;
            var duration = endAt - startAt;
            var ws = element.Width/App.ScreenSize.Width;
            var hs = element.Width/App.ScreenSize.Height;

            var animation = new Animation
            (
                callback: eased =>
                {
                    var widthChange = (eased/duration)*ws + 1;
                    var heightChange = (eased/duration)*hs + 1;

                    element.WidthRequest = oWidth * widthChange;
                    element.HeightRequest = oHeight * widthChange;

                    Debug.WriteLine("W = {0}; H= {1}", widthChange, heightChange);
                },
                start: startAt,
                end: endAt,
                easing: qeo,
                finished: () => Debug.WriteLine("Not called when this is executed by the Animation extensions.")

            );

            return animation;
        }
    }


    public static class AnimationPlayer
    {
        public static void Grow(VisualElement element, TimeSpan duration, int repeat = 0)
        {
            var ms = (uint) duration.TotalMilliseconds;
            
            element.Animate
            (
                name: "Grow",
                animation: AnimationLibrary.Grow(element, 0, ms), 
                length: ms,
                finished: (eased, unused) =>
                {
                    repeat--;
                },
                repeat: () => repeat >= 1
            );
        }
    }
}
