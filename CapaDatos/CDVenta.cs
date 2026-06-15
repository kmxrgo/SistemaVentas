using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CDVenta
    {
        public static DataTable DetalleFactura(int idventa)
        {
            SqlConnection SqlCon = new SqlConnection(Conexion.Conn);
            DataTable DtResultado = new DataTable();

            try
            {
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = @"SELECT 
                               dv.iddetalleventa,
                               p.nombre AS descripcion,
                               dv.precio,
                               dv.cantidad,
                               dv.total,
                               v.fecha,
                               v.num_documento,
                               v.subtotal,
                               v.iva,
                               v.total AS total_venta,
                               c.nombre + ' ' + c.apellidos AS cliente,
                               c.dni AS documento,
                               c.telefono,
                               c.direccion,
                               e.nombre + ' ' + e.apellidos AS vendedor
                            FROM detalleventa dv
                            INNER JOIN producto p ON dv.idproducto = p.idproducto
                            INNER JOIN venta v ON dv.idventa = v.idventa
                            INNER JOIN cliente c ON v.idcliente = c.idcliente
                            INNER JOIN usuario u ON v.idusuario = u.idusuario
                            INNER JOIN empleado e ON u.idempleado = e.idempleado
                            WHERE dv.idventa = @idventa";
                SqlCmd.CommandType = CommandType.Text;

                SqlParameter ParId = new SqlParameter("@idventa", SqlDbType.Int);
                ParId.Value = idventa;
                SqlCmd.Parameters.Add(ParId);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch (Exception)
            {
                DtResultado = null;
            }

            return DtResultado;
        }

        public static DataTable ListarVentas(DateTime inicio, DateTime fin)
        {
            SqlConnection con = new SqlConnection(Conexion.Conn);
            DataTable dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand(@"
            SELECT 
                v.idventa,
                c.nombre + ' ' + c.apellidos AS cliente,
                v.fecha,
                e.nombre + ' ' + e.apellidos AS vendedor,
                v.tipo_documento,
                v.num_documento
            FROM venta v
            INNER JOIN cliente c ON v.idcliente = c.idcliente
            INNER JOIN usuario u ON v.idusuario = u.idusuario
            INNER JOIN empleado e ON u.idempleado = e.idempleado
            WHERE v.fecha BETWEEN @inicio AND @fin", con);

                cmd.Parameters.AddWithValue("@inicio", inicio);
                cmd.Parameters.AddWithValue("@fin", fin);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception)
            {
                dt = null;
            }

            return dt;
        }

        public static void InsertarVenta(int idcliente, int idusuario, decimal total, DataTable detalle)
        {
            SqlConnection con = new SqlConnection(Conexion.Conn);
            con.Open();

            SqlTransaction trans = con.BeginTransaction();

            try
            {
                SqlCommand cmdVenta = new SqlCommand(@"
        INSERT INTO venta(fecha, total, idcliente, idusuario)
        VALUES(GETDATE(), @total, @idcliente, @idusuario);
        SELECT SCOPE_IDENTITY();", con, trans);

                cmdVenta.Parameters.AddWithValue("@total", total);
                cmdVenta.Parameters.AddWithValue("@idcliente", idcliente);
                cmdVenta.Parameters.AddWithValue("@idusuario", idusuario);

                int idventa = Convert.ToInt32(cmdVenta.ExecuteScalar());

                foreach (DataRow row in detalle.Rows)
                {
                    SqlCommand cmdDetalle = new SqlCommand(@"
            INSERT INTO detalleventa(idventa, idproducto, cantidad, precio, total)
            VALUES(@idventa, @idproducto, @cantidad, @precio, @total)", con, trans);

                    cmdDetalle.Parameters.AddWithValue("@idventa", idventa);
                    cmdDetalle.Parameters.AddWithValue("@idproducto", row["IdProducto"]);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", row["Cantidad"]);
                    cmdDetalle.Parameters.AddWithValue("@precio", row["Precio"]);
                    cmdDetalle.Parameters.AddWithValue("@total", row["Total"]);

                    cmdDetalle.ExecuteNonQuery();
                }

                trans.Commit();
            }
            catch
            {
                trans.Rollback();
                throw;
            }
        }
    }
}
