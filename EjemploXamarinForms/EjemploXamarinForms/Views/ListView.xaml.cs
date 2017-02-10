using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EjemploXamarinForms.Views
{
    public partial class ListView : ContentPage
    {
        public ListView listado { get { return listado; } }
        public ListView()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Titulo 1",
                IconSource = "icon.png"

            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Titulo 2",
                IconSource = "icon.png"

            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Titulo 3",
                IconSource = "icon.png"

            });

            listView.ItemsSource = masterPageItems;
        }


        public class MasterPageItem
        {

            public String Title { get; set; }
            public String IconSource { get; set; }

        }

        public class Cheese
        {
            public string CheeseName { get; set; }
            public string Dairy { get; set; }

            public int Id { get; set; }

            static List<Cheese> _allCheeses;
            public static List<Cheese> All
            {
                get
                {
                    if (_allCheeses == null)
                    {
                        _allCheeses = new List<Cheese>
                {
                    new Cheese { CheeseName="Little Boy Blue", Dairy="Hooks", Id=1 },
                    new Cheese { CheeseName="10 year", Dairy="Hooks",Id=2 },
                    new Cheese { CheeseName="Yellow Curds", Dairy="Murphs" },
                    new Cheese { CheeseName="St Jenifer", Dairy="Creme de la Coule" }
                };
                    }

                    return _allCheeses;
                }
            }
        }
    }
}
