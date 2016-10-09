using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using HockeyApp.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace HockeyAppDemo.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : FormsApplicationDelegate
    {
        private string AppId = "e21fe78cf64a4eedb261b257151c55fd";
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            var manager = BITHockeyManager.SharedHockeyManager;
            manager.Configure(AppId);
            manager.StartManager();
            manager.Authenticator.AuthenticateInstallation(); // This line is obsolete in crash only builds

            Forms.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
