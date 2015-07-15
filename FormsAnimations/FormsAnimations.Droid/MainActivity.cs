using System;
using Android.App;
using Android.Content.PM;
using Android.Graphics;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace FormsAnimations.Droid
{
    [Activity(Label = "FormsAnimations", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            App.ScreenSize = new Size
            (
                Resources.DisplayMetrics.WidthPixels / Resources.DisplayMetrics.Density,
                Resources.DisplayMetrics.HeightPixels / Resources.DisplayMetrics.Density
            );

            ActionBar.SetIcon(Android.Resource.Color.Transparent);

            Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

