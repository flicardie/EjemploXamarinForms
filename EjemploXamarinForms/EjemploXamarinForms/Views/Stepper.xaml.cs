using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EjemploXamarinForms.Views
{
    public partial class Stepper : ContentPage
    {
        public Stepper()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ejemplo de uso para el evento "ValueChanged" del componente stepper , se activa cuando se cambia algun valor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void OnStepperValueChanged(object sender, ValueChangedEventArgs args)
        {

            await DisplayAlert("Información", stepper.Value.ToString(), "Cancelar");
        }
    }
}
