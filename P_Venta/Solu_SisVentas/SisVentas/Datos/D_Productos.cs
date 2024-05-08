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
                Comando.Parameters.Add("@nOpcion", MySqlDbType.Int32).Value = nOpcion;
                Comando.Parameters.Add("@nCodigo_pr", MySqlDbType.Int32).Value = oPro.Codigo_pr;
                Comando.Parameters.Add("@nombre_pr", MySqlDbType.VarChar).Value = oPro.Nombre_pr;
                Comando.Parameters.Add("@descripcion_pr", MySqlDbType.VarChar).Value = oPro.Descripcion_pr;
                Comando.Parameters.Add("@pu_costo", MySqlDbType.Decimal).Value = oPro.Pu_costo;
                Comando.Parameters.Add("@pu_venta", MySqlDbType.Decimal).Value = oPro.Pu_venta;
                Comando.Parameters.Add("@pu_descuento", MySqlDbType.Decimal).Value = oPro.Pu_descuento;
                Comando.Parameters.Add("@codigo_us", MySqlDbType.Int32).Value = oPro.Codigo_us;

                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "@nCodigo_pr";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ParCodigo);

                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Rpta = Convert.ToString(ParCodigo.Value);
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
                Comando.Parameters.Add("cTexto", MySqlDbType.VarChar).Value = cTexto;
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
    }
}

