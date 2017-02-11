using EjemploXamarinForms.ViewModel;
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
    public partial class ContenedorPages : ContentPage
    {

      

        public ContenedorPages()
        {
           
            ManejoEventosViewModel datos = new ManejoEventosViewModel(NavigateTo);
            this.BindingContext = datos;
            InitializeComponent();
         
          
            
        }

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
