using System;

namespace FormsAnimations.Animations.Equations
{
    public static class SinusoidalEquations
    {
        public static double Dampened(double x)
        {
            // y = a * sin (bx - c) + d
            // a = amplitude
            // b = period (stretch or compress)
            // c = horizontal translation (move graph left or right)
            // d = vertical translation
            return Math.Sin((10 * x) - x / 2) * Math.Exp(-x);
        }
    }
}