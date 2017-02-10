using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EjemploXamarinForms
{
    class HomePageViewModel
    {

        public HomePageViewModel(Type pageType,
                                   Action<Type> gotoExecute,
                                   Action<String> browseExecute)
        {
            this.PageType = pageType;
            this.PageName = pageType.Name;
            this.GoToCommand = new Command<Type>(gotoExecute);
            this.BrowseCommand = new Command<String>(browseExecute);
        }

        public Type PageType { private set; get; }

        public string PageName { private set; get; }

        public ICommand GoToCommand { private set; get; }

        public ICommand BrowseCommand { private set; get; }
    }
}
