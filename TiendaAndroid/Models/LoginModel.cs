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
using GalaSoft.MvvmLight;

namespace TiendaAndroid.Models
{
    public class LoginModel : ViewModelBase
    {
        private string _email = string.Empty;

        public string Email 
        { 
            get => _email;
            set 
            {
                Set(() => Email, ref _email, value);
            }
        
        }
    }
}