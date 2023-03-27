using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF.Navigation.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using WPF.Navigation.Store;
using WPF.Navigation.Commands;
using WPF.Navigation.Services;

namespace WPF.Navigation
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly AccountStore _accountStore;
        private readonly NavigationStore _navigationStore;

        public App()
        {
            _accountStore = new AccountStore(); 
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            INavigationService homeNavigationService = CreateHomeNavigationService();
            homeNavigationService.Navigate();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }

        private INavigationService CreateHomeNavigationService()
        {
            return new HomeViewModel());
        }
    }
}
 