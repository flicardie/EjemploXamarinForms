
using System.Collections.Generic;
using EjemploXamarinForms.DAL;
using EjemploXamarinForms.BE;

namespace EjemploXamarinForms.BLL
{
    public class EmpleadoBLL
    {
        public IEnumerable<EmpleadoBE> ListarEmpleadoDAL()
        {
            EmpleadoDAL _dal = new EmpleadoDAL();
            return _dal.ListarEmpleadoDAL();
        }

        //Get specific EmpleadoDAL
        public EmpleadoBE ListarEmpleadoDAL(int id)
        {
            EmpleadoDAL _dal = new EmpleadoDAL();
            return _dal.ListarEmpleadoDAL(id);
        }

        //Delete specific EmpleadoDAL
        public int  EliminarEmpleadoDAL(int id)
        {
            EmpleadoDAL _dal = new EmpleadoDAL();
            return _dal.EliminarEmpleadoDAL(id);
        }

        //Add new EmpleadoDAL to DB
        public int AgregarEmpleado(EmpleadoBE entidad)
        {
            EmpleadoDAL _dal = new EmpleadoDAL();
            return _dal.AgregarEmpleado(entidad);
        }
    }
}
