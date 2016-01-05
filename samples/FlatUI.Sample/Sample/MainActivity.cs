using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.Cengalabs.Flatui;
using Android.Graphics;
namespace Sample
{
    [Activity(Label = "Sample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            FlatUI.InitDefaultValues(this);
            FlatUI.SetDefaultTheme(FlatUI.Snow);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            int[] Mycolor = { Color.Black, Color.Black, Color.White, Color.Black };//,,背景,文字
            int[] Buttoncolor = new int[] { Color.Transparent, Color.Black, Color.Transparent, Color.White };
            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);
            FindViewById<Com.Cengalabs.Flatui.Views.FlatEditText>(Resource.Id.aaa).Attributes.SetColors(Mycolor);
            var a = FindViewById<Com.Cengalabs.Flatui.Views.FlatButton>(Resource.Id.bbb);
            a.Attributes.SetColors(Buttoncolor);
            a.Background.SetAlpha(50);
            //FindViewById<Com.Cengalabs.Flatui.Views.FlatEditText>(Resource.Id.aaa).Attributes.SetTheme(FlatUI.Sky,Resources);
            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

        }
    }
}

