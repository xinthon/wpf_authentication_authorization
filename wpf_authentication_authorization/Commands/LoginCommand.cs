using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace wpf_authentication_authorization.Commands
{
    internal class LoginCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        private Action<string>? execute { get; set; }
        private Func<string, bool>? canExecute { get; set; }

        public LoginCommand(Action<string>? execute, Func<string, bool>? canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object? parameter)
        {
            if (parameter is PasswordBox)
            {
                var passwordBox = parameter as PasswordBox;
                var password = passwordBox?.Password ?? "";
                return this.canExecute == null || this.canExecute(password);
            }

            return this.canExecute == null || false;
        }

        public void Execute(object? parameter)
        {
            if (parameter is PasswordBox)
            {
                var passwordBox = parameter as PasswordBox;
                var password = passwordBox?.Password ?? "";
                execute?.Invoke(password);
            }
        }
    }
}
