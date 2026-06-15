using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CNVenta
    {
        public static DataTable DetalleFactura(int idventa)
        {
            return CDVenta.DetalleFactura(idventa);
        }

        public static DataTable ListarVentas(DateTime inicio, DateTime fin)
        {
            return CDVenta.ListarVentas(inicio, fin);
        }

        public static void InsertarVenta(int idcliente, int idusuario, decimal total, DataTable detalle)
        {
            CDVenta.InsertarVenta(idcliente, idusuario, total, detalle);
        }
    }
}
