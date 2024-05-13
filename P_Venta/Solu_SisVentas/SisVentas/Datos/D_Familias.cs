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
    internal class D_Familias
    {
        // Guardar nueva familia
        public string Guardar_fa(int nOpcion, E_Familias oFa)
        {
            string Rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("ups_guardar_fa", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nOpcion", MySqlDbType.Int32).Value = nOpcion;
                Comando.Parameters.Add("@nCodigo_fa", MySqlDbType.Int32).Direction = ParameterDirection.InputOutput;
                Comando.Parameters.Add("@nombre_fa", MySqlDbType.VarChar).Value = oFa.nombre_fa;
                Comando.Parameters.Add("@descripcion_fa", MySqlDbType.VarChar).Value = oFa.descripcion_fa;
                Comando.Parameters.Add("@nCodigo_ou", MySqlDbType.Int32).Direction = ParameterDirection.Output;

                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Rpta = Convert.ToString(Comando.Parameters["@nCodigo_ou"].Value);
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
        //  Listar las familias
        public DataTable Listado_fa(string cTexto)
        {
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                DataTable Tabla = new DataTable();
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("ups_listado_fa", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", MySqlDbType.VarChar).Value = cTexto;
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
        // Cambiar estado Activo de Familia
        public string Activo_fa(int nCodigo_fa)
        {
            string Rpta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("ups_activo_fa", SqlCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@nCodigo_fa", MySqlDbType.Int32).Value = nCodigo_fa;
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

    }
}
