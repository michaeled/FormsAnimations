using System;

namespace FormsAnimations.Animations.Equations
{
    public static class ElasticEquations
    {
        public static double EaseOut(double x)
        {
            if (x.ApproximatelyEquals(1))
                return 1;

            const double p = 0.3;
            const double s = 0.075;

            return (Math.Pow(2, -10 * x) * Math.Sin((x - s) * (2 * Math.PI) / p));
        }


        public static double EaseIn(double x)
        {
            if (x.ApproximatelyEquals(1))
                return 1;

            const double p = 0.3;
            const double s = 0.075;

            return -(Math.Pow(2, 10 * (x -= 1)) * Math.Sin((x - s) * (2 * Math.PI) / p));
        }
    }
}