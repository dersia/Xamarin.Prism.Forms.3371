using System;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Prism.Forms3371.ContentProvider;
using Xamarin.Prism.Forms3371.CssDemo;
using Xamarin.Prism.Forms3371.CustomTitleBar;
using Xamarin.Prism.Forms3371.EntryEditorLabel;
using Xamarin.Prism.Forms3371.FlexLayoutDemo;
using Xamarin.Prism.Forms3371.NavigationDemo;
using Xamarin.Prism.Forms3371.PartialViewDemo;
using Xamarin.Prism.Forms3371.TabbedAndroid;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Xamarin.Prism.Forms3371
{
    public partial class App:PrismApplication
    {
        public App()
        {
            InitializeComponent();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MainPage>();
            containerRegistry.RegisterForNavigation<SiaNavigationPage, SiaNavigationPageViewModel>();
            containerRegistry.RegisterForNavigation<VSMDemo>();
            containerRegistry.RegisterForNavigation<BasisExperimentPage>();
            containerRegistry.RegisterForNavigation<CatalogItemsPage>();
            containerRegistry.RegisterForNavigation<FlexMainPage, FlexMainPageViewModel>();
            containerRegistry.RegisterForNavigation<CssCatalogItemsPage>();
            containerRegistry.RegisterForNavigation<ExperimentPage>();
            containerRegistry.RegisterForNavigation<TabbedAndroidPage>();
            containerRegistry.RegisterForNavigation<EntryEditorLabelPage>();
            containerRegistry.RegisterForNavigation<CustomTitleBarPage>();
            containerRegistry.RegisterForNavigation<ContentProviderDemoPage, ContentProviderDemoPageViewModel>();
            containerRegistry.RegisterForNavigation<PartialParentA, PartialParentAViewModel>();
            containerRegistry.RegisterForNavigation<PartialParentB, PartialParentBViewModel>();
            containerRegistry.RegisterForNavigation<PartialViewDemoPage>();
            containerRegistry.RegisterForNavigation<NavigationDemoPage, NavigationDemoPageViewModel>();
            containerRegistry.RegisterForNavigation<NavigationDemoPrePage>();
            containerRegistry.RegisterForNavigation<NavigationDemoStartPage, NavigationDemoStartPageViewModel>();

            containerRegistry.Register<IFakeContentProvider, FakeContentProvider>();
            ViewModelLocationProvider.Register<PartialView, PartialViewViewModel>();
        }

        protected override async void OnInitialized()
        {
            var result = await NavigationService.NavigateAsync($"{nameof(SiaNavigationPage)}/{nameof(MainPage)}");
            result.ToString();
        }
    }
}
