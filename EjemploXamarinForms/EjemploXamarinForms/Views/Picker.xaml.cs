using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EjemploXamarinForms.Views
{
    public partial class PickerEjemplo : ContentPage
    {
        public PickerEjemplo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Ejemplo de uso para el evento "OnPickerSelectedIndexChanged" del componente Picker , se activa cuando se selecciona una opción
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            Picker picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            if (selectedIndex == -1)
                return;
            string selectedItem = picker.Items[selectedIndex];

            await DisplayAlert("Información", "Item Seleccionado : " + selectedItem, "Cancelar");

            //<SearchBar x:Name="search" Placeholder="Buscar" TextChanged="searchTextChanged" SearchButtonPressed="searchButtonPressed" />


        }
    }
}
