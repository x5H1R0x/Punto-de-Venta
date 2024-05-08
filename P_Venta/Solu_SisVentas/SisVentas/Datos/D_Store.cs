using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

                if (!reader.Read())
                {
                    item = new E_SaleItem(0, "", "", 0, 0f);
                }
                else
                {
                    item = new E_SaleItem(reader.GetInt32(0), codigo, reader.GetString(1), 1, reader.GetFloat(2));
                }

                conn.Close();

                return item;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void storeSaleData(BindingList<E_SaleItem> lista, float totalVenta)
        {
            MySqlDataReader reader;
            MySqlConnection conn = new MySqlConnection();
            int idVenta;

            try
            {
                conn = Conexion.getInstancia().CrearConexion();
                MySqlCommand command = new MySqlCommand("store_Sale_Items", conn);
                MySqlCommand saleComm = new MySqlCommand("new_Sale", conn);
                command.CommandType = CommandType.StoredProcedure;
                saleComm.CommandType = CommandType.StoredProcedure;
                conn.Open();

                saleComm.Parameters.Add("f", MySqlDbType.Date).Value = DateTime.Today.Date.ToString("yyyy-MM-dd");
                saleComm.Parameters.Add("total", MySqlDbType.Float).Value = totalVenta;
                reader = saleComm.ExecuteReader();
                reader.Read();
                idVenta = reader.GetInt32(0);
                reader.Close();

                MessageBox.Show(idVenta.ToString());

                foreach (E_SaleItem item in lista)
                {
                    command.Parameters.Clear();
                    command.Parameters.Add("idP", MySqlDbType.Int32).Value = item.l_id;
                    command.Parameters.Add("can", MySqlDbType.Int32).Value = item.l_cantidad;
                    command.Parameters.Add("pre", MySqlDbType.Float).Value = item.l_precio;
                    command.Parameters.Add("idV", MySqlDbType.Int32).Value = idVenta;
                    command.ExecuteNonQuery();
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
