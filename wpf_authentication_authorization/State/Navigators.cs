using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wpf_authentication_authorization.State
{
    public class Navigators : INavigator
    {
        public object CurrentViewModel { get; set; }

        public event Action StateChanged;
    }
}
