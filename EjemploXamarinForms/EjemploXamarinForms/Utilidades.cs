using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EjemploXamarinForms
{
    public static class Utilidades
    {
        public static Type GetTypeByString(string type, Assembly lookIn)
        {
            var types = lookIn.DefinedTypes.Where(t => t.Name == type && t.IsSubclassOf(typeof(Xamarin.Forms.ContentPage)));

            if (types.Count() == 0)
            {
                types = null;
                types = lookIn.DefinedTypes.Where(t => t.Name == type && t.IsSubclassOf(typeof(Xamarin.Forms.TabbedPage)));
            }

            if (types.Count() == 0)
            {
                types = null;
                types = lookIn.DefinedTypes.Where(t => t.Name == type && t.IsSubclassOf(typeof(Xamarin.Forms.CarouselPage)));
            }

            if (types.Count() == 0)
            {
                types = null;
                types = lookIn.DefinedTypes.Where(t => t.Name == type && t.IsSubclassOf(typeof(Xamarin.Forms.MasterDetailPage)));
            }


            if (types.Count() == 0)
            {
                throw new ArgumentException("The type you were looking for was not found", "type");
            }
            else if (types.Count() > 1)
            {
                throw new ArgumentException("The type you were looking for was found multiple times.", "type");
            }
            return types.First().AsType();
        }
    }
}
