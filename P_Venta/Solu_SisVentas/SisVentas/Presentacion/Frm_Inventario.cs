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
    public partial class Frm_Inventario : Form
    {
        D_Report sqlItem = new D_Report();
        DataTable datos;
        public Frm_Inventario()
        {
            InitializeComponent();
        }

        private void b_Inv_MouseClick(object sender, MouseEventArgs e)
        {
            int minInv;

            minInv = (int)nud_Inv.Value;

            datos = sqlItem.getInventario(minInv);

            dGV_Inv.DataSource = datos;

        }

        private void b_Salir_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
