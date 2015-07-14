using FormsAnimations.Animations.Equations;
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
            ExpoEaseOut = new Easing(ExponentialEquations.EaseOut);
            ExpoEaseIn = new Easing(ExponentialEquations.EaseIn);
            ExpoEaseInOut = new Easing(ExponentialEquations.EaseInOut);

            CircEaseOut = new Easing(CircularEquations.EaseOut);
            CircEaseIn = new Easing(CircularEquations.EaseIn);
            CircEaseInOut = new Easing(CircularEquations.EaseInOut);

            QuadEaseOut = new Easing(QuadEquations.EaseOut);
            QuadEaseIn = new Easing(QuadEquations.EaseIn);
            QuadEaseInOut = new Easing(QuadEquations.EaseInOut);

            QuartEaseIn = new Easing(QuarticEquations.EaseIn);
            QuartEaseOut = new Easing(QuarticEquations.EaseOut);
            QuartEaseInOut = new Easing(QuarticEquations.EaseInOut);

            QuintEaseOut = new Easing(QuinticEquations.EaseOut);
            QuintEaseIn = new Easing(QuinticEquations.EaseIn);
            QuintEaseInOut = new Easing(QuinticEquations.EaseInOut);

            ElasticEaseOut = new Easing(ElasticEquations.EaseOut);
            ElasticEaseIn = new Easing(ElasticEquations.EaseIn);

            BounceEaseOut = new Easing(BounceEquations.EaseOut);
            BounceEaseIn = new Easing(BounceEquations.EaseIn);
            BounceEaseInOut = new Easing(BounceEquations.EaseInOut);
            BounceEaseOutIn = new Easing(BounceEquations.EaseOutIn);

            BackEaseOut = new Easing(BackEquations.EaseOut);
            BackEaseIn = new Easing(BackEquations.EaseIn);
            BackEaseInOut = new Easing(BackEquations.EaseInOut);
            BackEaseOutIn = new Easing(BackEquations.EaseOutIn);
        }
    }
}
