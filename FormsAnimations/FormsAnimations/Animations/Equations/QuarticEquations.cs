using System;

namespace FormsAnimations.Animations.Equations
{
    public static class QuarticEquations
    {
        public static double EaseOut(double x)
        {
            return -1 * ((x - 1) * Math.Pow(x,3) - 1);
        }


        public static double EaseIn(double x)
        {
            return Math.Pow(x, 4);
        }



        public static double EaseInOut(double x)
        {
            if ((x/2) < 1)
                return -0.5*Math.Pow(x, 4);

            return -0.5 * ((x -= 2) * Math.Pow(x, 3) - 2);
        }
    }
}
