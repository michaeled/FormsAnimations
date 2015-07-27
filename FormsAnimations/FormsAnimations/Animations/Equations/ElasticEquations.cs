using System;

namespace FormsAnimations.Animations.Equations
{
    public static class ElasticEquations
    {
        const double P = 0.3;
        const double S = 0.075;


        public static double EaseOut(double x)
        {
            if (x.ApproximatelyEquals(1)) return 1;

            return Math.Pow(2, -10 * x) * Math.Sin((x - P / 4) * (2 * Math.PI) / P) + 1;
        }


        public static double EaseIn(double x)
        {
            if (x.ApproximatelyEquals(0)) return 0;
            if (x.ApproximatelyEquals(1)) return 1;

            return -(Math.Pow(2, 10 * (x -= 1)) * Math.Sin((x - S) * (2 * Math.PI) / P));
        }
    }
}