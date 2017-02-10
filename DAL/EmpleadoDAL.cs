using System.Collections.Generic;
using System.Linq;
using SQLite.Net;
using Xamarin.Forms;

using EjemploXamarinForms.BE;

namespace EjemploXamarinForms.DAL
{
    public class EmpleadoDAL
    {
        private SQLiteConnection _sqlconnection;

        public EmpleadoDAL()
        {
            //Getting conection and Creating table
            _sqlconnection = DependencyService.Get<ISQLite>().GetConnection();
            _sqlconnection.CreateTable<EmpleadoBE>();
        }

        //Get all EmpleadoDALs
        public IEnumerable<EmpleadoBE> ListarEmpleadoDAL()
        {
            return (from t in _sqlconnection.Table<EmpleadoBE>() select t).ToList();
        }

        //Get specific EmpleadoDAL
        public EmpleadoBE ListarEmpleadoDAL(int id)
        {
            return _sqlconnection.Table<EmpleadoBE>().FirstOrDefault(t => t.Id == id);
        }

        //Delete specific EmpleadoDAL
        public int EliminarEmpleadoDAL(int id)
        {
            return _sqlconnection.Delete<EmpleadoBE>(id);
        }

        //Add new EmpleadoDAL to DB
        public int AgregarEmpleado(EmpleadoBE entidad)
        {
            return _sqlconnection.Insert(entidad);
        }
    }
}
