using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EjemploXamarinForms
{
    public partial class EjemploViews : ContentPage
    {
        public ListView ListView { get { return listView; } }

        Dictionary<string, Color> nameToColor = new Dictionary<string, Color>
        {
            { "Aqua", Color.Aqua }, { "Black", Color.Black },
            { "Blue", Color.Blue }, { "Fucshia", Color.Gray },
            { "Gray", Color.Gray }, { "Green", Color.Green },
            { "Lime", Color.Lime }, { "Maroon", Color.Maroon },
            { "Navy", Color.Navy }, { "Olive", Color.Olive },
            { "Purple", Color.Purple }, { "Red", Color.Red },
            { "Silver", Color.Silver }, { "Teal", Color.Teal },
            { "White", Color.White }, { "Yellow", Color.Yellow }

            
        };

        public EjemploViews()
        {
            InitializeComponent();

           

            //foreach (string colorName in nameToColor.Keys)
            //{
            //    PickerEjemplo.Items.Add(colorName);
            //}

            var masterPageItems = new List<MasterPageItem>();
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Titulo 1",
                IconSource = "icon.png"

            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Titulo 2",
                IconSource = "icon.png"

            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "Titulo 3",
                IconSource = "icon.png"

            });

            listView.ItemsSource = masterPageItems;
            
        }




        /// <summary>
        /// Ejemplo de uso para el evento "Clicked" del boton , se activa cuando se presiona un botón
        /// </summary>
        /// <param name="s"></param>
        /// <param name="args"></param>
        async void buttonOnClick(object s, EventArgs args)
        {
            await DisplayAlert("Información","Haz hecho click","Cancelar");
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

        /// <summary>
        /// Ejemplo de uso para el evento del Entry "OnCompletedEntry", se activa cuando el usuario presionar la tecla Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void entryOnCompleted(object sender, EventArgs e)
        {
            await DisplayAlert("Información", "Evento Entry On Completed", "Cancelar");

           
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

        /// <summary>
        /// Ejemplo de uso para el evento "ValueChanged" del componente slider , se activa cuando se cambia algun valor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        async void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            await DisplayAlert("Información", "Evento on Value Changed", "Cancelar");
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

        /// <summary>
        /// Ejemplo de uso para el evento "Toggled" del componente Switch , se activa cuando se cambia algun valor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        async void OnSwitchToggled(object sender, ToggledEventArgs args)
        {
            await DisplayAlert("Información", args.Value.ToString(), "Cancelar");
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

        public class MasterPageItem
        {

            public String Title { get; set; }
            public String IconSource { get; set; }

        }

        public class Cheese
        {
            public string CheeseName { get; set; }
            public string Dairy { get; set; }
           
            public int Id { get; set; }

            static List<Cheese> _allCheeses;
            public static List<Cheese> All
            {
                get
                {
                    if (_allCheeses == null)
                    {
                        _allCheeses = new List<Cheese>
                {
                    new Cheese { CheeseName="Little Boy Blue", Dairy="Hooks", Id=1 },
                    new Cheese { CheeseName="10 year", Dairy="Hooks",Id=2 },
                    new Cheese { CheeseName="Yellow Curds", Dairy="Murphs" },
                    new Cheese { CheeseName="St Jenifer", Dairy="Creme de la Coule" }
                };
                    }

                    return _allCheeses;
                }
            }
        }
    }
}
