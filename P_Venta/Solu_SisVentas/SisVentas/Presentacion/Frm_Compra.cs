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
    public partial class Frm_Compra : Form
    {
        BindingList<E_SaleItem> pedido;
        D_Store sqlItem = new D_Store();
        float total = 0;
        public int idUser { get; set; }
        public int idProv { get; set; }
        public Frm_Compra()
        {
            InitializeComponent();
            pedido = new BindingList<E_SaleItem>();
            dGV_Pedido.DataSource = pedido;
            tBox_total.Text = total.ToString();
            Listado_prov();
            idProv = Convert.ToInt32((cmb_Inventario.SelectedItem as DataRowView)?.Row[0]);
        }

        private void Listado_prov()
        {
            try
            {
                D_Productos Datos = new D_Productos();
                cmb_Inventario.DataSource = Datos.Listado_prov();
                cmb_Inventario.ValueMember = "codigo_prov";
                cmb_Inventario.DisplayMember = "nombre_prov";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void b_buscar_MouseClick(object sender, MouseEventArgs e)
        {
            string codigo = tBox_codigo.Text;
            E_SaleItem item;
            int index = -1;
            bool found = false;

            if (codigo == "") return;

            foreach (E_SaleItem ped in pedido)
            {
                index++;
                if (codigo == ped.l_codigo)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                item = pedido[index];
                b_Agregar.Text = "Actualizar";
            }
            else
            {
                idProv = Convert.ToInt32((cmb_Inventario.SelectedItem as DataRowView)?.Row[0]);
                item = sqlItem.getBuyItem(codigo, idProv);
            }

            if(item.l_id == 0)
            {
                MessageBox.Show("No se encontro el producto");
            }

            tBox_id.Text = item.l_id.ToString();
            tBox_codigo.Text = item.l_codigo;
            tBox_desc.Text = item.l_desc;
            tBox_precio.Text = item.l_precio.ToString("#.00");
            nud_cant.Value = item.l_cantidad;
        }

        private void b_Agregar_MouseClick(object sender, MouseEventArgs e)
        {
            int index = -1;
            bool found = false;
            string cod = tBox_codigo.Text;
            int cant = (int)nud_cant.Value;
            float precio = (float)Convert.ToDecimal(tBox_precio.Text);

            if (cod == "") return;

            foreach (E_SaleItem ped in pedido)
            {
                index++;
                if (cod == ped.l_codigo)
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                total -= pedido[index].l_cantidad * precio;
                pedido[index].l_cantidad = cant;
                b_Agregar.Text = "Agregar";
            }
            else
            {
                int id = Convert.ToInt32(tBox_id.Text);
                string desc = tBox_desc.Text;
                pedido.Add(new E_SaleItem(id, cod, desc, cant, precio));
            }

            tBox_id.Text = "";
            tBox_codigo.Text = "";
            tBox_desc.Text = "";
            nud_cant.Value = 1M;
            tBox_precio.Text = "";

            total += (cant * precio);

            dGV_Pedido.Refresh();
            tBox_total.Text = total.ToString("#.00");
        }

        private void b_regCompra_MouseClick(object sender, MouseEventArgs e)
        {
            if (pedido.Count == 0)
            {
                MessageBox.Show("No hay productos en pedido");
            }
            else
            {
                sqlItem.storeBuyData(pedido, total, idUser, idProv);
                pedido.Clear();
                total = 0;
                dGV_Pedido.Refresh();
                tBox_total.Text = total.ToString();
            }
        }

        private void b_Salir_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void Frm_Compra_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Elegir el proveedor al inicio, si cambia el proveedor se reseteara el listado de productos");
        }

        private void cmb_Inventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            idProv = Convert.ToInt32((cmb_Inventario.SelectedItem as DataRowView)?.Row[0]);
            pedido.Clear();
            total = 0f;
            tBox_total.Text = total.ToString();
        }

        private void dGV_Pedido_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int dataRow = dGV_Pedido.Rows[e.RowIndex].Index;

            E_SaleItem item = pedido[dataRow];

            DialogResult res = MessageBox.Show("Desea eliminar el producto con codigo: " + item.l_codigo, "Eliminar", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                total -= item.l_cantidad * item.l_precio;
                tBox_total.Text = total.ToString();
                pedido.RemoveAt(dataRow);
            }
        }
    }
}
