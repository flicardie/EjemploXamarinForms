using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EjemploXamarinForms.Views
{
    public partial class Slider : ContentPage
    {
        public Slider()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ejemplo de uso para el evento "ValueChanged" del componente slider , se activa cuando se cambia algun valor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            await DisplayAlert("Información", "Evento on Value Changed", "Cancelar");
        }
    }
}
