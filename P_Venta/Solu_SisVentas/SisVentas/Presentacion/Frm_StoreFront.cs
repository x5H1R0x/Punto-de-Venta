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
            string id = tBox_Codigo.Text;

            if (id == "") return;

            E_SaleItem item = sqlItem.getStoreItem(id);

            tBox_Id.Text = item.l_id.ToString();
			tBox_desc.Text = item.l_desc;
			tBox_precio.Text = item.l_precio.ToString();
			numUD_cantidad.Value = 1;
        }

        private void button_AddtoList_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tBox_Id.Text);
            string desc = tBox_desc.Text;
            float cant = (float)numUD_cantidad.Value;
            float precio = (float) Convert.ToDecimal(tBox_precio.Text);

            tBox_Id.Text = "";
            tBox_Codigo.Text = "";
            tBox_desc.Text = "";
            numUD_cantidad.Value = 0.0M;
            tBox_precio.Text = "";


            total += (cant * precio);

            venta.Add(new E_SaleItem(id, desc, cant, precio));
            dataGridView_venta.Refresh();
            tBox_SaleTotal.Text = total.ToString();

        }

        private void button_Cerrar_venta_Click(object sender, EventArgs e)
        {
            //SQL nueva venta, tomar ID del resultado para la sig. talvez total se guarda para no tener que calcular
            sqlItem.storeSaleData(venta);
        }
    }
}
