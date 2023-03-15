using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF.Navigation.ViewModels
{
    public class HelpViewModel : ViewModelBase
    {
        public string Name => "Robban";

        public ICommand NavigateCommand { get;}
    }
}
