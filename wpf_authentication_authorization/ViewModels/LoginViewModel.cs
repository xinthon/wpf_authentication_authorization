using Caliburn.Micro;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using wpf_authentication_authorization.Commands;
using wpf_authentication_authorization.Core.Services.Interfaces;
using wpf_authentication_authorization.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using wpf_authentication_authorization.Helpers;

namespace wpf_authentication_authorization.ViewModels
{
    internal class LoginViewModel : Screen
    {
        private readonly IAuthenticationService authenticationService;
        public Action<LoginResult, string>? CallBack;

        public LoginViewModel()
        {
            this.authenticationService = Core.Program.hostBuilder.Services.GetRequiredService<IAuthenticationService>();
            LoginCommand = new LoginCommand(LogIn, LogInValidation);
        }

        public ICommand? LoginCommand { get; }


        public string username { get; set; } = string.Empty;
        public string Username
        {
            get => username;
            set
            {
                username = value;
                NotifyOfPropertyChange(() => Username);
            }
        }

        public bool rememberMe { get; set; }
        public bool RememberMe
        {
            get => rememberMe;
            set
            {
                rememberMe = value;
                NotifyOfPropertyChange(() => RememberMe);
            }
        }

        private bool LogInValidation(string password)
        {
            return !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && password.Length > 5;
        }

        private void LogIn(string password)
        {
            Task.Run(async () =>
            {
                try
                {
                    var authUser = await authenticationService.LoginAsync(Username, password);
                    if (authUser != null)
                    {
                        Core.Program.Auth = authUser;
                        CallBack?.Invoke(LoginResult.Success, "Login success");
                    }
                }
                catch (Exception ex)
                {
                    CallBack?.Invoke(LoginResult.Failed, ex.Message);
                }
            });
        }
    }
}
