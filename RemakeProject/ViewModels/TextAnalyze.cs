
using RemakeProject.ViewModels.Commands;
using RemakeProject.Views;
using System;
using System.Windows;

namespace RemakeProject.ViewModels
{
    class TextAnalyze : ViewModelBase
    {
      
        private string _textBox;
        public string CurrentUser
        {
            get => Properties.Settings.Default.UserLogin;
        }
        public string Text
        {
            get => _textBox;
            set
            {
                _textBox = value;
                OnPropertyChanged("");
            }
        }
        public string Vowels
        {
            get
            {
                return Convert.ToString(HelperAnalyzer.CountVowels(_textBox));
            }
        }
        public string Consonants
        {
            get
            {
                return Convert.ToString(HelperAnalyzer.CountConsonants(_textBox));
            }
        }
        public string Numbers
        {
            get
            {
                return Convert.ToString(HelperAnalyzer.CountNumbers(_textBox));
            }
        }
        public string SpecialSymbols
        {
            get
            {
                return Convert.ToString(HelperAnalyzer.CountSpecialSymbols(_textBox));
            }
        }

        public DelegateCommand FileInput { get; set; }
        public DelegateCommand LogOut { get; private set; }


        public TextAnalyze()
        {
                      
            FileInput = new DelegateCommand(GetFile);
            LogOut = new DelegateCommand(Logout);
        }

        public void GetFile()
        {
            _textBox = FileTextInput.FileInput();
            OnPropertyChanged("");
        }
        public void Logout()
        {
            LoginMenu loginMenu = new();
            var window = Application.Current.MainWindow;
            window.Close();
            Application.Current.MainWindow = loginMenu;
            loginMenu.Show();           
        }
    }

}
