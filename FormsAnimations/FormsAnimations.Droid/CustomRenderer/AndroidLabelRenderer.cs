using Android.Graphics;
using Android.Views;
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
            var listener = new TapGestureListener();
            _detector = new GestureDetector(listener);
        }


        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            var font = Typeface.CreateFromAsset(Forms.Context.Assets, "fonts/Nunito-Light.ttf");
            Control.Typeface = font;

            if (e.NewElement == null)
            {
                GenericMotion -= HandleGenericMotion;
                Touch -= HandleTouch;
            }

            if (e.OldElement == null)
            {
                GenericMotion += HandleGenericMotion;
                Touch += HandleTouch;
            }
        }


        private void HandleTouch(object sender, TouchEventArgs e)
        {
            e.Handled = false;
            _detector.OnTouchEvent(e.Event);
        }


        private void HandleGenericMotion(object sender, GenericMotionEventArgs e)
        {
            e.Handled = false;
            _detector.OnTouchEvent(e.Event);
        }
    }
}