using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EjemploXamarinForms.Views
{
    public partial class DatePicker : ContentPage
    {
        public DatePicker()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ejemplo de uso para el evento "OnDateSelected" del componente datePicker , se activa cuando se cambia de fecha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        async void datePickerOnDateSelected(object sender, DateChangedEventArgs args)
        {

            await DisplayAlert("Información", dtPicker.Date.ToString(), "Cancelar");


        }
    }
}
