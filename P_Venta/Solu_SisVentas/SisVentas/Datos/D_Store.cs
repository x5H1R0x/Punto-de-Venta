using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SisVentas.Entidades;

namespace SisVentas.Datos
{
    internal class D_Store
    {
        public E_SaleItem getStoreItem(string codigo)
        {
            MySqlDataReader reader;
            MySqlConnection conn = new MySqlConnection();
            E_SaleItem item;

            try
            {
                conn = Conexion.getInstancia().CrearConexion();
                MySqlCommand command = new MySqlCommand("get_Store_Item", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("codigo_producto", MySqlDbType.VarChar).Value = codigo;
                conn.Open();
                reader = command.ExecuteReader();
                reader.Read();
                    
                item = new E_SaleItem(reader.GetInt32(0), reader.GetString(1), 0.0f, reader.GetFloat(2));

                conn.Close();

                return item;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void storeSale(float total)
        {

        }
        public void storeSaleData(BindingList<E_SaleItem> lista)
        {
            MySqlDataReader reader;
            MySqlConnection conn = new MySqlConnection();

            try
            {
                conn = Conexion.getInstancia().CrearConexion();
                MySqlCommand command = new MySqlCommand("store_Sale_Items", conn);
                command.CommandType = CommandType.StoredProcedure;
                conn.Open();

                foreach (E_SaleItem item in lista)
                {
                    command.Parameters.Clear();
                    command.Parameters.Add("id", MySqlDbType.Int32).Value = item.l_id;
                    command.Parameters.Add("description", MySqlDbType.VarChar).Value = item.l_desc;
                    command.Parameters.Add("cantidad", MySqlDbType.Float).Value = item.l_cantidad;
                    command.Parameters.Add("precio", MySqlDbType.Float).Value = item.l_precio;
                    reader = command.ExecuteReader();
                }

                conn.Close();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
