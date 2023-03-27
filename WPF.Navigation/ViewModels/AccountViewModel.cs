using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF.Navigation.Commands;
using WPF.Navigation.Services;
using WPF.Navigation.Store;

namespace WPF.Navigation.ViewModels
{
    public class AccountViewModel : ViewModelBase
    {
        //private readonly AccountStore _accountStore;

        //public string Username => _accountStore.CurrentAccount?.Username;
        //public string Email => _accountStore.CurrentAccount?.Email;

        public ICommand NavigateHomeCommand { get; }

        public AccountViewModel(INavigationService homeNavigationService)
        {
            //_accountStore = accountStore;

            NavigateHomeCommand = new NavigateCommand(homeNavigationService);

            //_accountStore.CurrentAccountChanged += OnCurrentAccountChanged;
        }
    }
}

