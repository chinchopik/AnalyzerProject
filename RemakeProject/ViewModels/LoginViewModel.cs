using RemakeProject.ViewModels.Commands;
using System.Windows;

namespace RemakeProject.ViewModels
{
    class LoginViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get;}

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


        public DelegateCommand Authentification { get; private set; }

        public LoginViewModel()
        {
            Authentification = new DelegateCommand(Auth);
        }


        public void Auth()
        {
            if(Login != null && Password != null)
            {
                if (Login == "admin" && Password == "admin")
                {
                    AnalyzerMenu analyzerMenu = new();
                    var window = Application.Current.MainWindow;
                    window.Close();
                    Application.Current.MainWindow = analyzerMenu;
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
