using EjemploXamarinForms.BLL;
using EjemploXamarinForms.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EjemploXamarinForms
{
    public partial class ListaDeEmpleados : ContentPage
    {
        public EmpleadoBLL _empleadoBLL;
        public ListaDeEmpleados()
        {
            InitializeComponent();

            _empleadoBLL = new EmpleadoBLL();
            var empleados = _empleadoBLL.ListarEmpleadoDAL();
            EmpleadosListView.ItemsSource = empleados;
        }
    }
}
