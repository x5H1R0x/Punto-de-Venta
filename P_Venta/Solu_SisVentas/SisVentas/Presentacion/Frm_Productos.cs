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
            limpiar_texto();
        }
        // Variables Producto
        #region
        int nCodigo_pr = 0;
        int nEstadoGuarda = 0;
        #endregion
        // Metodos Producto
        #region "Metodos de Frm_productos"
        private void limpiar_texto()
        {
            txtNombrePr.Text = "";
            txtDescripcionPr.Text = "";
            nuCosto.Value = 0;
            txtCodigoManu.Text = "";
            nuVenta.Value = 0;
            cmbFamiPr.Text = "";

        }
        private void Estado_texto(bool lEstado)
        {
            txtNombrePr.Enabled = lEstado;
            txtDescripcionPr.Enabled = lEstado;
            nuCosto.Enabled = lEstado;
            txtCodigoManu.Enabled = lEstado;
            nuVenta.Enabled = lEstado;
            cmbFamiPr.Enabled = lEstado;

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
//
        }
        private void Listado_pr(string cTexto)
        {
            D_Productos Datos = new D_Productos();
            DataTable tabla = Datos.Listado_pr(cTexto);

            dgvListado.DataSource = tabla;
            this.Formato(); // Llama al método de formato después de cargar los datos
        }

        private void Listado_prov()
        {
            try
            {
                D_Productos Datos = new D_Productos();
                cmbProvProdu.DataSource = Datos.Listado_prov();
                cmbProvProdu.ValueMember = "codigo_prov";
                cmbProvProdu.DisplayMember = "nombre_prov";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Listado_fa()
        {
            try
            {
                D_Productos Datos = new D_Productos();
                cmbFamiPr.DataSource = Datos.Listado_fa();
                cmbFamiPr.ValueMember = "codigo_fa";
                cmbFamiPr.DisplayMember = "nombre_fa";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Selecciona_item()
        {
            if (dgvListado.CurrentRow != null &&
                dgvListado.CurrentRow.Cells["codigo_pr"] != null &&
                dgvListado.CurrentRow.Cells["codigo_pr"].Value != null)
            {
                nCodigo_pr = Convert.ToInt32(dgvListado.CurrentRow.Cells["codigo_pr"].Value);
                txtDescripcionPr.Text = dgvListado.CurrentRow.Cells["descripcion_pr"].Value.ToString();
                nuCosto.Text = dgvListado.CurrentRow.Cells["pu_costo"].Value.ToString();
                nuVenta.Text = dgvListado.CurrentRow.Cells["pu_venta"].Value.ToString();
                txtCodigoManu.Text = dgvListado.CurrentRow.Cells["codigo_manu"].Value.ToString();
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
        // Funciones de objetos en pantalla producto
        private void btnMenuPrincipal_Click(object sender, EventArgs e)
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
            try
            {
                // Validación de campos llenos
                if (string.IsNullOrEmpty(txtDescripcionPr.Text) ||
                    nuCosto.Text == string.Empty ||
                    nuVenta.Text == string.Empty ||
                    txtCodigoManu.Text == string.Empty ||
                    cmbFamiPr.SelectedItem == null    ||
                    cmbProvProdu.SelectedItem == null)
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
                    oPro.nombre_pr = txtNombrePr.Text;
                    oPro.descripcion_pr = txtDescripcionPr.Text;
                    oPro.codigo_manu = txtCodigoManu.Text;
                    oPro.pu_costo = Convert.ToDecimal(nuCosto.Value);
                    oPro.pu_venta = Convert.ToDecimal(nuVenta.Value);
                    oPro.codigo_prov = Convert.ToInt32((cmbFamiPr.SelectedItem as DataRowView)?.Row[0]);
                    oPro.codigo_us = Convert.ToInt32(CodigoUs_pr);
                    oPro.codigo_fa = Convert.ToInt32((cmbFamiPr.SelectedItem as DataRowView)?.Row[0]);


                    D_Productos Datos = new D_Productos();
                    // Llamar al procedimiento almacenado para guardar el producto
                    Rpta = Datos.Guardar_pr(nEstadoGuarda, oPro);

                    // Verificar si se guardaron datos en la base de datos
                    if (Rpta == "OK")
                    {
                        nEstadoGuarda = 0;
                        nCodigo_pr = 0;
                        this.limpiar_texto();
                        this.Estado_botones_procesos(false);
                        this.Estados_botnes_principales(true);
                        this.Listado_pr("%");
                        MessageBox.Show("Los Datos fueron guardados correctamente.\n" + Rpta, // Rpta ahora contiene la cadena enviada al procedimiento
                                        "Aviso del sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Mostrar un mensaje en caso de que no se guarden datos
                        MessageBox.Show($"FRm...\nNo se pudo guardar la información en la base de datos. Detalles del error: {Rpta}",
                                        "Aviso del sistema",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                // Construir el mensaje de error detallado
                string errorMessage = $"Error al intentar guardar el producto:\n{ex.Message}\n\nDetalles del error:\n{ex.StackTrace}";

                // Mostrar un mensaje detallado del error
                MessageBox.Show(errorMessage,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);

                // Ofrecer la opción de copiar el error al portapapeles
                if (MessageBox.Show("¿Desea copiar este mensaje de error al portapapeles?", "Copiar Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Copiar el mensaje de error al portapapeles
                    Clipboard.SetText(errorMessage);
                }
            }
        }

        private void btnBusquedaPr_Click(object sender, EventArgs e)
        {
            this.Listado_pr(txtBusquedaPr.Text);
        }

        private void dgvListadoPr_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListado.CurrentRow != null)
            {
                this.Selecciona_item();
            }
        }

        private void Frm_Productos_Load(object sender, EventArgs e)
        {
            this.Listado_prov();
            this.Listado_fa();
            Listado_pr("%");
        }

        private void dgvListado_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item();
        }
    }
}
