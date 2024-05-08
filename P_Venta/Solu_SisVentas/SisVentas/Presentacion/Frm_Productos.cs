using SisVentas.Datos;
using SisVentas.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisVentas.Presentacion
{
    public partial class Frm_Productos : Form
    {
        // Propiedades para recibir la información del usuario
        public int CodigoUs_pr { get; set; }
        public string LoginUs_pr { get; set; }
        public string NombreUs_pr { get; set; }
        public Frm_Productos()
        {
            InitializeComponent();
        }

        #region
        int nCodigo_pr = 0;
        int nEstadoGuarda = 0;
        #endregion


        #region "Metodos de Frm_productos"
        private void limpiar_texto()
        {
            txtNombreProdu.Text = "";
            txtDescripcionPr.Text = "";
            nuCosto.Value = 0;
            nuDescuento.Value = 0;
            nuVenta.Value = 0;
            cmbFamiProdu.Text = "";

        }
        private void Estado_texto(bool lEstado)
        {
            txtNombreProdu.Enabled = lEstado;
            txtDescripcionPr.Enabled = lEstado;
            nuCosto.Enabled = lEstado;
            nuDescuento.Enabled = lEstado;
            nuVenta.Enabled = lEstado;
            cmbFamiProdu.Enabled = lEstado;

            txtBusquedaPr.Enabled = !lEstado;
            dgvListado.Enabled = !lEstado;
            btnBusqueda.Enabled = !lEstado;
        }
        private void Estado_botones_procesos(bool lEstado)
        {
            btnCancelarProdu.Visible = lEstado;
            btnGuardarProdu.Visible = lEstado;
        }
        private void Estados_botnes_principales(bool lEstado)
        {
            btnAgregarProd.Enabled = lEstado;
            btnActualizarProd.Enabled = lEstado;
            btnEstadoProd.Enabled = lEstado;
            btnMenuPrincipal.Enabled = lEstado;
        }
        private void Formato()
        {
            dgvListado.Columns[0].Width = 50;
            dgvListado.Columns[0].HeaderText = "Codigo";
            dgvListado.Columns[1].Width = 50;
            dgvListado.Columns[1].HeaderText = "Nombre";
            dgvListado.Columns[2].Width = 180;
            dgvListado.Columns[2].HeaderText = "Descripcion";
            dgvListado.Columns[3].Width = 80;
            dgvListado.Columns[3].HeaderText = "Costo";
            dgvListado.Columns[4].Width = 80;
            dgvListado.Columns[4].HeaderText = "Venta";
            dgvListado.Columns[5].Width = 80;
            dgvListado.Columns[5].HeaderText = "Descuento";
            dgvListado.Columns[6].Width = 50;
            dgvListado.Columns[6].HeaderText = "Activo";
        }
        private void Listado_Produ(string cTexto)
        {
            D_Usuarios Datos = new D_Usuarios();
            dgvListado.DataSource = Datos.Listado_us(cTexto);
            this.Formato();
        }
        private void Listado_ru()
        {
            try
            {
                D_Usuarios Datos = new D_Usuarios();
                cmbFamiProdu.DataSource = Datos.Listado_ru();
                cmbFamiProdu.ValueMember = "codigo_ru";
                cmbFamiProdu.DisplayMember = "descripcion_ru";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Selecciona_item()
        {
            if (dgvListado.CurrentRow != null && dgvListado.CurrentRow.Cells["codigo_pr"].Value != null)
            {
                nCodigo_pr = Convert.ToInt32(dgvListado.CurrentRow.Cells["codigo_pr"].Value);
                txtDescripcionPr.Text = dgvListado.CurrentRow.Cells["descripcion_pr"].Value.ToString();
                nuCosto.Text = dgvListado.CurrentRow.Cells["pu_costo"].Value.ToString();
                nuVenta.Text = dgvListado.CurrentRow.Cells["pu_venta"].Value.ToString();
                nuDescuento.Text = dgvListado.CurrentRow.Cells["pu_descuento"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione un registro válido",
                                "Aviso del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }

        #endregion
        ///EndRegion
        private void lbUsuarios_Click(object sender, EventArgs e)
        {

        }
        // Crea listado de productos
        private void Listado_pr(string cTexto)
        {
            D_Productos Datos = new D_Productos();
            dgvListado.DataSource = Datos.Listado_pr(cTexto);
            this.Formato();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarProd_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 1; // Nuevo registro
            this.limpiar_texto();
            this.Estado_texto(true);
            this.Estado_botones_procesos(true);
            this.Estados_botnes_principales(false);
            this.txtDescripcionPr.Focus();
        }

        private void btnActualizarProd_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 2; // Actualizar registro
            this.Estado_texto(true);
            this.Estado_botones_procesos(true);
            this.Estados_botnes_principales(false);
            this.txtDescripcionPr.Focus();
        }

        private void btnEstadoProd_Click(object sender, EventArgs e)
        {
            if (dgvListado.Rows.Count > 0)
            {
                string Rpta = "";
                D_Productos Datos = new D_Productos();
                Rpta = Datos.Activo_pr(Convert.ToInt32(dgvListado.CurrentRow.Cells["codigo_pr"].Value));
                if (Rpta.Equals("OK"))
                {
                    this.Listado_pr("%");
                    MessageBox.Show("Proceso de estado actualizado",
                                    "Aviso del sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(Rpta,
                                   "Aviso del sistema",
                                   MessageBoxButtons.OK,
                                   MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelarProdu_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 0;
            this.limpiar_texto();
            this.Estado_texto(false);
            this.Estado_botones_procesos(false);
            this.Estados_botnes_principales(true);
        }

        private void btnGuardarProdu_Click(object sender, EventArgs e)
        {
            // Validación de campos llenos
            if (string.IsNullOrEmpty(txtDescripcionPr.Text) ||
                nuCosto.Text == string.Empty ||
                nuVenta.Text == string.Empty ||
                nuDescuento.Text == string.Empty ||
                cmbFamiProdu.SelectedItem == null)
            {
                MessageBox.Show("Ingrese toda la información necesaria (*) ",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else // Guardar información en Base de datos
            {
                string Rpta;
                E_Productos oPro = new E_Productos();
                oPro.Descripcion_pr = txtDescripcionPr.Text;
                oPro.Pu_costo = Convert.ToDecimal(nuCosto.Value);
                oPro.Pu_venta = Convert.ToDecimal(nuVenta.Value);
                oPro.Pu_descuento = Convert.ToDecimal(nuDescuento.Value);
                oPro.Codigo_fa = Convert.ToInt32(cmbFamiProdu.SelectedItem);

                D_Productos Datos = new D_Productos();
                Rpta = Datos.Guardar_pr(nEstadoGuarda, oPro);

                // Verificar si se guardaron datos en la base de datos
                if (Rpta != "")
                {
                    bool esNumero = int.TryParse(Rpta, out int xCodigo);
                    if (esNumero == true)
                    {
                        nEstadoGuarda = 0;
                        nCodigo_pr = 0;
                        this.limpiar_texto();
                        this.Estado_botones_procesos(false);
                        this.Estados_botnes_principales(true);
                        this.Listado_pr("%");
                        MessageBox.Show("Los Datos fueron guardados correctamente",
                                        "Aviso del sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Mostrar un mensaje en caso de que no se guarden datos
                        MessageBox.Show("No se pudo guardar la información en la base de datos",
                                        "Aviso del sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    // Mostrar un mensaje en caso de que no se guarden datos
                    MessageBox.Show("No se pudo guardar la información en la base de datos \nRpta Vacia",
                                    "Aviso del sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                }
            }
        }


        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            //this.Listado_pr();
            // Llenar combobox de usuarios

        }

        private void btnBusquedaPr_Click(object sender, EventArgs e)
        {
            this.Listado_pr(txtBusquedaPr.Text);
        }

        private void dgvListadoPr_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item();
        }

    }
}
