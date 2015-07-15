using Android.Graphics;
using FormsAnimations.Droid.CustomRenderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Label), typeof(AndroidLabelRenderer))]

namespace FormsAnimations.Droid.CustomRenderer
{
    public class AndroidLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            Control.Typeface = Typeface.CreateFromAsset(Forms.Context.Assets, "fonts/Nunito-Light.ttf");
        }
    }
}