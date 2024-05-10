namespace SisVentas.Presentacion
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnEmpresa = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Pnl_Titulo = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Pnl_Barraestado = new System.Windows.Forms.Panel();
            this.lbLoginus = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Pnl_Contenido = new System.Windows.Forms.Panel();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnProveedor = new System.Windows.Forms.Button();
            this.btnFamilia = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Pnl_Titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Pnl_Barraestado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Pnl_Contenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnCerrarSesion);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnEmpresa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(732, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 571);
            this.panel1.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(23, 506);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(152, 53);
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(23, 136);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(152, 53);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnEmpresa
            // 
            this.btnEmpresa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpresa.ImageKey = "Empresa_1.png";
            this.btnEmpresa.ImageList = this.imageList1;
            this.btnEmpresa.Location = new System.Drawing.Point(23, 12);
            this.btnEmpresa.Name = "btnEmpresa";
            this.btnEmpresa.Size = new System.Drawing.Size(152, 77);
            this.btnEmpresa.TabIndex = 0;
            this.btnEmpresa.Text = "Empresa";
            this.btnEmpresa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEmpresa.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "empresa.png");
            this.imageList1.Images.SetKeyName(1, "Empresa_1.png");
            this.imageList1.Images.SetKeyName(2, "Producto.png");
            this.imageList1.Images.SetKeyName(3, "Proveedor.png");
            this.imageList1.Images.SetKeyName(4, "Compras.png");
            this.imageList1.Images.SetKeyName(5, "Cliente.png");
            this.imageList1.Images.SetKeyName(6, "Reporte.png");
            this.imageList1.Images.SetKeyName(7, "Familia.png");
            this.imageList1.Images.SetKeyName(8, "Ventas.png");
            // 
            // Pnl_Titulo
            // 
            this.Pnl_Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Pnl_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Titulo.Controls.Add(this.pictureBox1);
            this.Pnl_Titulo.Controls.Add(this.label2);
            this.Pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Titulo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Titulo.Name = "Pnl_Titulo";
            this.Pnl_Titulo.Size = new System.Drawing.Size(732, 104);
            this.Pnl_Titulo.TabIndex = 0;
            this.Pnl_Titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_Titulo_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SisVentas.Properties.Resources._3594363;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Impact", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Location = new System.Drawing.Point(155, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 101);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sistema de Ventas 1.0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Pnl_Barraestado
            // 
            this.Pnl_Barraestado.BackColor = System.Drawing.Color.Teal;
            this.Pnl_Barraestado.Controls.Add(this.lbLoginus);
            this.Pnl_Barraestado.Controls.Add(this.pictureBox2);
            this.Pnl_Barraestado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_Barraestado.Location = new System.Drawing.Point(0, 471);
            this.Pnl_Barraestado.Name = "Pnl_Barraestado";
            this.Pnl_Barraestado.Size = new System.Drawing.Size(732, 100);
            this.Pnl_Barraestado.TabIndex = 1;
            // 
            // lbLoginus
            // 
            this.lbLoginus.AutoSize = true;
            this.lbLoginus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoginus.Location = new System.Drawing.Point(191, 14);
            this.lbLoginus.Name = "lbLoginus";
            this.lbLoginus.Size = new System.Drawing.Size(54, 22);
            this.lbLoginus.TabIndex = 8;
            this.lbLoginus.Text = "Login";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SisVentas.Properties.Resources.User;
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Pnl_Contenido
            // 
            this.Pnl_Contenido.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Pnl_Contenido.Controls.Add(this.btnReportes);
            this.Pnl_Contenido.Controls.Add(this.btnVentas);
            this.Pnl_Contenido.Controls.Add(this.btnCompras);
            this.Pnl_Contenido.Controls.Add(this.btnCliente);
            this.Pnl_Contenido.Controls.Add(this.btnProveedor);
            this.Pnl_Contenido.Controls.Add(this.btnFamilia);
            this.Pnl_Contenido.Controls.Add(this.btnProducto);
            this.Pnl_Contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_Contenido.Location = new System.Drawing.Point(0, 104);
            this.Pnl_Contenido.Name = "Pnl_Contenido";
            this.Pnl_Contenido.Size = new System.Drawing.Size(732, 367);
            this.Pnl_Contenido.TabIndex = 2;
            this.Pnl_Contenido.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Contenido_Paint);
            // 
            // btnReportes
            // 
            this.btnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReportes.ImageKey = "Reporte.png";
            this.btnReportes.ImageList = this.imageList1;
            this.btnReportes.Location = new System.Drawing.Point(398, 203);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(110, 100);
            this.btnReportes.TabIndex = 7;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnVentas
            // 
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVentas.ImageKey = "Ventas.png";
            this.btnVentas.ImageList = this.imageList1;
            this.btnVentas.Location = new System.Drawing.Point(235, 203);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(110, 100);
            this.btnVentas.TabIndex = 6;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.ImageKey = "Compras.png";
            this.btnCompras.ImageList = this.imageList1;
            this.btnCompras.Location = new System.Drawing.Point(75, 203);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(110, 100);
            this.btnCompras.TabIndex = 5;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCompras.UseVisualStyleBackColor = true;
            // 
            // btnCliente
            // 
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.ImageKey = "Cliente.png";
            this.btnCliente.ImageList = this.imageList1;
            this.btnCliente.Location = new System.Drawing.Point(556, 62);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(110, 100);
            this.btnCliente.TabIndex = 4;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnProveedor
            // 
            this.btnProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedor.ImageKey = "Proveedor.png";
            this.btnProveedor.ImageList = this.imageList1;
            this.btnProveedor.Location = new System.Drawing.Point(398, 62);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Size = new System.Drawing.Size(110, 100);
            this.btnProveedor.TabIndex = 3;
            this.btnProveedor.Text = "Proveedores";
            this.btnProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProveedor.UseVisualStyleBackColor = true;
            // 
            // btnFamilia
            // 
            this.btnFamilia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFamilia.ImageKey = "Familia.png";
            this.btnFamilia.ImageList = this.imageList1;
            this.btnFamilia.Location = new System.Drawing.Point(235, 62);
            this.btnFamilia.Name = "btnFamilia";
            this.btnFamilia.Size = new System.Drawing.Size(110, 100);
            this.btnFamilia.TabIndex = 2;
            this.btnFamilia.Text = "Familia Productos";
            this.btnFamilia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFamilia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFamilia.UseVisualStyleBackColor = true;
            // 
            // btnProducto
            // 
            this.btnProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducto.ImageKey = "Producto.png";
            this.btnProducto.ImageList = this.imageList1;
            this.btnProducto.Location = new System.Drawing.Point(75, 62);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(110, 100);
            this.btnProducto.TabIndex = 1;
            this.btnProducto.Text = "Productos";
            this.btnProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 571);
            this.Controls.Add(this.Pnl_Contenido);
            this.Controls.Add(this.Pnl_Barraestado);
            this.Controls.Add(this.Pnl_Titulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Ventas 1.0";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.panel1.ResumeLayout(false);
            this.Pnl_Titulo.ResumeLayout(false);
            this.Pnl_Titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Pnl_Barraestado.ResumeLayout(false);
            this.Pnl_Barraestado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Pnl_Contenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Pnl_Barraestado;
        private System.Windows.Forms.Panel Pnl_Contenido;
        private System.Windows.Forms.Button btnEmpresa;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnProveedor;
        private System.Windows.Forms.Button btnFamilia;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Label lbLoginus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.FlowLayoutPanel Pnl_Titulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnUsuarios;
    }
}