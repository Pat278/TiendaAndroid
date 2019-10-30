using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using GalaSoft.MvvmLight.Command;
using TiendaAndroid.Models;

namespace TiendaAndroid.ViewModels
{
    public  class LoginViewModel : LoginModel
    {
        private VerificarEmail _verificarEmail;

        public LoginViewModel(VerificarEmail verificarEmail)
        {
            _verificarEmail = verificarEmail;
        }

        public ICommand LoginCommand { get => new RelayCommand(login); }

        private void login()
        {
            Toast.MakeText(_verificarEmail, Email, ToastLength.Long).Show();
        }
    }
}