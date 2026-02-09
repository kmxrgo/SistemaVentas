using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;
using System.Security.Cryptography.X509Certificates;

namespace CapaNegocio
{
    public class CNCliente
    {
        //Método Listar que llama al método Listar de la clase CDCliente de la CapaDatos
        public static DataTable Listar()
        {
            CDCliente Datos = new CDCliente();
            return Datos.Listar();
        }

        // Método Guardar que llama al método Guardar de la clase CDCliente de la CapaDatos
        public static string Guardar(string nombre, string apellidos, string rfc, string dni, string telefono, string estado)
        {
            CDCliente Datos = new CDCliente();
            Datos.Nombre = nombre;
            Datos.Apellidos = apellidos;
            Datos.Dni = dni;
            Datos.Rfc = rfc;
            Datos.Telefono = telefono;
            Datos.Estado = estado;
            return Datos.Guardar(Datos);
        }

        // Método Editar que llama al método Editar de la clase CDCliente de la CapaDatos
        public static string Editar(int idcliente, string nombre, string apellidos, string rfc, string dni, string telefono, string estado)
        {
            CDCliente Datos = new CDCliente();
            Datos.Idcliente = idcliente;
            Datos.Nombre = nombre;
            Datos.Apellidos = apellidos;
            Datos.Dni = dni;
            Datos.Rfc = rfc;
            Datos.Telefono = telefono;
            Datos.Estado = estado;
            return Datos.Editar(Datos);
        }

        // Método Eliminar que llama al método Eliminar de la clase CDCliente de la CapaDatos
        public static string Eliminar(int idcliente)
        {
            CDCliente Datos = new CDCliente(); 
            Datos.Idcliente = idcliente;
            return Datos.Eliminar(Datos);
        }

        // Método BuscarNombre que llama al método Buscar de la clase CDCliente de la CapaDatos
        public static DataTable BuscarNombre(string textobuscar)
        {
            CDCliente Datos = new CDCliente();
            Datos.Buscar = textobuscar;
            return Datos.BuscarNombre(Datos);
        }

        // Método BuscarDni que llama al método BuscarDni de la clase CDCliente de la CapaDatos
        public static DataTable BuscarDni(string textobuscar)
        {
            CDCliente Datos = new CDCliente();
            Datos.Buscar = textobuscar;
            return Datos.BuscarDni(Datos);
        }

    }
}
