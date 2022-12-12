using RemakeProject.ViewModels.Commands;
using RemakeProject.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace RemakeProject.ViewModels
{
    class LoginViewModel : ViewModelBase
    {
        private string _password;
        public string Login
        {
            get => Properties.Settings.Default.UserLogin;
            set
            {
                Properties.Settings.Default.UserLogin = value;
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }


        public Auth Authentification { get; private set; }

        public LoginViewModel()
        {
            Authentification = new Auth(Auth);
        }

        public void Auth()
        {
            if(Login != null && Password != null)
            {
                if (Login == "admin" && Password == "admin")
                {
                    AnalyzerMenu analyzerMenu = new();

                    Window window = Application.Current.Windows[0];
                    window.Close();
                    analyzerMenu.Show();
                }
                else
                {
                    MessageBox.Show("Invalid login or password!", "Error!", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private bool _isChecked;

        public bool IsChecked
        {
            get => _isChecked;
            set
            {
                if (_isChecked == value) return;
                _isChecked = value;
            }
        }
    }
}
