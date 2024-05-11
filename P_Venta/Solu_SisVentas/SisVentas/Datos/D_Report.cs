using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SisVentas.Datos
{
    internal class D_Report
    {
        public DataTable getVentas(string fInicio, string fFin)
        {
            MySqlDataReader reader;
            MySqlConnection conn = new MySqlConnection();
            DataTable dataTable = new DataTable();
            try
            {
                conn = Conexion.getInstancia().CrearConexion();
                MySqlCommand command = new MySqlCommand("get_Ventas", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("inicio", MySqlDbType.Date).Value = fInicio;
                command.Parameters.Add("fin", MySqlDbType.Date).Value = fFin;
                conn.Open();
                reader = command.ExecuteReader();
                dataTable.Load(reader);
                reader.Close();
                conn.Close();
                return dataTable;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public DataTable getCompras(string fInicio, string fFin)
        {
            MySqlDataReader reader;
            MySqlConnection conn = new MySqlConnection();
            DataTable dataTable = new DataTable();
            try
            {
                conn = Conexion.getInstancia().CrearConexion();
                MySqlCommand command = new MySqlCommand("get_Compras", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("inicio", MySqlDbType.Date).Value = fInicio;
                command.Parameters.Add("fin", MySqlDbType.Date).Value = fFin;
                conn.Open();
                reader = command.ExecuteReader();
                dataTable.Load(reader);
                reader.Close();
                conn.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable detalle_Venta(int id)
        {
            MySqlDataReader reader;
            MySqlConnection conn = new MySqlConnection();
            DataTable dataTable = new DataTable();
            try
            {
                conn = Conexion.getInstancia().CrearConexion();
                MySqlCommand command = new MySqlCommand("detalle_Venta", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("idven", MySqlDbType.Int32).Value = id;
                conn.Open();
                reader = command.ExecuteReader();
                dataTable.Load(reader);
                reader.Close();
                conn.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable detalle_Compra(int id)
        {
            MySqlDataReader reader;
            MySqlConnection conn = new MySqlConnection();
            DataTable dataTable = new DataTable();
            try
            {
                conn = Conexion.getInstancia().CrearConexion();
                MySqlCommand command = new MySqlCommand("detalle_Compra", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("idcom", MySqlDbType.Int32).Value = id;
                conn.Open();
                reader = command.ExecuteReader();
                dataTable.Load(reader);
                reader.Close();
                conn.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable getInventario(int minInv)
        {
            MySqlDataReader reader;
            MySqlConnection conn = new MySqlConnection();
            DataTable dataTable = new DataTable();
            try
            {
                conn = Conexion.getInstancia().CrearConexion();
                MySqlCommand command = new MySqlCommand("get_detalle_Inventario", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("minInv", MySqlDbType.Int32).Value = minInv;
                conn.Open();
                reader = command.ExecuteReader();
                dataTable.Load(reader);
                reader.Close();
                conn.Close();
                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
