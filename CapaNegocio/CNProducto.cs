using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNProducto
    {
        public static DataTable BuscarCodigo(string textobuscar)
        {
            CDProducto Datos = new CDProducto();
            return Datos.BuscarCodigo(textobuscar);
        }
    }
}