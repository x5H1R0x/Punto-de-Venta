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

namespace SisVentas.Presentacion
{
    public partial class Frm_SalesReport : Form
    {
        D_Report report = new D_Report();
        public Frm_SalesReport()
        {
            InitializeComponent();
        }

        private void button_report_Click(object sender, EventArgs e)
        {
            string fInicio = dtp_desde.Value.ToString("yyyy-MM-dd");
            string fFin = dtp_hasta.Value.ToString("yyyy-MM-dd");
            DataTable ventas = new DataTable(), compras;
            float tVentas, tCompras, total;

            ventas = report.getVentas(fInicio, fFin);
            compras = report.getCompras(fInicio, fFin);

            if (ventas != null && ventas.Rows.Count > 0)
            {
                tVentas = (float)Convert.ToDouble(ventas.Compute("SUM(total)", string.Empty));
            }
            else
            {
                tVentas = 0f;
            }
            if (compras != null && compras.Rows.Count > 0)
            {
                tCompras = (float)Convert.ToDouble(compras.Compute("SUM(total)", string.Empty));
            }
            else
            {
                tCompras = 0f;
            }

            total = tVentas - tCompras;

            dataGridView_Sales.DataSource = ventas;
            dataGridView_Buys.DataSource = compras;
            tBox_tVentas.Text = tVentas.ToString("#.00");
            tBox_tCompras.Text = tCompras.ToString("#.00");
            tBox_total.Text = total.ToString("#.00");

            MessageBox.Show("Se ha cargado la información");
        }

        private void dataGridView_Sales_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idventa = (int)dataGridView_Sales.Rows[e.RowIndex].Cells[0].Value;
            Frm_Details detalles = new Frm_Details(idventa, true);

            detalles.ShowDialog();
        }

        private void button_Exit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void dataGridView_Buys_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idcompra = (int)dataGridView_Sales.Rows[e.RowIndex].Cells[0].Value;
            Frm_Details detalles = new Frm_Details(idcompra, false);

            detalles.ShowDialog();
        }
    }
}
