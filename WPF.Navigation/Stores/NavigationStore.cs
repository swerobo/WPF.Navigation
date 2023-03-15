using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Navigation.ViewModels;

namespace WPF.Navigation.Stores
{
    public class NavigationStore
    {
        public ViewModelBase CurrentViewModel { get; set; }
    }
}
