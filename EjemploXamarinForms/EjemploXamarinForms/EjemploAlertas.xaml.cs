using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EjemploXamarinForms
{
    public partial class EjemploAlertas : ContentPage
    {
        public EjemploAlertas()
        {
            InitializeComponent();
        }

        public async void AlertaNormal(object s, EventArgs args)
        {
            var answer = await DisplayAlert("Ejemplo de Alerta Normal", "Te gusta el ejemplo", "Si", "No");
            
        }

        public async void ActionSheet(object s, EventArgs args)
        {
            var action = await DisplayActionSheet("Ejemplo de Action Sheet", "Cancelar", "Eliminar", "Enviar por Correo");

        }


    }
}
