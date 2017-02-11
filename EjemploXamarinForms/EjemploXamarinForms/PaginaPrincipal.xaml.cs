using EjemploXamarinForms.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EjemploXamarinForms
{
    public partial class PaginaPrincipal : ContentPage
    {
        public PaginaPrincipal()
        {
            ManejoEventosViewModel datos = new ManejoEventosViewModel(NavigateTo);
            this.BindingContext = datos;
            InitializeComponent();
        }

        /// <summary>
        /// Método que ejecutará el view model
        /// </summary>
        /// <param name="informacionDelTipo"></param>
        async void NavigateTo(String informacionDelTipo)
        {


            //string hola = datos;
            Type pageType = Utilidades.GetTypeByString(informacionDelTipo, this.GetType().GetTypeInfo().Assembly);
            //EjemploGeneral.GetTypeByString(informacionDelTipo, this.GetType().GetTypeInfo().Assembly);
            // Get all the constructors of the page type.
            IEnumerable<ConstructorInfo> constructors =
                    pageType.GetTypeInfo().DeclaredConstructors;

            foreach (ConstructorInfo constructor in constructors)
            {
                // Check if the constructor has no parameters.
                if (constructor.GetParameters().Length == 0)
                {
                    // If so, instantiate it, and navigate to it.
                    Page page = (Page)constructor.Invoke(null);
                    await this.Navigation.PushAsync(page);
                    break;
                }
            }
        }

        public static Type GetTypeByString(string type, Assembly lookIn)
        {
            var types = lookIn.DefinedTypes.Where(t => t.Name == type && t.IsSubclassOf(typeof(Xamarin.Forms.ContentPage)));

            if (types.Count() == 0)
            {
                types = null;
                types = lookIn.DefinedTypes.Where(t => t.Name == type && t.IsSubclassOf(typeof(Xamarin.Forms.TabbedPage)));
            }

            if (types.Count() == 0)
            {
                types = null;
                types = lookIn.DefinedTypes.Where(t => t.Name == type && t.IsSubclassOf(typeof(Xamarin.Forms.CarouselPage)));
            }

            if (types.Count() == 0)
            {
                types = null;
                types = lookIn.DefinedTypes.Where(t => t.Name == type && t.IsSubclassOf(typeof(Xamarin.Forms.MasterDetailPage)));
            }


            if (types.Count() == 0)
            {
                throw new ArgumentException("The type you were looking for was not found", "type");
            }
            else if (types.Count() > 1)
            {
                throw new ArgumentException("The type you were looking for was found multiple times.", "type");
            }
            return types.First().AsType();
        }

    }
}
