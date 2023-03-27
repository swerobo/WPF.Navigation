using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.Navigation.Commands;
using WPF.Navigation.Services;

namespace WPF.Navigation.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public string WelcomeMessage => "Welcome to my application.";

        public ICommand NavigateLoginCommand { get; }

        public HomeViewModel(INavigationService loginNavigationService)
        {
            NavigateLoginCommand = new NavigateCommand(loginNavigationService);
        }
    }
}
