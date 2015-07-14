using System;

namespace FormsAnimations.Animations.Equations
{
    public static class QuinticEquations
    {
        public static double EaseOut(double x)
        {
            return ((x - 1) * Math.Pow(x, 4) + 1);
        }


        public static double EaseIn(double x)
        {
            return Math.Pow(x, 5);
        }


        public static double EaseInOut(double x)
        {
            if ((x/2) < 1)
                return 0.5*Math.Pow(x, 5);

            return 0.5 * ((x -= 2) * Math.Pow(x,4) + 2);
        }
    }
}
