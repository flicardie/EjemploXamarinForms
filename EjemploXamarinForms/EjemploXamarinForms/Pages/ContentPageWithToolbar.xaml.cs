using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EjemploXamarinForms.Pages
{
    public partial class ContentPageWithToolbar : ContentPage
    {
        public ContentPageWithToolbar()
        {
            InitializeComponent();
        }

        void OnAddItemClicked(object sender, EventArgs e)
        {
            //var todoItem = new TodoItem()
            //{
            //    ID = Guid.NewGuid().ToString()
            //};
            //var todoPage = new TodoItemPage(true);
            //todoPage.BindingContext = todoItem;
            //Navigation.PushAsync(todoPage);
        }
    }
}
