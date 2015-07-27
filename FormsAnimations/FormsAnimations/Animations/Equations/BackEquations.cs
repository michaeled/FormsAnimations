namespace FormsAnimations.Animations.Equations
{
    public static class BackEquations
    {
        const double S = 1.70158;


        public static double EaseOut(double x)
        {
            return ((x - 1) * x * ((S + 1) * x + S)) + 1;
        }


        public static double EaseIn(double x)
        {
            return x * x * ((S + 1) * x - S);
        }


        public static double EaseInOut(double x)
        {
            var ls = S;

            if ((x / 2) < 1)
                return 0.5 * (x * x * (((ls *= (1.525)) + 1) * x - ls));

            return 0.5 * ((x -= 2) * x * (((ls *= (1.525)) + 1) * x + ls) + 2);
        }


        public static double EaseOutIn(double x)
        {
            return x < 0.5 ? EaseOut(x * 2) : EaseIn((x * 2) - 1);
        }
    }
}
