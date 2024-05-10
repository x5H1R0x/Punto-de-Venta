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
            //compras = report.getCompras(fInicio, fFin);

            tVentas = (float)Convert.ToDouble(ventas.Compute("SUM(totalVenta)", string.Empty));
            //tCompras = (float)Convert.ToDouble(compras.Compute("SUM(total)", string.Empty));

            dataGridView_Sales.DataSource = ventas;
            tBox_tVentas.Text = tVentas.ToString();
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
    }
}
