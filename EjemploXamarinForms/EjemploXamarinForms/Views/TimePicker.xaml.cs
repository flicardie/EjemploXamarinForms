using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EjemploXamarinForms.Views
{
    public partial class TimePicker : ContentPage
    {
        public TimePicker()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ejemplo de uso para el evento "PropertyChanged" del componente TimePicker , se activa cuando se cambia algun valor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        async void OnTimePickerPropertyChanged(object obj, PropertyChangedEventArgs args)
        {
            ;
            //await DisplayAlert("Información", args.PropertyName.ToString(), "Cancelar");

        }
    }
}
