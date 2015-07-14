using System;

namespace FormsAnimations.Animations.Equations
{
    public static class CircularEquations
    {
        public static double EaseOut(double x)
        {
            return Math.Sqrt(1 - (x - 1) * x);
        }


        public static double EaseIn(double x)
        {
            return -1 * (Math.Sqrt(1 - x * x) - 1);
        }


        public static double EaseInOut(double t)
        {
            if ((t / 2) < 1)
                return -0.5 * (Math.Sqrt(1 - t * t) - 1);

            return 0.5 * (Math.Sqrt(1 - (t -= 2) * t) + 1);
        }
    }
}