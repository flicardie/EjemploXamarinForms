using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace EjemploXamarinForms
{
    public partial class EjemploGeneral : ContentPage
    {

        class PruebaViewModel
        {

            public PruebaViewModel(    Action<String> accionAEjecutar1,
                                       Action<String> browseExecute1)
            {
                //this.PageType = pageType;
                //this.PageName = pageType.Name;
                this.IraCommando = new Command<String>(accionAEjecutar1);
                this.BuscarComando = new Command<String>(browseExecute1);
            }

            //public Type PageType { private set; get; }

            //public string PageName { private set; get; }

            public ICommand IraCommando { private set; get; }

            public ICommand BuscarComando { private set; get; }
        }

        public EjemploGeneral()
        {
            //List<HomePageViewModel> models = new List<HomePageViewModel>
            //{
            //    new HomePageViewModel(typeof(Boton), NavigateTo, BrowseSource),
            //    new HomePageViewModel(typeof(ActivityIndicator), NavigateTo, BrowseSource)
            //};

            //listadoComponentes.BindingContext = models;
            PruebaViewModel datos = new PruebaViewModel(NavigateTo, BrowseSource);
            this.BindingContext = datos;
            InitializeComponent();
         
          
            
        }

        async void NavigateTo(String informacionDelTipo)
        {


            //string hola = datos;
            Type pageType = EjemploGeneral.GetTypeByString(informacionDelTipo, this.GetType().GetTypeInfo().Assembly);
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

        async void BrowseSource(string pageName)
        {
            string espacioDeNombres = "EjemploXamarinForms.";
            string xamlPage = espacioDeNombres + pageName + ".xaml";
            Assembly assembly = this.GetType().GetTypeInfo().Assembly;

            using (Stream stream = assembly.GetManifestResourceStream(xamlPage))
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string xaml = reader.ReadToEnd();
                    await this.Navigation.PushAsync(new VisualizadorXaml(xaml));
                }
            }
        }
    }
}
