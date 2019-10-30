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
using GalaSoft.MvvmLight.Helpers;
using TiendaAndroid.ViewModels;

namespace TiendaAndroid
{
    [Activity(Label = "@string/app_name", MainLauncher = true, Theme = "@style/AppTheme.NoActionBar")]
    public class VerificarEmail : Activity
    {
        private Button _myButton;
        private LoginViewModel _loginViewModel;
        private EditText _myEmail;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here

            SetContentView(Resource.Layout.VerificarEmail);
            Window window = Window;
            window.ClearFlags(WindowManagerFlags.TranslucentStatus);
            window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
            window.SetStatusBarColor(Android.Graphics.Color.ParseColor("#1b3147"));

            _myEmail = FindViewById<EditText>(Resource.Id.email);
            _myButton = FindViewById<Button>(Resource.Id.email_sign_in_button);

            _loginViewModel = new LoginViewModel(this, _myEmail);

            this.SetBinding(() => _myEmail.Text, () => _loginViewModel.Email);
            _myButton.SetCommand("Click", _loginViewModel.LoginCommand);


        
        }
    }
}