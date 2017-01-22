using Android.App;
using Android.Widget;
using Android.OS;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using System;

namespace TestMobileCenter
{
    [Activity(Label = "TestMobileCenter", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            int y = 1;
            int x = 5;
            MobileCenter.Start("5cd5e970-8a56-4c96-87f0-48a48c4483bd",
                    typeof(Analytics), typeof(Crashes));
            Console.WriteLine(x / (y - 1));
            // Set our view from the "main" layout resource
            // SetContentView (Resource.Layout.Main);
        }
    }
}

