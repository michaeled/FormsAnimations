﻿namespace FormsAnimations.Animations.Equations
{
    public static class QuinticEquations
    {
        public static double EaseOut(double x)
        {
            return ((x - 1) * x * x * x * x + 1);
        }


        public static double EaseIn(double x)
        {
            return x * x * x * x * x;
        }


        public static double EaseInOut(double x)
        {
            if ((x / 2) < 1)
                return 0.5 * x * x * x * x * x;
            return 0.5 * ((x -= 2) * x * x * x * x + 2);
        }
    }
}