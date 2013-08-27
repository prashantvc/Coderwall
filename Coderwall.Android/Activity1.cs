using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using CoderwallLib;

namespace Coderwall.Android
{
    [Activity(Label = "Coderwall.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += async delegate
                {
                    var cw = new CoderwallContext();
                    var profile = await cw.GetProfileAsync("prashantvc");

                    button.Text = string.Format("Username: {0}", profile.name);
                };
        }
    }
}

