namespace FormsAnimations.Animations.Equations
{
    public static class BounceEquations
    {
        public static double EaseOut(double x)
        {
            const double i = 7.5625;

            if (x < (1 / 2.75))
                return i * x * x;
            if (x < (2 / 2.75))
                return (i * (x -= (1.5 / 2.75)) * x + .75);
            if (x < (2.5 / 2.75))
                return (i * (x -= (2.25 / 2.75)) * x + .9375);

            return (i * (x -= (2.625 / 2.75)) * x + .984375);
        }


        public static double EaseIn(double x)
        {
            return 1 - EaseOut(1 - x);
        }


        public static double EaseInOut(double x)
        {
            if (x < 0.5)
                return EaseIn(x * 2) * 0.5;

            return EaseOut(x * 2 - 1) * 1;
        }


        public static double EaseOutIn(double x)
        {
            if (x < 0.5)
                return EaseOut(x * 2);

            return EaseIn((x * 2) - 1);
        }
    }
}
