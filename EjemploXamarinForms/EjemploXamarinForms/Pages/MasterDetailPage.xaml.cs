using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EjemploXamarinForms.Pages
{
    public partial class EjemploMasterDetailsPage : MasterDetailPage
    {
        public ListView ListView { get { return listView; } }
        public EjemploMasterDetailsPage()
        {
            
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Contacts",
                IconSource = "icon.png"

            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "TodoList",
                IconSource = "icon.png"

            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Reminders",
                IconSource = "icon.png"

            });

            listView.ItemsSource = masterPageItems;


        }


        public class MasterPageItem
        {

            public String Title { get; set; }
            public String IconSource { get; set; }

        }
    }
}
