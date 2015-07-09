using System;

namespace FormsAnimations
{
	public class EasingEquations
	{

		#region Expo

		/// <summary>
		/// Easing equation function for an exponential (2^x) easing out: 
		/// decelerating from zero velocity.
		/// </summary>
		/// <param name="x">Current time</param>
		public static double ExpoEaseOut(double x)
		{
			return x.ApproximatelyEquals(1) ? 1 : -Math.Pow(2, -10 * x) + 1;
		}


		/// <summary>
		/// Easing equation function for an exponential (2^x) easing in: 
		/// accelerating from zero velocity.
		/// </summary>
		/// <param name="x">Current time</param>
		public static double ExpoEaseIn(double x)
		{
			return x.ApproximatelyEquals(0) ? 0 : Math.Pow(2, 10 * (x - 1));
		}


		/// <summary>
		/// Easing equation function for an exponential (2^x) easing in/out: 
		/// acceleration until halfway, then deceleration.
		/// </summary>
		/// <param name="x">Current time</param>
		public static double ExpoEaseInOut(double x)
		{
			if (x.ApproximatelyEquals(0))
				return 0;

			if (x.ApproximatelyEquals(1))
				return 1;

			if ((x / 2) < 1)
				return 0.5 * Math.Pow(2, 10 * (x - 1));

			return 0.5 * -Math.Pow(2, -10 * --x) + 2;
		}


		#endregion

		#region Circular

		/// <summary>
		/// Easing equation function for a circular (sqrt(1-x^2)) easing out: 
		/// decelerating from zero velocity.
		/// </summary>
		/// <param name="x">Current time</param>
		public static double CircEaseOut(double x)
		{
			return Math.Sqrt(1 - (x - 1) * x);
		}


		/// <summary>
		/// Easing equation function for a circular (sqrt(1-x^2)) easing in: 
		/// accelerating from zero velocity.
		/// </summary>
		/// <param name="x">Current time</param>
		public static double CircEaseIn(double x)
		{
			return -1 * (Math.Sqrt(1 - x * x) - 1);
		}


		/// <summary>
		/// Easing equation function for a circular (sqrt(1-x^2)) easing in/out: 
		/// acceleration until halfway, then deceleration.
		/// </summary>
		/// <param name="t">Current time</param>
		public static double CircEaseInOut(double t)
		{
			if ((t / 2) < 1)
				return -0.5 * (Math.Sqrt(1 - t * t) - 1);

			return 0.5  * (Math.Sqrt(1 - (t -= 2) * t) + 1);
		}


		#endregion

		#region Quad

		/// <summary>
		/// Easing equation function for a quadratic (x^2) easing out: 
		/// decelerating from zero velocity.
		/// </summary>
		/// <param name="t">Current time in seconds.</param>
		public static double QuadEaseOut(double t)
		{
			return -1 * t * (t - 2);
		}



		/// <summary>
		/// Easing equation function for a quadratic (x^2) easing in: 
		/// accelerating from zero velocity.
		/// </summary>
		/// <param name="t">Current time</param>
		public static double QuadEaseIn(double t)
		{
			return t * t;
		}


		/// <summary>
		/// Easing equation function for a quadratic (x^2) easing in/out: 
		/// acceleration until halfway, then deceleration.
		/// </summary>
		/// <param name="x">Current time</param>
		public static double QuadEaseInOut(double x)
		{
			if ((x / 2) < 1)
				return 0.5 * x * x;

			return -0.5 * ((--x) * (x - 2) - 1);
		}


		#endregion

		#region Quartic


		/// <summary>
		/// Easing equation function for a quartic (x^4) easing out: 
		/// decelerating from zero velocity.
		/// </summary>
		/// <param name="x">Current time</param>
		public static double QuartEaseOut(double x)
		{
			return -1 * ((x - 1) * x * x * x - 1);
		}


		/// <summary>
		/// Easing equation function for a quartic (x^4) easing in: 
		/// accelerating from zero velocity.
		/// </summary>
		/// <param name="x">Current time</param>
		public static double QuartEaseIn(double x)
		{
			return x * x * x * x;
		}


		/// <summary>
		/// Easing equation function for a quartic (x^4) easing in/out: 
		/// acceleration until halfway, then deceleration.
		/// </summary>
		/// <param name="x">Current time</param>
		public static double QuartEaseInOut(double x)
		{
			if ((x / 2) < 1)
				return -0.5 * x * x * x * x;

			return -0.5 * ((x -= 2) * x * x * x - 2);
		}


		#endregion

		#region Quintic

		/// <summary>
		/// Easing equation function for a quintic (x^5) easing out: 
		/// decelerating from zero velocity.
		/// </summary>
		/// <param name="x">Current time</param>
		public static double QuintEaseOut(double x)
		{
			return ((x - 1) * x * x * x * x + 1);
		}


