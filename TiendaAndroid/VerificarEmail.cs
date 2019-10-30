using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TiendaAndroid
{
    [Activity(Label = "@string/app_name", MainLauncher = true, Theme = "@style/AppTheme.NoActionBar")]
    public class VerificarEmail : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.VerificarEmail);
        }
    }
}