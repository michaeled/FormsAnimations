namespace FormsAnimations.Animations.Equations
{
    public static class QuadEquations
    {
        public static double EaseOut(double t)
        {
            return -1 * t * (t - 2);
        }


        public static double EaseIn(double t)
        {
            return t * t;
        }


        public static double EaseInOut(double x)
        {
            if ((x / 2) < 1)
                return 0.5 * x * x;

            return -0.5 * ((--x) * (x - 2) - 1);
        }
    }
}
