using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using WpfApp1.Mvvm.Commands;

namespace WpfApp1.ViewModels
{
    public class LoginViewModel : ViewModelsBase
    {
        #region 
        public DelegateCommand ExitCommand { get; }
        public DelegateCommand LoginCommand { get; }

        public ICommand PasswordChangedCommand { get; set; }

        #endregion
        string _username;
        private string _pass;
        public string UserName
        {
            get => _username;
            set {
                SetProperty(ref _username, value);
                LoginCommand.RaiseCanExecuteChanged();
                }

        }
        public string PassWord
        {
            get => _pass;
            set {
                SetProperty(ref _pass, value);
                LoginCommand.RaiseCanExecuteChanged();
            }

        }       
        public LoginViewModel()
        {
            ExitCommand = new DelegateCommand(Exit);
            LoginCommand = new DelegateCommand(Login, Checkvalidate);
            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { 
                if(p!=null) PassWord = p.Password; });

        }
        public void setpass(object passbox)
        {

        }
        public void Exit()
        {
            Application.Current.Shutdown();

        }
        public void Login()
        {
            //PasswordBox pwBox = obj as PasswordBox;
            //string pass = pwBox.Password;
        }
        public bool Checkvalidate()
        {
              
            return !string.IsNullOrEmpty(UserName)&&!string.IsNullOrEmpty(PassWord);
        }
    }
}
