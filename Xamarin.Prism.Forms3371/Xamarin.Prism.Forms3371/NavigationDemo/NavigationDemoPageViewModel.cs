using System;
using System.Collections.Generic;
using System.Text;
using Prism.Navigation;

namespace Xamarin.Prism.Forms3371.NavigationDemo
{
    public class NavigationDemoPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigation;

        public string NavigationPath { get => _navigation.GetNavigationUriPath(); }

        public NavigationDemoPageViewModel(INavigationService navigation)
        {
            _navigation = navigation;
        }
    }
}
