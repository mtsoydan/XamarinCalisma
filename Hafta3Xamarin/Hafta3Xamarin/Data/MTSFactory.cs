using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Hafta3Xamarin.Data
{
    public class MTSFactory
    {
        public class MTS
        {
            public string Title { get; set; }
            public string ImageURL { get; set; }
            public string Description { get; set; }
            public DateTime PublisDate { get; set; }


        }

        public static IList<MTS> MTSData { get; set; }

        static MTSFactory()
        {
            MTSData = new ObservableCollection<MTS>()
                    {
                        new MTS
                        {
                            Description = "mustafaa taha syodannnn",
                            ImageURL = "indir.jpg",
                            PublisDate = DateTime.Now,
                            Title="başlık1"
                        },
                        new MTS
                        {
                            Description = "deneme12333",
                            ImageURL = "AcikAkademi.png",
                            PublisDate = DateTime.Now,
                            Title="başlık2"
                        }
                    };

        }

    }
}
