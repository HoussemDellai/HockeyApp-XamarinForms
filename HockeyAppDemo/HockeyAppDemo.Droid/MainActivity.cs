using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using HockeyApp.Android;
using HockeyApp.Android.Metrics;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace HockeyAppDemo.Droid
{
    [Activity(Label = "HockeyAppDemo", 
        Icon = "@drawable/icon", 
        Theme = "@style/MainTheme", 
        MainLauncher = true, 
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {
        private string AppId = "e21fe78cf64a4eedb261b257151c55fd";
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            CrashManager.Register(this, AppId);
           
            // in your main activity OnCreate-method add:
            MetricsManager.Register(Application, AppId);

            Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

