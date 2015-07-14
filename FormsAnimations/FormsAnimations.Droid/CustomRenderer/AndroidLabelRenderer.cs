using Android.Graphics;
using Android.Views;
using Android.Views.Animations;
using FormsAnimations.Droid.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Label), typeof(AndroidLabelRenderer))]

namespace FormsAnimations.Droid.CustomRenderer
{
    public class AndroidLabelRenderer : LabelRenderer
    {
        private readonly GestureDetector _detector;


        public AndroidLabelRenderer()
        {
            var listener = new AndroidTapGestureListener();
            _detector = new GestureDetector(listener);
        }


        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            Control.Typeface = Typeface.CreateFromAsset(Forms.Context.Assets, "fonts/Nunito-Light.ttf");
        }


        protected override void OnDraw(Canvas canvas)
        {
            base.OnDraw(canvas);
       
        }
    }
}