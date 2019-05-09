using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hafta3Xamarin.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SanalSınıflar : ContentPage
	{
		public SanalSınıflar ()
		{
			InitializeComponent ();
            lstview.BindingContext = Data.MTSFactory.MTSData;
		}
	}
}