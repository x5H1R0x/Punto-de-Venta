using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisVentas.Presentacion
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();

            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        #region "Variables de BD"
        internal int nCodigo_us {  get; set; }
        internal string cLogin_us {  get; set; }
        internal string cNombre_us { get; set; }
        internal string cDescripcion_ru {  get; set; }
        internal int nCodigo_ru {  get; set; }
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

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Pnl_Contenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            lbLoginus.Text = "Login: " + cLogin_us +"\n"+
                             "Bienvenido " + cNombre_us;
        }

        private void Pnl_Titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Salir del sistema?",
                                     "Aviso del Sistema",
                                     MessageBoxButtons.OKCancel,
                                     MessageBoxIcon.Question);
            if(Opcion == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            if(nCodigo_ru == 1)
            {
                Frm_Usuarios oFrm_us = new Frm_Usuarios();
                oFrm_us.ShowDialog();
            }
            else
            {
                MessageBox.Show("No tienes privilegios",
                                     "Aviso del Sistema",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            Frm_Productos oFrm_Produ = new Frm_Productos();
            // Asignar valores de usuario a las propiedades de Frm_Productos
            oFrm_Produ.CodigoUs_pr = nCodigo_us;
            oFrm_Produ.LoginUs_pr = cLogin_us;
            oFrm_Produ.NombreUs_pr = cNombre_us;
            oFrm_Produ.ShowDialog();
        }
    }
}
