using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApp1.ViewModels;

namespace WpfApp1.View
{
    /// <summary>
    /// Interaction logic for LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();            
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton==MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        //private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        //{
        //    if (txtUserName.Text == "UserName")
        //    {
        //        txtUserName.Text = "";
        //    }
        //}

        //private void txtUserName_LostFocus(object sender, RoutedEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtUserName.Text))
        //        txtUserName.Text = "UserName";
        //}

        //private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        //{            
        //        if (txtPassword.Password == "Password")
        //    {
        //        txtPassword.Password="";
        //    }
        //}

        //private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtPassword.Password))
        //        txtPassword.Password = "Password";
        //}
    }
}
