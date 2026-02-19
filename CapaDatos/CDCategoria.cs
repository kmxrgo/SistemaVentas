using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDCategoria
    {
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public string Buscar { get; set; }

        public DataTable Listar()
        {
            DataTable resul = new DataTable("categoria");
            SqlConnection conexion = new SqlConnection();

            try
            {
                // Configurar la conexión
                conexion.ConnectionString = Conexion.Conn;

                // Configurar el comando para ejecutar el stored procedure
                SqlCommand Cmd = new SqlCommand("SPListar_Categoria", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Usar SqlDataAdapter para llenar el DataTable con los resultados del SP
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(resul);  // Ejecuta el SP y llena el DataTable
            }
            catch (Exception ex)
            {
                resul = null;
                throw ex;
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return resul;
        }

        public string Guardar(CDCategoria  cat)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                // Abrir conexión a la base de datos
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                // Configurar el comando para ejecutar el stored procedure
                SqlCommand Cmd = new SqlCommand("SPGuardar_Categoria", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros del stored procedure
                Cmd.Parameters.AddWithValue("@idcategoria", SqlDbType.Int).Direction = ParameterDirection.Output;  // Parámetro de salida
                Cmd.Parameters.AddWithValue("@descripcion", cat.Descripcion);

                // Ejecutar el stored procedure
                // ExecuteNonQuery() retorna el número de filas afectadas
                resul = Cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo insertar el registro";
            }
            catch (Exception ex)
            {
                resul = ex.Message;
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resul;
        }

        public string Editar(CDCategoria cat)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                // Abrir conexión a la base de datos
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                // Configurar el comando para ejecutar el stored procedure
                SqlCommand Cmd = new SqlCommand("SPEditar_Categoria", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetros del stored procedure
                Cmd.Parameters.AddWithValue("@idctegoria", cat.IdCategoria);  // ID del cliente a actualizar
                Cmd.Parameters.AddWithValue("@descripcion", cat.Descripcion);

                // Ejecutar el stored procedure
                // ExecuteNonQuery() retorna el número de filas afectadas (debe ser 1)
                resul = Cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo actualizar el registro";
            }
            catch (Exception ex)
            {
                resul = ex.Message;
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resul;
        }

        public string Eliminar(CDCategoria cat)
        {
            string resul = "";
            SqlConnection conexion = new SqlConnection();
            try
            {
                // Abrir conexión a la base de datos
                conexion.ConnectionString = Conexion.Conn;
                conexion.Open();

                // Configurar el comando para ejecutar el stored procedure
                SqlCommand Cmd = new SqlCommand("SPEliminar_Categoria", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetro del stored procedure (solo necesita el ID)
                Cmd.Parameters.AddWithValue("@idcategoria", cat.IdCategoria);

                // Ejecutar el stored procedure
                // ExecuteNonQuery() retorna el número de filas afectadas (debe ser 1)
                resul = Cmd.ExecuteNonQuery() == 1 ? "OK" : "No se pudo eliminar el registro";
            }
            catch (Exception ex)
            {
                resul = ex.Message;
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resul;
        }

        public DataTable BuscarNombre(CDCategoria cat)
        {
            DataTable resul = new DataTable("categoria");
            SqlConnection conexion = new SqlConnection();
            try
            {
                // Configurar la conexión
                conexion.ConnectionString = Conexion.Conn;

                // Configurar el comando para ejecutar el stored procedure
                SqlCommand Cmd = new SqlCommand("SPBuscar_Categoria", conexion);
                Cmd.CommandType = CommandType.StoredProcedure;

                // Agregar parámetro de búsqueda
                Cmd.Parameters.AddWithValue("@Desc", cat.Buscar);

                // Usar SqlDataAdapter para llenar el DataTable con los resultados del SP
                SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                SqlDat.Fill(resul);  // Ejecuta el SP y llena el DataTable con los resultados filtrados
            }
            catch (Exception ex)
            {
                resul = null;
                throw ex;
            }
            finally
            {
                // Cerrar la conexión si está abierta
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return resul;
        }

    }
}
