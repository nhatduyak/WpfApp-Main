using System;
using System.Collections.Generic;
using System.Text;
using WpfApp1.View;

namespace WpfApp1.ViewModels
{
    public class MainViewModel: ViewModelsBase
    {
        public MainViewModel()
        {
            LoginView login = new LoginView();
                login.ShowDialog();

        }
    }
}
