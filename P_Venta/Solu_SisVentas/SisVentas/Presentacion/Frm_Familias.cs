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
    public partial class Frm_Familias : Form
    {
        // Propiedades para recibir la información del usuario
        public int CodigoUs_fa { get; set; }
        public string LoginUs_fa { get; set; }
        public string NombreUs_fa { get; set; }
        public Frm_Familias()
        {
            InitializeComponent();
            limpiar_texto();
        }
        // Varibles Familia
        #region "Variables Familia"
        int nCodigo_fa = 0;
        int nEstadoGuarda = 0;
        #endregion
        // Metodos Familia
        #region "Metodos de Frm_Familia"
        private void limpiar_texto()
        {
            txtNombreFa.Text = "";
            txtDescripcionFa.Text = "";
        }
        private void Estado_texto(bool lEstado)
        {
            txtNombreFa.Enabled = lEstado;
            txtDescripcionFa.Enabled = lEstado;

            txtBusquedaFa.Enabled = !lEstado;
            dgvListado.Enabled = !lEstado;
            btnBusqueda.Enabled = !lEstado;
        }
        private void Estado_botones_procesos(bool lEstado)
        {
            btnCancelarFa.Visible = lEstado;
            btnGuardarFa.Visible = lEstado;
        }
        private void Estados_botnes_principales(bool lEstado)
        {
            btnAgregarFa.Enabled = lEstado;
            btnActualizarFa.Enabled = lEstado;
            btnEstadoFa.Enabled = lEstado;
            btnMenuPrincipal.Enabled = lEstado;
        }
        private void Formato()
        {
            dgvListado.Columns[0].Width = 50;
            dgvListado.Columns[0].HeaderText = "Codigo";
            dgvListado.Columns[1].Width = 80;
            dgvListado.Columns[1].HeaderText = "Nombre";
            dgvListado.Columns[2].Width = 300;
            dgvListado.Columns[2].HeaderText = "Descripcion";
            dgvListado.Columns[3].Width = 50;
            dgvListado.Columns[3].HeaderText = "Activo";
        }
        private void Listado_fa(string cTexto)
        {
            D_Familias Datos = new D_Familias();
            dgvListado.DataSource = Datos.Listado_fa(cTexto);
            this.Formato();
        }
        private void Selecciona_item()
        {
            if (dgvListado.CurrentRow != null && dgvListado.CurrentRow.Cells["codigo_fa"].Value != null)
            {
                nCodigo_fa = Convert.ToInt32(dgvListado.CurrentRow.Cells["codigo_fa"].Value);
                txtNombreFa.Text = dgvListado.CurrentRow.Cells["nombre_fa"].Value.ToString();
                txtDescripcionFa.Text = dgvListado.CurrentRow.Cells["descripcion_fa"].Value.ToString();
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

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarFa_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 1;//Nuevo registro
            this.limpiar_texto();
            this.Estado_texto(true);
            this.Estado_botones_procesos(true);
            this.Estados_botnes_principales(false);
            this.txtNombreFa.Focus();
        }

        private void btnActualizarFa_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 2;//Actualizar registro
            this.Estado_texto(true);
            txtNombreFa.Enabled = false;
            this.Estado_botones_procesos(true);
            this.Estados_botnes_principales(false);
            this.txtNombreFa.Focus();
        }

        private void btnEstadoFa_Click(object sender, EventArgs e)
        {
            if (dgvListado.Rows.Count > 0 && dgvListado.CurrentRow != null && dgvListado.CurrentRow.Cells["codigo_fa"].Value != null)
            {
                string Rpta = "";
                D_Familias Datos = new D_Familias();
                Rpta = Datos.Activo_fa(Convert.ToInt32(dgvListado.CurrentRow.Cells["codigo_fa"].Value));
                if (Rpta.Equals("OK"))
                {
                    this.Listado_fa("%");
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
            else
            {
                MessageBox.Show("Seleccione un registro válido",
                                "Aviso del sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }

        private void btnGuardarFa_Click(object sender, EventArgs e)
        {
            // Validación de campos llenos
            if (txtNombreFa.Text == string.Empty || txtDescripcionFa.Text == string.Empty)
            {
                MessageBox.Show("Ingrese toda la información necesaria (*)",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else // Guardar información en Base de datos
            {
                string Rpta;
                E_Familias oFa = new E_Familias();
                oFa.codigo_fa = nCodigo_fa;
                oFa.nombre_fa = txtNombreFa.Text;
                oFa.descripcion_fa = txtDescripcionFa.Text;

                D_Familias Datos = new D_Familias();
                Rpta = Datos.Guardar_fa(nEstadoGuarda, oFa);

                // Verificar si se guardaron datos en la base de datos
                if (Rpta != "")
                {
                    bool esNumero = int.TryParse(Rpta, out int xCodigo);
                    if (esNumero == true)
                    {
                        nEstadoGuarda = 0;
                        nCodigo_fa = 0;
                        this.limpiar_texto();
                        this.Estado_botones_procesos(false);
                        this.Estados_botnes_principales(true);
                        this.Listado_fa("%");
                        MessageBox.Show("Los Datos fueron guardados correctamente",
                                        "Aviso del sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Mostrar un mensaje en caso de que no se guarden datos
                        MessageBox.Show("ERROR FRM_Familias...\nNo se pudo guardar la información en la base de datos",
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

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            this.Listado_fa(txtBusquedaFa.Text);
        }

        private void btnCancelarFa_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 0;
            this.limpiar_texto();
            this.Estado_texto(false);
            this.Estado_botones_procesos(false);
            this.Estados_botnes_principales(true);
        }

        private void dgvListado_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item();
        }

        private void Frm_Familias_Load(object sender, EventArgs e)
        {
            this.Listado_fa("%");
        }
    }
}
