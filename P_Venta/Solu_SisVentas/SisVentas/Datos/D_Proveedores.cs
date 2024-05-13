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
    internal class D_Proveedores
    {
        public string Guardar_prov(int nOpcion, E_Proveedores oPro)
        {
            string Rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("ups_guardar_prov", SqlCon); // Suponiendo que el procedimiento almacenado se llama ups_guardar_prov
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nOpcion", MySqlDbType.Int32).Value = nOpcion;
                Comando.Parameters.Add("nCodigo_prov", MySqlDbType.Int32).Value = oPro.codigo_po;
                Comando.Parameters.Add("cNombre_prov", MySqlDbType.VarChar).Value = oPro.nombre_po;
                Comando.Parameters.Add("cDireccion_prov", MySqlDbType.VarChar).Value = oPro.direccion_po;
                Comando.Parameters.Add("cTelefono_prov", MySqlDbType.VarChar).Value = oPro.telefono_po;
                Comando.Parameters.Add("nCodigo_us", MySqlDbType.Int32).Value = oPro.codigo_us;

                MySqlParameter parametroSalida = new MySqlParameter();
                parametroSalida.ParameterName = "nCodigo_ou_pr";
                parametroSalida.MySqlDbType = MySqlDbType.Int32;
                parametroSalida.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(parametroSalida);

                SqlCon.Open();
                Comando.ExecuteNonQuery();

                // Obtener el valor del parámetro de salida después de ejecutar el procedimiento almacenado
                int codigoProveedorSalida = Convert.ToInt32(parametroSalida.Value);

                Rpta = "OK";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
                // Registrar el error para depuración
                Console.WriteLine("Error en Guardar_prov: " + ex.Message);
                Console.WriteLine("StackTrace: " + ex.StackTrace);
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Rpta;
        }

        // Listar los proveedores
        public DataTable Listado_prov(string cTexto)
        {
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                DataTable Tabla = new DataTable();
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("ups_listado_prov", SqlCon);
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
        // Activo de proveedores
        public string Activo_prov(int nCodigo_prov)
        {
            string Rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("ups_activo_prov", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nCodigo_prov", MySqlDbType.Int32).Value = nCodigo_prov;
                SqlCon.Open();

                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se pudo realizar la modificación";

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

    }
}
