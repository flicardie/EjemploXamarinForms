using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EjemploXamarinForms.Views
{
    public partial class Switch : ContentPage
    {
        public Switch()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ejemplo de uso para el evento "Toggled" del componente Switch , se activa cuando se cambia algun valor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        async void OnSwitchToggled(object sender, ToggledEventArgs args)
        {
            await DisplayAlert("Información", args.Value.ToString(), "Cancelar");
        }
    }
}
