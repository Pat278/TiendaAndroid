using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Input;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Text;
using Android.Views;
using Android.Widget;
using GalaSoft.MvvmLight.Command;
using TiendaAndroid.Models;

namespace TiendaAndroid.ViewModels
{
    public  class LoginViewModel : LoginModel
    {
        private VerificarEmail _verificarEmail;
        //private readonly EditText _myEmail;

        public LoginViewModel(VerificarEmail verificarEmail)
        {
            _verificarEmail = verificarEmail;
            //_myEmail = myEmail;
        }

        public ICommand LoginCommand { get => new RelayCommand(login); }

        private void login()
        {
            //bool cancel = false;
            //View focusView = null;

            //if (TextUtils.IsEmpty(Email))
            //{
            //    _myEmail.SetError(_verificarEmail.GetString(Resource.String.error_field_required), null);
            //    focusView = _myEmail;
            //    cancel = true;

            //   // Toast.MakeText(_verificarEmail, "You must enter a Email!!!", ToastLength.Long).Show();

            //    return;
            //}

            //if (!IsEmailValid(Email))
            //{
            //    _myEmail.SetError(_verificarEmail.GetString(Resource.String.error_invalid_email), null);
            //    focusView = _myEmail;
            //    cancel = true;

            //    return;
            //}

            //if (cancel)
            //{
            //    focusView.RequestFocus();
            //}

            if (string.IsNullOrEmpty(Email))
            {
                      Toast.MakeText(_verificarEmail, "Please, You must enter a Email.", ToastLength.Long).Show();

                return;
            }

            if (!IsEmailValid(Email))
            {
                Toast.MakeText(_verificarEmail, "Please, You must enter a valid Email", ToastLength.Long).Show();
                return;
            }

            Toast.MakeText(_verificarEmail, Email, ToastLength.Long).Show();
        }

        private bool IsEmailValid(string email)
        {
            var expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";

            if (Regex.IsMatch(Email, expresion))
            {
                if (Regex.Replace(Email, expresion, string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}