using System.Collections.Generic;
using System.Linq;
using Android.Graphics;
using Android.Views;
using FormsAnimations.Droid.CustomRenderer;
using FormsAnimations.GestureRecognizer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Label), typeof(AndroidLabelRenderer))]

namespace FormsAnimations.Droid.CustomRenderer
{
    public class AndroidLabelRenderer : LabelRenderer
    {
        private readonly GestureDetector _detector;
        private Label _formsObject;


        public AndroidLabelRenderer()
        {
            var listener = new AndroidTapGestureListener();
            _detector = new GestureDetector(listener);
        }


        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            Control.Typeface = Typeface.CreateFromAsset(Forms.Context.Assets, "fonts/Nunito-Light.ttf");

            if (e.NewElement == null)
            {
                Touch -= OnTouch;
            }

            if (e.OldElement == null)
            {
                Touch += OnTouch;
            }

            if (e.NewElement != null)
            {
                _formsObject = e.NewElement;
            }
        }


        private void OnTouch(object sender, TouchEventArgs e)
        {
            var listeners = GetAdvancecdListeners();
            var tapEvent = new AdvancedTapEventArgs();

            foreach (var listener in listeners)
            {
                tapEvent.Control = _formsObject;
                listener.Command.Execute(tapEvent);
            }

            e.Handled = tapEvent.Handled;
            _detector.OnTouchEvent(e.Event);
        }


        private IEnumerable<AdvancedTapGestureRecognizer> GetAdvancecdListeners()
        {
            if (_formsObject == null)
            {
                return new AdvancedTapGestureRecognizer[] {};
            }

            var listeners = _formsObject.GestureRecognizers
                .OfType<AdvancedTapGestureRecognizer>()
                .ToArray();

            return listeners;
        }
    }
}