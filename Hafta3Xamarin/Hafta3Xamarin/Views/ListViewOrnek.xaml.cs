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
    public partial class ListViewOrnek : ContentPage
    {
        public class AcikAkademi
        {
            public int ID { get; set; }
            public string ImageUrl { get; set; }
            public string Name { get; set; }

        }

		public ListViewOrnek ()
		{
			InitializeComponent ();

            List<AcikAkademi> akademi = new List<AcikAkademi>
            {
                new AcikAkademi { ID = 1, Name = "MTS", ImageUrl = "AcikAkademi.png" },
                new AcikAkademi { ID = 2, Name = "Soydan", ImageUrl = "AcikAkademi.png" },
                new AcikAkademi { ID = 3, Name = "Bahar", ImageUrl = "AcikAkademi.png" }
            };


            //lstView.ItemsSource = akademi;
            lstView.BindingContext = akademi;

        }

        private void LstView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            AcikAkademi acik = (AcikAkademi)e.SelectedItem;
            DisplayAlert("Dikkat", acik.Name, "OK");
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            DisplayAlert("Butona Tıklandı", btn.CommandParameter.ToString(), "ok");
        }
    }
}