using SisVentas.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisVentas.Presentacion
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
            this.toolTip1.SetToolTip(this.btnIniciar, "Iniciar sesion ahora");
            this.toolTip1.SetToolTip(this.btnSalir, "Salir del sistema");

            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        #region "Metodos LogOut"
        private void Logout(object sender, FormClosedEventArgs e)
        {
            this.txtLoginus.Text = string.Empty;
            this.txtPasswordus.Text = string.Empty;
            this.txtLoginus.Select();
        }


        #endregion


        #region "Estilo para el control del Titulo"
        //Drag Form
        [DllImport("user32.Dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.Dll", EntryPoint = "SendMenssage")]
        private extern static void SendMenssage(System.IntPtr Hand, int wMsg, int wParam, int lParam);
        #endregion

        // Declaración de la función externa SendMessage
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pnlTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            DataTable Tablalogin = new DataTable();
            D_Usuarios Datos = new D_Usuarios();
            Tablalogin = Datos.Login_us(txtLoginus.Text, txtPasswordus.Text);
            if (Tablalogin.Rows.Count > 0)
            {
                Frm_Principal ofrm_Principal = new Frm_Principal();
                ofrm_Principal.nCodigo_us = Convert.ToInt32(Tablalogin.Rows[0][0]);
                ofrm_Principal.cLogin_us = Convert.ToString(Tablalogin.Rows[0][1]);
                ofrm_Principal.cNombre_us = Convert.ToString(Tablalogin.Rows[0][2]);
                ofrm_Principal.cDescripcion_ru = Convert.ToString(Tablalogin.Rows[0][3]);
                ofrm_Principal.nCodigo_ru = Convert.ToInt32(Tablalogin.Rows[0][4]);
                ofrm_Principal.FormClosed += Logout;
                ofrm_Principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrectos");
            }
        }
    }
}
