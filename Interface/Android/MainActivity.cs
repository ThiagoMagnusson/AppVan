﻿using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Android
{
    [Activity(Label = "Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button BtEntrar = FindViewById<Button>(Resource.Id.BtEntrar);            
        }

        public void Entrar(View v)
        {
            Toast.MakeText(this, "CLICOU ENTRAR", ToastLength.Long).Show();
        }
    }
}

