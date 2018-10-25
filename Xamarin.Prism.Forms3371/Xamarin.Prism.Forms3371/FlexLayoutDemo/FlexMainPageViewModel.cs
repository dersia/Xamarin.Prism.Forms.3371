using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Prism.Commands;
using Prism.Navigation;

namespace Xamarin.Prism.Forms3371.FlexLayoutDemo
{
    public class FlexMainPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public ICommand NavigationCommand { get; set; }

        public FlexMainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigationCommand = new DelegateCommand<string>(NavigateTo);
        }

        public async void NavigateTo(string page)
        {
            var result = await _navigationService.NavigateAsync(page);
        }
    }
}
