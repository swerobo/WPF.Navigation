using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Navigation.Stores;
using WPF.Navigation.ViewModels;

namespace WPF.Navigation.Commands
{
    public class NavigateCommand : CommandBase
    {
        private readonly NavigationStore _navigationStore;

        public NavigateCommand(NavigationStore navigationStore )
        {
            _navigationStore = navigationStore;
        }

        public override void Execute(object parameter) 
        {
            _navigationStore.CurrentViewModel = new HomeViewModel(_navigationStore);
        }
    }
}
