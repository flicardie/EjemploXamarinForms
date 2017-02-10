using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EjemploXamarinForms.Views
{
    public partial class SearchBar : ContentPage
    {
        public SearchBar()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ejemplo de uso para el evento "searchTextChanged" del componente search , se activa cuando se cambia el texto ingresado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void searchTextChanged(object sender, TextChangedEventArgs e)
        {

            await DisplayAlert("Información", "Evento Search Text Changed", "Cancelar");
        }

        /// <summary>
        /// Ejemplo de uso para el evento "searchButtonPressed" del componente search , se activa cuando se presiona el botón buscar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void searchButtonPressed(object sender, EventArgs e)
        {

            await DisplayAlert("Información", "Evento Search Button Pressed", "Cancelar");
        }
    }
}
