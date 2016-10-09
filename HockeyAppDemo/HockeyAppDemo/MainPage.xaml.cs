using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HockeyAppDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var didCrashInLastSession = HockeyApp.CrashManager.DidCrashInLastSession;

            DidCrashLabel.Text += didCrashInLastSession;
        }
        
        private void TackEvent_Clicked(object sender, EventArgs e)
        {
            try
            {
                HockeyApp.MetricsManager.TrackEvent(
                    "Clicked Track Event Button",
                    new Dictionary<string, string>
                    {
                        { "time", DateTime.UtcNow.ToString() }
                    },
                    new Dictionary<string, double>
                    {
                        { "value", 1.0 }
                    });
            }
            catch (Exception exception)
            {
            }
        }

        private void CrashApp_Clicked(object sender, EventArgs e)
        {
            throw new Exception();
        }
    }
}
