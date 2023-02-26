using Caliburn.Micro;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace wpf_authentication_authorization.ViewModels
{
    internal class MainViewModel : Conductor<object>
    {
        public MainViewModel()
        {
            this.ActiveItem = new LoginViewModel();
        }
    }
}
