using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using WPF.Navigation.Models;

namespace WPF.Navigation.Store
{
    public class AccountStore
    {
        private Account _currentAccount;
        public Account CurrentAccount
        {
            get => _currentAccount;
            set
            {
                _currentAccount = value;
                CurrentAccountChanged?.Invoke();
            }
        }

        public bool IsLoggedIn => CurrentAccount != null;

        public event Action CurrentAccountChanged;

        public void Logout()
        {
            CurrentAccount = null;
        }
    }
}
