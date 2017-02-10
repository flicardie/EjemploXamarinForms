using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EjemploXamarinForms.Views
{
    public partial class Entry : ContentPage
    {
        public Entry()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ejemplo de uso para el evento del Entry "OnCompletedEntry", se activa cuando el usuario presionar la tecla Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void entryOnCompleted(object sender, EventArgs e)
        {
            await DisplayAlert("Información", "Evento Entry On Completed", "Cancelar");


        }
    }
}
