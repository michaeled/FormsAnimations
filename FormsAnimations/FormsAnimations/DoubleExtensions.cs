using System;

namespace FormsAnimations
{
    public static class DoubleExtensions
    {
        public static bool ApproximatelyEquals(this double x, double y)
        {
            var epsilon = Math.Max(Math.Abs(x), Math.Abs(y)) * 1E-15;
            return Math.Abs(x - y) <= epsilon;
        }
    }
}