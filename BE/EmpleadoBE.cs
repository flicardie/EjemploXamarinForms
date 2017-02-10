using System;
using SQLite.Net.Attributes;

namespace EjemploXamarinForms.BE
{
    /// <summary>
    /// Ejemplo de clase
    /// </summary>
    public class EmpleadoBE
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public EmpleadoBE()
        {
        }
    }
}
