using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_authentication_authorization.State
{
    internal interface INavigator
    {
        object CurrentViewModel { get; set; }
        event Action StateChanged;
    }
}
