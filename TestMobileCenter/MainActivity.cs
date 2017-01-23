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
            
            MobileCenter.Start("5cd5e970-8a56-4c96-87f0-48a48c4483bd",
                    typeof(Analytics), typeof(Crashes));
           
            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            var button = this.FindViewById<Button>(Resource.Id.button1);
            button.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            float y = 0;
            float x = 5;
            Console.WriteLine($"result = {x/y}");
        }
    }
}

