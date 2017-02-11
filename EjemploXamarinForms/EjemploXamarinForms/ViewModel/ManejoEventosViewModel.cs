using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EjemploXamarinForms.ViewModel
{
    class ManejoEventosViewModel
    {
        public ManejoEventosViewModel(Action<String> accionAEjecutar1)
        {
            //this.PageType = pageType;
            //this.PageName = pageType.Name;
            this.IraCommando = new Command<String>(accionAEjecutar1);
            
        }

        //public Type PageType { private set; get; }

        //public string PageName { private set; get; }

        public ICommand IraCommando { private set; get; }

        public ICommand BuscarComando { private set; get; }
    }
}
