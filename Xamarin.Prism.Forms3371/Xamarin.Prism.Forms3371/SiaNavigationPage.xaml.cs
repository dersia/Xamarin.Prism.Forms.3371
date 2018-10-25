using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Navigation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Prism.Forms3371
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SiaNavigationPage : NavigationPage, INavigationPageOptions, IDestructible
    {
		public SiaNavigationPage ()
		{
			InitializeComponent ();
		}

        public bool ClearNavigationStackOnNavigation => true;

        public void Destroy() { }
    }
}