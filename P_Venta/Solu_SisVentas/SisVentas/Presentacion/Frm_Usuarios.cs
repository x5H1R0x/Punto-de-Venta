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
    public partial class Frm_Usuarios : Form
    {
        public Frm_Usuarios()
        {
            InitializeComponent();
            limpiar_texto();
        }
        // Varibles Usuarios
        #region "Variables Usuario"
        int nCodigo_us = 0;
        int nEstadoGuarda = 0;
        #endregion
        // Metodos Usuario
        #region "Metodos de Frm_Usuarios"
        private void limpiar_texto()
        {
            txtLoginus.Text = "";
            txtPasswordus.Text = "";
            txtNombreus.Text = "";
            cmbRolus.Text = "";
            
        }
        private void Estado_texto(bool lEstado)
        {
            txtNombreus.Enabled = lEstado;
            txtPasswordus.Enabled = lEstado;
            txtNombreus.Enabled = lEstado;
            cmbRolus.Enabled = lEstado;

            txtBusquedaus.Enabled = !lEstado;
            dgvListado.Enabled = !lEstado;
            btnBusqueda.Enabled = !lEstado;
        }
        private void Estado_botones_procesos(bool lEstado)
        {
            btnCancelarus.Visible = lEstado;
            btnGuardarus.Visible = lEstado;
        }
        private void Estados_botnes_principales(bool lEstado)
        {
            btnNuevoUs.Enabled = lEstado;
            btnActualizarUs.Enabled = lEstado;
            btnEstadoUs.Enabled = lEstado;
            btnMenuPrincipal.Enabled = lEstado; 
        }
        private void Formato()
        {
            dgvListado.Columns[0].Width = 50;
            dgvListado.Columns[0].HeaderText = "Codigo";
            dgvListado.Columns[1].Width = 50;
            dgvListado.Columns[1].HeaderText = "Login";
            dgvListado.Columns[2].Width = 180;
            dgvListado.Columns[2].HeaderText = "Nombre";
            dgvListado.Columns[3].Width = 80;
            dgvListado.Columns[3].HeaderText = "Rol";
            dgvListado.Columns[4].Width = 50;
            dgvListado.Columns[4].HeaderText = "Activo";
        }
        private void Listado_us(string cTexto)
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
                cmbRolus.DataSource = Datos.Listado_ru();
                cmbRolus.ValueMember = "codigo_ru";
                cmbRolus.DisplayMember = "descripcion_ru";

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void Selecciona_item()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgvListado.CurrentRow.Cells["codigo_us"].Value)))
            {
                MessageBox.Show("Seleccione un registro valido",
                                "Aviso del sistema",
                                MessageBoxButtons.OK, 
                                MessageBoxIcon.Exclamation);
            }
            else
            {
                nCodigo_us = Convert.ToInt32(dgvListado.CurrentRow.Cells["codigo_us"].Value);
                txtLoginus.Text = dgvListado.CurrentRow.Cells["login_us"].Value.ToString();
                txtPasswordus.Text = "";
                txtNombreus.Text = dgvListado.CurrentRow.Cells["nombre_us"].Value.ToString();
                cmbRolus.Text = dgvListado.CurrentRow.Cells["descripcion_ru"].Value.ToString();
            }
        }
        #endregion
        // Funciones de objetos en pantalla usuario
        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnNuevoUs_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 1;//Nuevo registro
            this.limpiar_texto();
            this.Estado_texto(true);
            this.Estado_botones_procesos(true);
            this.Estados_botnes_principales(false);
            this.txtLoginus.Focus();
        }

        private void btnActualizarUs_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 2;//Actualizar registro
            this.Estado_texto(true);
            txtLoginus.Enabled = false;
            this.Estado_botones_procesos(true);
            this.Estados_botnes_principales(false);
            this.txtNombreus.Focus();
        }

        private void btnEstadoUs_Click(object sender, EventArgs e)
        {
            if (dgvListado.Rows.Count > 0)
            {
                string Rpta = "";
                D_Usuarios Datos = new D_Usuarios();
                Rpta = Datos.Activo_us(Convert.ToInt32(dgvListado.CurrentRow.Cells["codigo_us"].Value));
                if (Rpta.Equals("OK"))
                {
                    this.Listado_us("%");
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

        private void btnCancelarus_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 0;
            this.limpiar_texto();
            this.Estado_texto(false);
            this.Estado_botones_procesos(false);
            this.Estados_botnes_principales(true);
        }

        private void btnGuardarus_Click(object sender, EventArgs e)
        {
            // Validacion de campos llenos
            if (txtLoginus.Text == string.Empty ||
                txtPasswordus.Text == string.Empty ||
                txtNombreus.Text == string.Empty ||
                cmbRolus.Text == string.Empty)
            {
                MessageBox.Show("Ingrese toda la informacion necesaria (*) ",
                                "Aviso del Sistema",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
            else // Guardar informacion en Base de datos
            {
                string Rpta;
                E_Usuarios oPro = new E_Usuarios();
                oPro.Codigo_us = nCodigo_us;
                oPro.Login_us = txtLoginus.Text;
                oPro.Password_us = txtPasswordus.Text;
                oPro.Nombre_us = txtNombreus.Text;
                oPro.Codigo_ru = Convert.ToInt32(cmbRolus.SelectedValue);

                D_Usuarios Datos = new D_Usuarios();
                Rpta = Datos.Guardar_us(nEstadoGuarda, oPro);

                // Verificar si se guardaron datos en la base de datos
                if (Rpta != "")
                {
                    bool esNumero = int.TryParse(Rpta, out int xCodigo);
                    if (esNumero == true)
                    {
                        nEstadoGuarda = 0;
                        nCodigo_us = 0;
                        this.limpiar_texto();
                        this.Estado_botones_procesos(false);
                        this.Estados_botnes_principales(true);
                        this.Listado_us("%");
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

        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            this.Listado_ru();
            this.Listado_us("%");
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            this.Listado_us(txtBusquedaus.Text);
        }

        private void dgvListado_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.Selecciona_item();
        }
    }
}
