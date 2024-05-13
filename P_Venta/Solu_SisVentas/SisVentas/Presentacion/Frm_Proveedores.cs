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
    public partial class Frm_Proveedores : Form
    {
        public int CodigoUs_prov { get; set; }
        public string LoginUs_prov { get; set; }
        public string NombreUs_prov { get; set; }
        public Frm_Proveedores()
        {
            InitializeComponent();
        }

        //Variables de Proveedores
        #region "Estado de variables Proveedores"
        int nEstadoGuarda = 0;
        int nCodigo_prov = 0;

        #endregion

        // Metodos de proveedor
        #region
        private void limpiar_texto()
        {
            txtNombreProv.Text = "";
            txtDireccionProv.Text = "";
            txtTelefono.Text = "";

        }
        private void Estado_texto(bool lEstado)
        {
            txtNombreProv.Enabled = lEstado;
            txtDireccionProv.Enabled = lEstado;
            txtTelefono.Enabled = lEstado;
            

            txtBusquedaProv.Enabled = !lEstado;
            dgvListado.Enabled = !lEstado;
            btnBusqueda.Enabled = !lEstado;
        }
        private void Estado_botones_procesos(bool lEstado)
        {
            btnCancelarProv.Visible = lEstado;
            btnGuardarProv.Visible = lEstado;
        }
        private void Estados_botnes_principales(bool lEstado)
        {
            btnNuevoProv.Enabled = lEstado;
            btnActualizarProv.Enabled = lEstado;
            btnEstadoProv.Enabled = lEstado;
            btnMenuPrincipal.Enabled = lEstado;
        }
        private void Formato()
        {
            if (dgvListado.Columns.Count >= 7)
            {

                dgvListado.Columns.Clear(); // Elimina todas las columnas existentes

                // Agrega las nuevas columnas

   
            }
        }
        private void Listado_prov(string cTexto)
        {
            D_Proveedores Datos = new D_Proveedores();
            DataTable tabla = Datos.Listado_prov(cTexto);

            dgvListado.DataSource = tabla;
            this.Formato(); // Llama al método de formato después de cargar los datos
        }

        private void Selecciona_item()
        {
            if (dgvListado.CurrentRow != null && dgvListado.CurrentRow.Cells["codigo_prov"].Value != null)
            {
                nCodigo_prov = Convert.ToInt32(dgvListado.CurrentRow.Cells["codigo_prov"].Value);
                txtNombreProv.Text = dgvListado.CurrentRow.Cells["nombre_prov"].Value.ToString();
                txtDireccionProv.Text = dgvListado.CurrentRow.Cells["direccion_prov"].Value.ToString();
                txtTelefono.Text = dgvListado.CurrentRow.Cells["telefono_prov"].Value.ToString();
                // Suponiendo que también tienes una celda para el código de usuario
                CodigoUs_prov = Convert.ToInt32(dgvListado.CurrentRow.Cells["codigo_us"].Value);
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

        private void btnNuevoProv_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 1; // Nuevo registro
            this.limpiar_texto();
            this.Estado_texto(true);
            this.Estado_botones_procesos(true);
            this.Estados_botnes_principales(false);
            this.txtNombreProv.Focus();
        }

        private void btnActualizarProv_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 2; // Actualizar registro
            this.Estado_texto(true);
            this.Estado_botones_procesos(true);
            this.Estados_botnes_principales(false);
            this.txtNombreProv.Focus();
        }

        private void btnEstadoProv_Click(object sender, EventArgs e)
        {
            if (dgvListado.Rows.Count > 0)
            {
                string Rpta = "";
                D_Proveedores Datos = new D_Proveedores();
                Rpta = Datos.Activo_prov(Convert.ToInt32(dgvListado.CurrentRow.Cells["Código"].Value));
                if (Rpta.Equals("OK"))
                {
                    this.Listado_prov("%");
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

        private void btnCancelarProv_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 0;
            this.limpiar_texto();
            this.Estado_texto(false);
            this.Estado_botones_procesos(false);
            this.Estados_botnes_principales(true);
        }

        private void btnGuardarProv_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de campos llenos
                if (string.IsNullOrEmpty(txtNombreProv.Text) ||
                    string.IsNullOrEmpty(txtDireccionProv.Text) ||
                    string.IsNullOrEmpty(txtTelefono.Text))
                {
                    MessageBox.Show("Ingrese toda la información necesaria (*) ",
                                    "Aviso del Sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }
                // Validar que el campo de teléfono contenga solo números
                else if (!EsNumero(txtTelefono.Text))
                {
                    MessageBox.Show("El campo Teléfono debe contener solo números.",
                                    "Aviso del Sistema",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }
                else // Guardar información en Base de datos
                {
                    string Rpta;
                    E_Proveedores oProv = new E_Proveedores();
                    oProv.nombre_po = txtNombreProv.Text;
                    oProv.direccion_po = txtDireccionProv.Text;
                    oProv.telefono_po = txtTelefono.Text;
                    oProv.codigo_us = Convert.ToInt32(CodigoUs_prov); // Supongo que obtienes este valor de algún lugar en tu aplicación

                    D_Proveedores Datos = new D_Proveedores();
                    // Llamar al procedimiento almacenado para guardar el proveedor
                    Rpta = Datos.Guardar_prov(nEstadoGuarda, oProv);

                    // Verificar si se guardaron datos en la base de datos
                    if (Rpta == "OK")
                    {
                        nEstadoGuarda = 0;
                        nCodigo_prov = 0;
                        this.limpiar_texto();
                        this.Estado_botones_procesos(false);
                        this.Estados_botnes_principales(true);
                        this.Listado_prov("%");
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
                string errorMessage = $"Error al intentar guardar el proveedor:\n{ex.Message}\n\nDetalles del error:\n{ex.StackTrace}";

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

        // Función para validar si una cadena contiene solo números
        private bool EsNumero(string texto)
        {
            foreach (char caracter in texto)
            {
                if (!char.IsDigit(caracter))
                {
                    return false;
                }
            }
            return true;
        }

        private void Frm_Proveedores_Load(object sender, EventArgs e)
        {
            this.Listado_prov("%");
        }

        private void dgvListado_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            this.Listado_prov(txtBusquedaProv.Text);
        }
    }
}
