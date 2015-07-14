namespace FormsAnimations.Animations.Equations
{
    public static class BackEquations
    {
        public static double EaseOut(double x)
        {
            const double s = 1.70158;
            return ((x - 1) * x * ((s + 1) * x + s)) + 1;
        }


        public static double EaseIn(double x)
        {
            const double s = 1.70158;
            return x * x * ((s + 1) * x - s);
        }


        public static double EaseInOut(double x)
        {
            var s = 1.70158;

            if ((x / 2) < 1)
                return 0.5 * (x * x * (((s *= (1.525)) + 1) * x - s));

            return 0.5 * ((x -= 2) * x * (((s *= (1.525)) + 1) * x + s) + 2);
        }


        public static double EaseOutIn(double x)
        {
            if (x < 0.5)
                return EaseOut(x * 2);
            return EaseIn((x * 2) - 1);
        }
    }
}
