namespace SisVentas.Presentacion
{
    partial class Frm_Proveedores
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTareas = new System.Windows.Forms.Panel();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.btnEstadoProv = new System.Windows.Forms.Button();
            this.btnActualizarProv = new System.Windows.Forms.Button();
            this.btnNuevoProv = new System.Windows.Forms.Button();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbProveedores = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTrabajo = new System.Windows.Forms.Panel();
            this.txtDireccionProv = new System.Windows.Forms.TextBox();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.txtBusquedaProv = new System.Windows.Forms.TextBox();
            this.lbBusqueda = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarProv = new System.Windows.Forms.Button();
            this.btnCancelarProv = new System.Windows.Forms.Button();
            this.txtNombreProv = new System.Windows.Forms.TextBox();
            this.lbNombreus = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lbTel_Prov = new System.Windows.Forms.Label();
            this.pnlTareas.SuspendLayout();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTrabajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTareas
            // 
            this.pnlTareas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(232)))));
            this.pnlTareas.Controls.Add(this.btnMenuPrincipal);
            this.pnlTareas.Controls.Add(this.btnEstadoProv);
            this.pnlTareas.Controls.Add(this.btnActualizarProv);
            this.pnlTareas.Controls.Add(this.btnNuevoProv);
            this.pnlTareas.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTareas.Location = new System.Drawing.Point(666, 0);
            this.pnlTareas.Name = "pnlTareas";
            this.pnlTareas.Size = new System.Drawing.Size(200, 521);
            this.pnlTareas.TabIndex = 1;
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnMenuPrincipal.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuPrincipal.Location = new System.Drawing.Point(26, 433);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(162, 56);
            this.btnMenuPrincipal.TabIndex = 3;
            this.btnMenuPrincipal.Text = "Menu Principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = false;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // btnEstadoProv
            // 
            this.btnEstadoProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEstadoProv.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnEstadoProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadoProv.Location = new System.Drawing.Point(26, 252);
            this.btnEstadoProv.Name = "btnEstadoProv";
            this.btnEstadoProv.Size = new System.Drawing.Size(162, 56);
            this.btnEstadoProv.TabIndex = 2;
            this.btnEstadoProv.Text = "Estado Proveedor";
            this.btnEstadoProv.UseVisualStyleBackColor = false;
            this.btnEstadoProv.Click += new System.EventHandler(this.btnEstadoProv_Click);
            // 
            // btnActualizarProv
            // 
            this.btnActualizarProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnActualizarProv.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProv.Location = new System.Drawing.Point(26, 155);
            this.btnActualizarProv.Name = "btnActualizarProv";
            this.btnActualizarProv.Size = new System.Drawing.Size(162, 56);
            this.btnActualizarProv.TabIndex = 1;
            this.btnActualizarProv.Text = "Actualizar Proveedor";
            this.btnActualizarProv.UseVisualStyleBackColor = false;
            this.btnActualizarProv.Click += new System.EventHandler(this.btnActualizarProv_Click);
            // 
            // btnNuevoProv
            // 
            this.btnNuevoProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnNuevoProv.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnNuevoProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoProv.Location = new System.Drawing.Point(26, 56);
            this.btnNuevoProv.Name = "btnNuevoProv";
            this.btnNuevoProv.Size = new System.Drawing.Size(162, 56);
            this.btnNuevoProv.TabIndex = 0;
            this.btnNuevoProv.Text = "Agregar Proveedor";
            this.btnNuevoProv.UseVisualStyleBackColor = false;
            this.btnNuevoProv.Click += new System.EventHandler(this.btnNuevoProv_Click);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(232)))));
            this.pnlTitulo.Controls.Add(this.label2);
            this.pnlTitulo.Controls.Add(this.lbProveedores);
            this.pnlTitulo.Controls.Add(this.pictureBox1);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(666, 100);
            this.pnlTitulo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sistema de Ventas 1.0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbProveedores
            // 
            this.lbProveedores.AutoSize = true;
            this.lbProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProveedores.Location = new System.Drawing.Point(157, 56);
            this.lbProveedores.Name = "lbProveedores";
            this.lbProveedores.Size = new System.Drawing.Size(179, 31);
            this.lbProveedores.TabIndex = 1;
            this.lbProveedores.Text = "Proveedores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SisVentas.Properties.Resources.Proveedor_01;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlTrabajo
            // 
            this.pnlTrabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(216)))), ((int)(((byte)(232)))));
            this.pnlTrabajo.Controls.Add(this.txtDireccionProv);
            this.pnlTrabajo.Controls.Add(this.lbDireccion);
            this.pnlTrabajo.Controls.Add(this.btnBusqueda);
            this.pnlTrabajo.Controls.Add(this.dgvListado);
            this.pnlTrabajo.Controls.Add(this.txtBusquedaProv);
            this.pnlTrabajo.Controls.Add(this.lbBusqueda);
            this.pnlTrabajo.Controls.Add(this.label3);
            this.pnlTrabajo.Controls.Add(this.label1);
            this.pnlTrabajo.Controls.Add(this.btnGuardarProv);
            this.pnlTrabajo.Controls.Add(this.btnCancelarProv);
            this.pnlTrabajo.Controls.Add(this.txtNombreProv);
            this.pnlTrabajo.Controls.Add(this.lbNombreus);
            this.pnlTrabajo.Controls.Add(this.txtTelefono);
            this.pnlTrabajo.Controls.Add(this.lbTel_Prov);
            this.pnlTrabajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTrabajo.Location = new System.Drawing.Point(0, 100);
            this.pnlTrabajo.Name = "pnlTrabajo";
            this.pnlTrabajo.Size = new System.Drawing.Size(666, 421);
            this.pnlTrabajo.TabIndex = 3;
            // 
            // txtDireccionProv
            // 
            this.txtDireccionProv.Location = new System.Drawing.Point(25, 74);
            this.txtDireccionProv.MaxLength = 100;
            this.txtDireccionProv.Name = "txtDireccionProv";
            this.txtDireccionProv.Size = new System.Drawing.Size(373, 20);
            this.txtDireccionProv.TabIndex = 24;
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(22, 58);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(52, 13);
            this.lbDireccion.TabIndex = 23;
            this.lbDireccion.Text = "Direccion";
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(152)))), ((int)(((byte)(232)))));
            this.btnBusqueda.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.Location = new System.Drawing.Point(407, 272);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(118, 38);
            this.btnBusqueda.TabIndex = 21;
            this.btnBusqueda.Text = "Busqueda";
            this.btnBusqueda.UseVisualStyleBackColor = false;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeight = 40;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListado.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvListado.EnableHeadersVisualStyles = false;
            this.dgvListado.Location = new System.Drawing.Point(25, 321);
            this.dgvListado.Name = "dgvListado";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvListado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListado.Size = new System.Drawing.Size(602, 115);
            this.dgvListado.TabIndex = 20;
            this.dgvListado.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellEnter);
            // 
            // txtBusquedaProv
            // 
            this.txtBusquedaProv.Location = new System.Drawing.Point(88, 284);
            this.txtBusquedaProv.MaxLength = 20;
            this.txtBusquedaProv.Name = "txtBusquedaProv";
            this.txtBusquedaProv.Size = new System.Drawing.Size(313, 20);
            this.txtBusquedaProv.TabIndex = 19;
            // 
            // lbBusqueda
            // 
            this.lbBusqueda.AutoSize = true;
            this.lbBusqueda.Location = new System.Drawing.Point(22, 287);
            this.lbBusqueda.Name = "lbBusqueda";
            this.lbBusqueda.Size = new System.Drawing.Size(55, 13);
            this.lbBusqueda.TabIndex = 18;
            this.lbBusqueda.Text = "Busqueda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(9, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "*";
            // 
            // btnGuardarProv
            // 
            this.btnGuardarProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(235)))), ((int)(((byte)(58)))));
            this.btnGuardarProv.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProv.ForeColor = System.Drawing.Color.Snow;
            this.btnGuardarProv.Location = new System.Drawing.Point(342, 200);
            this.btnGuardarProv.Name = "btnGuardarProv";
            this.btnGuardarProv.Size = new System.Drawing.Size(162, 42);
            this.btnGuardarProv.TabIndex = 13;
            this.btnGuardarProv.Text = "Guardar";
            this.btnGuardarProv.UseVisualStyleBackColor = false;
            this.btnGuardarProv.Visible = false;
            this.btnGuardarProv.Click += new System.EventHandler(this.btnGuardarProv_Click);
            // 
            // btnCancelarProv
            // 
            this.btnCancelarProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(46)))), ((int)(((byte)(41)))));
            this.btnCancelarProv.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnCancelarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProv.ForeColor = System.Drawing.Color.Snow;
            this.btnCancelarProv.Location = new System.Drawing.Point(131, 200);
            this.btnCancelarProv.Name = "btnCancelarProv";
            this.btnCancelarProv.Size = new System.Drawing.Size(162, 42);
            this.btnCancelarProv.TabIndex = 12;
            this.btnCancelarProv.Text = "Cancelar";
            this.btnCancelarProv.UseVisualStyleBackColor = false;
            this.btnCancelarProv.Visible = false;
            this.btnCancelarProv.Click += new System.EventHandler(this.btnCancelarProv_Click);
            // 
            // txtNombreProv
            // 
            this.txtNombreProv.Location = new System.Drawing.Point(25, 31);
            this.txtNombreProv.MaxLength = 45;
            this.txtNombreProv.Name = "txtNombreProv";
            this.txtNombreProv.Size = new System.Drawing.Size(373, 20);
            this.txtNombreProv.TabIndex = 9;
            // 
            // lbNombreus
            // 
            this.lbNombreus.AutoSize = true;
            this.lbNombreus.Location = new System.Drawing.Point(22, 15);
            this.lbNombreus.Name = "lbNombreus";
            this.lbNombreus.Size = new System.Drawing.Size(44, 13);
            this.lbNombreus.TabIndex = 8;
            this.lbNombreus.Text = "Nombre";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(25, 117);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(121, 20);
            this.txtTelefono.TabIndex = 5;
            // 
            // lbTel_Prov
            // 
            this.lbTel_Prov.AutoSize = true;
            this.lbTel_Prov.Location = new System.Drawing.Point(22, 101);
            this.lbTel_Prov.Name = "lbTel_Prov";
            this.lbTel_Prov.Size = new System.Drawing.Size(49, 13);
            this.lbTel_Prov.TabIndex = 4;
            this.lbTel_Prov.Text = "Telefono";
            // 
            // Frm_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 521);
            this.Controls.Add(this.pnlTrabajo);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pnlTareas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Proveedores";
            this.Load += new System.EventHandler(this.Frm_Proveedores_Load);
            this.pnlTareas.ResumeLayout(false);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTrabajo.ResumeLayout(false);
            this.pnlTrabajo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTareas;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Button btnEstadoProv;
        private System.Windows.Forms.Button btnActualizarProv;
        private System.Windows.Forms.Button btnNuevoProv;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbProveedores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlTrabajo;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.TextBox txtBusquedaProv;
        private System.Windows.Forms.Label lbBusqueda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardarProv;
        private System.Windows.Forms.Button btnCancelarProv;
        private System.Windows.Forms.TextBox txtNombreProv;
        private System.Windows.Forms.Label lbNombreus;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lbTel_Prov;
        private System.Windows.Forms.TextBox txtDireccionProv;
        private System.Windows.Forms.Label lbDireccion;
    }
}
