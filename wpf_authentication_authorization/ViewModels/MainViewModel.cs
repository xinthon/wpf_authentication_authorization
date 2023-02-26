using Caliburn.Micro;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using wpf_authentication_authorization.Commands;
using wpf_authentication_authorization.Helpers;

namespace wpf_authentication_authorization.ViewModels
{
    internal class MainViewModel : Conductor<object>
    {
        public MainViewModel()
        {
            var loginView = new LoginViewModel();
            loginView.CallBack += (result, message) =>
            {
                if(result == LoginResult.Success)
                {
                    this.ActiveItem = new ShellViewModel();
                }
            };

            this.ActiveItem = loginView;
        }
    }
}
