using EjemploXamarinForms.BE;
using EjemploXamarinForms.BLL;
using EjemploXamarinForms.DAL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EjemploXamarinForms
{
    public partial class EjemploSQLite : ContentPage
    {

        public EmpleadoBLL _empleadoBLL;
        public EmpleadoBE _empleadoBE;

        public EjemploSQLite()
        {
            InitializeComponent();


        }

      

        public async void AgregarEmpleado(object s, EventArgs args)
        {
            var respuesta = await DisplayAlert("Atención", "¿ Esta seguro que desea agregar al empleado ?", "Si", "No");

            if (respuesta.Equals(true))
            {

                _empleadoBE = new EmpleadoBE();
                _empleadoBLL = new EmpleadoBLL();
                _empleadoBE.Nombre = nombre.Text;

                _empleadoBE.Direccion = direccion.Text;
                _empleadoBE.Telefono = telefono.Text;
                int resultado = _empleadoBLL.AgregarEmpleado(_empleadoBE);

                Debug.WriteLine(resultado);

                await DisplayAlert("Resultado", resultado.ToString(), "Cancelar");

            }
            
            

        }

        async void EliminarEmpleado(object sender, EventArgs e)
        {
            var action = await DisplayActionSheet("ActionSheet: SavePhoto?", "Cancel", "Delete", "Photo Roll", "Email");
            Debug.WriteLine("Action: " + action);
        }

        public void MostrarDatos(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new ListaDeEmpleados());
        }

    }
}
