using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.Navigation.Commands;
using WPF.Navigation.Stores;

namespace WPF.Navigation.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public ICommand NavigateCommand { get;}

        public HomeViewModel(NavigationStore navigationStore)
        {
            NavigateCommand = new NavigateCommand(navigationStore);
        }

    }
}