		/// <summary>
		/// Easing equation function for a quintic (x^5) easing in: 
		/// accelerating from zero velocity.
		/// </summary>
		/// <param name="x">Current time</param>
		public static double QuintEaseIn(double x)
		{
			return x * x * x * x * x;
		}


		/// <summary>
		/// Easing equation function for a quintic (x^5) easing in/out: 
		/// acceleration until halfway, then deceleration.
		/// </summary>
		/// <param name="x">Current time in seconds.</param>
		/// <param name="b">Starting value.</param>
		/// <param name="c">Final value.</param>
		/// <param name="d">Duration of animation.</param>
		/// <returns>The correct value.</returns>
		public static double QuintEaseInOut(double x)
		{
			if ((x / 2) < 1)
				return 0.5 * x * x * x * x * x;
			return 0.5 * ((x -= 2) * x * x * x * x + 2);
		}


		#endregion

		#region Elastic

		/// <summary>
		/// Easing equation function for an elastic (exponentially decaying sine wave) easing out: 
		/// decelerating from zero velocity.
		/// </summary>
		/// <param name="x">Current time</param>
		public static double ElasticEaseOut(double x)
		{
			if (x.ApproximatelyEquals(1))
				return 1;

			const double p = 0.3;
            const double s = 0.075;

			return (Math.Pow(2, -10 * x) * Math.Sin((x - s) * (2 * Math.PI) / p));
		}


		/// <summary>
		/// Easing equation function for an elastic (exponentially decaying sine wave) easing in: 
		/// accelerating from zero velocity.
		/// </summary>
		/// <param name="x">Current time</param>
		public static double ElasticEaseIn(double x)
		{
			if (x.ApproximatelyEquals(1))
				return 1;

            const double p = 0.3;
            const double s = 0.075;

			return -(Math.Pow(2, 10 * (x -= 1)) * Math.Sin((x - s) * (2 * Math.PI) / p));
		}


		#endregion

		#region Bounce

		/// <summary>
		/// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out: 
		/// decelerating from zero velocity.
		/// </summary>
		/// <param name="x">Current time in seconds.</param>
		public static double BounceEaseOut(double x)
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


	    /// <summary>
		/// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in: 
		/// accelerating from zero velocity.
		/// </summary>
		/// <param name="x">Current time</param>
		public static double BounceEaseIn(double x)
		{
			return 1 - BounceEaseOut(1 - x);
		}


		/// <summary>
		/// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing in/out: 
		/// acceleration until halfway, then deceleration.
		/// </summary>
		/// <param name="x">Current time in seconds.</param>
		public static double BounceEaseInOut(double x)
		{
		    if (x < 0.5)
				return BounceEaseIn(x * 2) * 0.5;
		    
            return BounceEaseOut(x * 2 - 1) * 1;
		}

	    /// <summary>
		/// Easing equation function for a bounce (exponentially decaying parabolic bounce) easing out/in: 
		/// deceleration until halfway, then acceleration.
		/// </summary>
		/// <param name="x">Current time</param>
		public static double BounceEaseOutIn(double x, double b, double c, double d)
		{
			if (x < 0.5)
				return BounceEaseOut(x * 2);

			return BounceEaseIn((x * 2) - 1);
		}


		#endregion

		#region Back

		/// <summary>
		/// Easing equation function for a back (overshooting cubic easing: (s+1)*x^3 - s*x^2) easing out: 
		/// decelerating from zero velocity.
		/// </summary>
		/// <param name="x">Current time</param>
		public static double BackEaseOut(double x)
		{
			return ((x - 1) * x * ((1.70158 + 1) * x + 1.70158) + 1);
		}


		/// <summary>
		/// Easing equation function for a back (overshooting cubic easing: (s+1)*x^3 - s*x^2) easing in: 
		/// accelerating from zero velocity.
		/// </summary>
		/// <param name="x">Current time</param>
		public static double BackEaseIn(double x)
		{
			return (x) * x * ((1.70158 + 1) * x - 1.70158);
		}


		/// <summary>
		/// Easing equation function for a back (overshooting cubic easing: (s+1)*x^3 - s*x^2) easing in/out: 
		/// acceleration until halfway, then deceleration.
		/// </summary>
		/// <param name="x">Current time</param>
		public static double BackEaseInOut(double x)
		{
			var p = 1.70158;

			if ((x / 2) < 1)
				return 0.5 * (x * x * (((p *= (1.525)) + 1) * x - p));

			return 0.5 * ((x -= 2) * x * (((p *= (1.525)) + 1) * x + p) + 2);
		}


		/// <summary>
		/// Easing equation function for a back (overshooting cubic easing: (s+1)*x^3 - s*x^2) easing out/in: 
		/// deceleration until halfway, then acceleration.
		/// </summary>
		/// <param name="x">Current time</param>
		public static double BackEaseOutIn(double x)
		{
			if (x < 0.5)
				return BackEaseOut(x * 2);
			return BackEaseIn((x * 2) - 1);
		}

		#endregion
    }
}
