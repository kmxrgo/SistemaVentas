using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNCategoria
    {
        public static DataTable Listar()
        {
            CDCategoria Datos = new CDCategoria();
            return Datos.Listar();
        }

        //Método Guardar que llama al método Guardar de la clase CDCategoria de la CapaDatos
        public static string Guardar(string descripcion)
        {
            CDCategoria Datos = new CDCategoria();
            Datos.Descripcion = descripcion;
            return Datos.Guardar(Datos);
        }

        //Método Editar que llama al método Editar de la clase CDCategoria de la CapaDatos
        public static string Editar(int idcategoria, string descripcion)
        {
            CDCategoria Datos = new CDCategoria();
            Datos.IdCategoria = idcategoria;
            Datos.Descripcion = descripcion;
            return Datos.Editar(Datos);
        }

        //Método Eliminar que llama al método Eliminar de la clase CDCategoria de la CapaDatos
        public static string Eliminar(int idcategoria)
        {
            CDCategoria Datos = new CDCategoria();
            Datos.IdCategoria = idcategoria;
            return Datos.Eliminar(Datos);
        }

        //Método BuscarNombre que llama al método Buscar de la clase CDCategoria de la CapaDatos
        public static DataTable BuscarNombre(string textobuscar)
        {
            CDCategoria Datos = new CDCategoria();
            Datos.Buscar = textobuscar;
            return Datos.BuscarNombre(Datos);
        }
    }
}
