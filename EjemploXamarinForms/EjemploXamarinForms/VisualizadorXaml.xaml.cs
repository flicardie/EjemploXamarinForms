using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EjemploXamarinForms
{
    public partial class VisualizadorXaml : ContentPage
    {
        public VisualizadorXaml(string xaml)
        {
            InitializeComponent();
            label.Text = xaml;
        }
    
    }
}
