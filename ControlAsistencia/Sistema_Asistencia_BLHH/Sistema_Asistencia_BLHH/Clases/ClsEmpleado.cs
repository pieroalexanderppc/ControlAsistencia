using Sistema_Asistencia_BLHH.DataClase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Asistencia_BLHH.Clases
{
    public class ClsEmpleado
    {
        DCTablasDataContext dc = new DCTablasDataContext();

        // Implementar los Métodos del CRUD
        // Método Listar
        public List<Empleado> ListarEmpleados()
        {
            List<Empleado> ListaEmpleados = dc.Empleado.ToList();
            return ListaEmpleados;
        }

        // Método Obtener
        public Empleado ObtenerEmpleado(int id)
        {
            Empleado objEmpleado = dc.Empleado.SingleOrDefault(e => e.IdEmpleado == id);
            return objEmpleado;
        }

        // Método Insertar
        public void InsertarEmpleado(Empleado objEmpleado)
        {
            dc.Empleado.InsertOnSubmit(objEmpleado);
            dc.SubmitChanges();
        }

        // Método Modificar
        public void ModificarEmpleado(Empleado objEmpleado)
        {
            Empleado objEmp = dc.Empleado.SingleOrDefault(e => e.IdEmpleado == objEmpleado.IdEmpleado);

            if (objEmp != null)
            {
                objEmp.Nombre = objEmpleado.Nombre;
                objEmp.Apellido = objEmpleado.Apellido;
                objEmp.DNI = objEmpleado.DNI;
                objEmp.Telefono = objEmpleado.Telefono;
                // Agregar aquí las demás propiedades del empleado que desees modificar
                dc.SubmitChanges();
            }
        }

        // Método Eliminar
        public void EliminarEmpleado(int id)
        {
            Empleado objEmpleado = dc.Empleado.SingleOrDefault(e => e.IdEmpleado == id);
            if (objEmpleado != null)
            {
                dc.Empleado.DeleteOnSubmit(objEmpleado);
                dc.SubmitChanges();
            }
        }

        // Método para obtener la lista de áreas
        public List<Area> ObtenerListaDeAreas()
        {
            List<Area> listaAreas = dc.Area.ToList();
            return listaAreas;
        }


        public List<Puesto> ObtenerListaDePuestos()
        {
            List<Puesto> listaPuestos = dc.Puesto.ToList();
            return listaPuestos;
        }

        public List<Asistencia> ListarDia()
        {
            List<Asistencia> listaAsistencia = dc.Asistencia.ToList();
            return listaAsistencia;
        }
    }
}
