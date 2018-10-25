using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Prism.Commands;
using Prism.Navigation;

namespace Xamarin.Prism.Forms3371.NavigationDemo
{
    public class NavigationDemoStartPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        public NavigationDemoStartPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateToCommand = new DelegateCommand<string>(NavigateTo);
        }

        public ICommand NavigateToCommand { get; set; }

        private async void NavigateTo(string path) => await _navigationService.NavigateAsync(path);
    }
}
