using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_authentication_authorization.ViewModels
{
    internal class ShellViewModel : Conductor<object>
    {
        public ShellViewModel() 
        {
            this.ActiveItem = new object();
        }
    }
}
