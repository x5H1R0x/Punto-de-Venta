using MySql.Data.MySqlClient;
using SisVentas.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVentas.Datos
{
    internal class D_Productos
    {
        // Guardar un nuevo producto
        public string Guardar_pr(int nOpcion, E_Productos oPro)
        {
            string Rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("ups_guardar_pr", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nOpcion_pr", MySqlDbType.Int32).Value = nOpcion;
                Comando.Parameters.Add("nCodigo_pr", MySqlDbType.Int32).Value = oPro.codigo_pr;
                Comando.Parameters.Add("cNombre_pr_producto", MySqlDbType.VarChar).Value = oPro.nombre_pr;
                Comando.Parameters.Add("cDescripcion_pr_producto", MySqlDbType.VarChar).Value = oPro.descripcion_pr;
                Comando.Parameters.Add("nCodigo_manu_producto", MySqlDbType.VarChar).Value = oPro.codigo_manu;
                Comando.Parameters.Add("nPu_costo_producto", MySqlDbType.Decimal).Value = oPro.pu_costo;
                Comando.Parameters.Add("nPu_venta_producto", MySqlDbType.Decimal).Value = oPro.pu_venta;
                Comando.Parameters.Add("nCodigo_prov_producto", MySqlDbType.Int32).Value = oPro.codigo_prov;
                Comando.Parameters.Add("nCodigo_us_producto", MySqlDbType.Int32).Value = oPro.codigo_us;
                Comando.Parameters.Add("nCodigo_fa_producto", MySqlDbType.Int32).Value = oPro.codigo_fa;

                MySqlParameter parametroSalida = new MySqlParameter();
                parametroSalida.ParameterName = "nCodigo_ou_pr";
                parametroSalida.MySqlDbType = MySqlDbType.Int32;
                parametroSalida.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(parametroSalida);

                SqlCon.Open();
                Comando.ExecuteNonQuery();

                // Obtener el valor del parámetro de salida después de ejecutar el procedimiento almacenado
                int codigoProductoSalida = Convert.ToInt32(parametroSalida.Value);

                Rpta = "OK";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
                // Registrar el error para depuración
                Console.WriteLine("Error en Guardar_pr: " + ex.Message);
                Console.WriteLine("StackTrace: " + ex.StackTrace);
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        // Listar los producto
        public DataTable Listado_pr(string cTexto)
        {
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                DataTable Tabla = new DataTable();
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("ups_listado_pr", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.AddWithValue("@cTexto", cTexto); // Usando AddWithValue para simplificar
                SqlCon.Open();
                using (MySqlDataReader Resultado = Comando.ExecuteReader())
                {
                    Tabla.Load(Resultado);
                }
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }


        // Listado de Familias Productos
        public DataTable Listado_fa()
        {
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                DataTable Tabla = new DataTable();
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("ups_listado_fa", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                using (MySqlDataReader Resultado = Comando.ExecuteReader())
                {
                    Tabla.Load(Resultado);
                }
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }

        // Cambiar estado Activo de Productos
        public string Activo_pr(int nCodigo_pr)
        {
            string Rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("ups_activo_pr", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nCodigo_pr", MySqlDbType.Int32).Value = nCodigo_pr;
                SqlCon.Open();

                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo realizar la modificación...";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        // Listado de Proveedores
        public DataTable Listado_prov()
        {
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                DataTable Tabla = new DataTable();
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("ups_listado_prov", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                SqlCon.Open();
                using (MySqlDataReader Resultado = Comando.ExecuteReader())
                {
                    Tabla.Load(Resultado);
                }
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
        }
    }
}

