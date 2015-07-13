using Xamarin.Forms;

namespace FormsAnimations.Animations
{
    public class MoreEasing
    {
        public static readonly Easing ExpoEaseOut;
        public static readonly Easing ExpoEaseIn;
        public static readonly Easing ExpoEaseInOut;

        public static readonly Easing CircEaseOut;
        public static readonly Easing CircEaseIn;
        public static readonly Easing CircEaseInOut;

        public static readonly Easing QuadEaseOut;
        public static readonly Easing QuadEaseIn;
        public static readonly Easing QuadEaseInOut;

        public static readonly Easing QuartEaseOut;
        public static readonly Easing QuartEaseIn;
        public static readonly Easing QuartEaseInOut;

        public static readonly Easing QuintEaseOut;
        public static readonly Easing QuintEaseIn;
        public static readonly Easing QuintEaseInOut;

        public static readonly Easing ElasticEaseOut;
        public static readonly Easing ElasticEaseIn;

        public static readonly Easing BounceEaseOut;
        public static readonly Easing BounceEaseIn;
        public static readonly Easing BounceEaseInOut;
        public static readonly Easing BounceEaseOutIn;

        public static readonly Easing BackEaseOut;
        public static readonly Easing BackEaseIn;
        public static readonly Easing BackEaseInOut;
        public static readonly Easing BackEaseOutIn;


        static MoreEasing()
        {
            ExpoEaseOut = new Easing(EasingEquations.ExpoEaseOut);
            ExpoEaseIn = new Easing(EasingEquations.ExpoEaseIn);
            ExpoEaseInOut = new Easing(EasingEquations.ExpoEaseInOut);

            CircEaseOut = new Easing(EasingEquations.CircEaseOut);
            CircEaseIn = new Easing(EasingEquations.CircEaseIn);
            CircEaseInOut = new Easing(EasingEquations.CircEaseInOut);

            QuadEaseOut = new Easing(EasingEquations.QuadEaseOut);
            QuadEaseIn = new Easing(EasingEquations.QuadEaseIn);
            QuadEaseInOut = new Easing(EasingEquations.QuadEaseInOut);

            QuartEaseIn = new Easing(EasingEquations.QuartEaseIn);
            QuartEaseOut = new Easing(EasingEquations.QuartEaseOut);
            QuartEaseInOut = new Easing(EasingEquations.QuartEaseInOut);

            QuintEaseOut = new Easing(EasingEquations.QuintEaseOut);
            QuintEaseIn = new Easing(EasingEquations.QuintEaseIn);
            QuintEaseInOut = new Easing(EasingEquations.QuintEaseInOut);

            ElasticEaseOut = new Easing(EasingEquations.ElasticEaseOut);
            ElasticEaseIn = new Easing(EasingEquations.ElasticEaseIn);

            BounceEaseOut = new Easing(EasingEquations.BounceEaseOut);
            BounceEaseIn = new Easing(EasingEquations.BounceEaseIn);
            BounceEaseInOut = new Easing(EasingEquations.BounceEaseInOut);
            BounceEaseOutIn = new Easing(EasingEquations.BounceEaseOutIn);

            BackEaseOut = new Easing(EasingEquations.BackEaseOut);
            BackEaseIn = new Easing(EasingEquations.BackEaseIn);
            BackEaseInOut = new Easing(EasingEquations.BackEaseInOut);
            BackEaseOutIn = new Easing(EasingEquations.BackEaseOutIn);
        }
    }
}
