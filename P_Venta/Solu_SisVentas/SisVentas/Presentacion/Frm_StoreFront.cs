using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisVentas.Datos;
using SisVentas.Entidades;

namespace SisVentas.Presentacion
{
    public partial class Frm_StoreFront : Form
    {
        BindingList<E_SaleItem> venta;
        D_Store sqlItem = new D_Store();
        float total = 0;

		public Frm_StoreFront()
        {
            InitializeComponent();
            venta = new BindingList<E_SaleItem>();
            dataGridView_venta.DataSource = venta;
            tBox_SaleTotal.Text = total.ToString();
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            string codigo = tBox_Codigo.Text;
            E_SaleItem item;
            int index = -1;
            bool found = false;

            if (codigo == "") return;

            foreach(E_SaleItem venI in venta)
            {
                index++;
                if(codigo == venI.l_codigo)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                item = venta[index];
                button_AddtoList.Text = "Actualizar";
            }
            else
            {
                item = sqlItem.getStoreItem(codigo);
            }

            tBox_Id.Text = item.l_id.ToString();
			tBox_desc.Text = item.l_desc;
			tBox_precio.Text = item.l_precio.ToString();
			numUD_cantidad.Value = item.l_cantidad;

        }

        private void button_AddtoList_Click(object sender, EventArgs e)
        {
            int index = -1;
            bool found = false;
            string cod = tBox_Codigo.Text;
            int cant = (int)numUD_cantidad.Value;
            float precio = (float)Convert.ToDecimal(tBox_precio.Text);

            if (cod == "") return;

            foreach (E_SaleItem venI in venta)
            {
                index++;
                if (cod == venI.l_codigo)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                total -= venta[index].l_cantidad * precio;
                venta[index].l_cantidad = cant;
                button_AddtoList.Text = "Agregar";
            }
            else
            {
                int id = Convert.ToInt32(tBox_Id.Text);
                string desc = tBox_desc.Text;
                venta.Add(new E_SaleItem(id, cod, desc, cant, precio));
            }

            tBox_Id.Text = "";
            tBox_Codigo.Text = "";
            tBox_desc.Text = "";
            numUD_cantidad.Value = 0.0M;
            tBox_precio.Text = "";

            total += (cant * precio);
            
            dataGridView_venta.Refresh();
            tBox_SaleTotal.Text = total.ToString();

        }

        private void button_Cerrar_venta_Click(object sender, EventArgs e)
        {
            sqlItem.storeSaleData(venta, total);
            venta.Clear();
            total = 0;
            dataGridView_venta.Refresh();
            tBox_SaleTotal.Text = total.ToString();
        }

        private void dataGridView_venta_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int dataRow = dataGridView_venta.Rows[e.RowIndex].Index;

            E_SaleItem item = venta[dataRow];

            DialogResult res = MessageBox.Show("Desea eliminar el producto con codigo: " + item.l_codigo, "Eliminar", MessageBoxButtons.YesNo);

            if(res == DialogResult.Yes)
            {
                total -= item.l_cantidad * item.l_precio;
                tBox_SaleTotal.Text = total.ToString();
                venta.RemoveAt(dataRow);
            }

        }

        private void button_Exit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
