using System;

namespace FormsAnimations.Animations.Equations
{
    public static class ExponentialEquations
    {
        public static double EaseOut(double x)
        {
            return x.ApproximatelyEquals(1) ? 1 : -Math.Pow(2, -10 * x) + 1;
        }


        public static double EaseIn(double x)
        {
            return x.ApproximatelyEquals(0) ? 0 : Math.Pow(2, 10 * (x - 1));
        }


        public static double EaseInOut(double x)
        {
            if (x.ApproximatelyEquals(0)) return 0;
            if (x.ApproximatelyEquals(1)) return 1;

            if ((x / 2) < 1)
                return 0.5 * Math.Pow(2, 10 * (x - 1));

            return 0.5 * -Math.Pow(2, -10 * --x) + 2;
        }
    }
}