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
    public partial class Frm_Details : Form
    {
        int idRep;
        bool comVen;    //true venta false compras
        D_Report sqlRep;
        public Frm_Details(int id, bool tipo)
        {
            idRep = id;
            comVen = tipo;
            sqlRep = new D_Report();
            InitializeComponent();
        }

        private void Frm_Details_Load(object sender, EventArgs e)
        {
            if (comVen)
            {
                this.Text = "Detalle Venta";
                groupBox1.Text = "Detalles venta";
                dataGridView_detalles.DataSource = sqlRep.detalle_Venta(idRep);
            }
            else
            {
                this.Text = "Detalle Compra";
                groupBox1.Text = "Detalles Compra";
                dataGridView_detalles.DataSource = sqlRep.detalle_Compra(idRep);
            }
        }
    }
}
