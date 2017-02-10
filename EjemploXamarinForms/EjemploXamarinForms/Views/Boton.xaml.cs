using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EjemploXamarinForms.Views
{
    public partial class Boton : ContentPage
    {
        public Boton()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ejemplo de uso para el evento "Clicked" del boton , se activa cuando se presiona un botón
        /// </summary>
        /// <param name="s"></param>
        /// <param name="args"></param>
        async void buttonOnClick(object s, EventArgs args)
        {
            await DisplayAlert("Información", "Haz hecho click", "Cancelar");
        }
    }


}
