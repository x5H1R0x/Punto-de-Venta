namespace SisVentas.Presentacion
{
    partial class Frm_Familias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFamiliaPr = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTrabajo = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDescripcionPr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbFamiProdu = new System.Windows.Forms.ComboBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.txtBusquedaPr = new System.Windows.Forms.TextBox();
            this.lbBusqueda = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardarProdu = new System.Windows.Forms.Button();
            this.btnCancelarProdu = new System.Windows.Forms.Button();
            this.lbFamiliaProd = new System.Windows.Forms.Label();
            this.txtNombreProdu = new System.Windows.Forms.TextBox();
            this.lbNombreus = new System.Windows.Forms.Label();
            this.pnlTareas = new System.Windows.Forms.Panel();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            this.btnEstadoProd = new System.Windows.Forms.Button();
            this.btnActualizarProd = new System.Windows.Forms.Button();
            this.btnAgregarProd = new System.Windows.Forms.Button();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTrabajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.pnlTareas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(232)))));
            this.pnlTitulo.Controls.Add(this.label2);
            this.pnlTitulo.Controls.Add(this.lbFamiliaPr);
            this.pnlTitulo.Controls.Add(this.pictureBox1);
            this.pnlTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(922, 100);
            this.pnlTitulo.TabIndex = 10;
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
            // lbFamiliaPr
            // 
            this.lbFamiliaPr.AutoSize = true;
            this.lbFamiliaPr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFamiliaPr.Location = new System.Drawing.Point(159, 56);
            this.lbFamiliaPr.Name = "lbFamiliaPr";
            this.lbFamiliaPr.Size = new System.Drawing.Size(248, 31);
            this.lbFamiliaPr.TabIndex = 1;
            this.lbFamiliaPr.Text = "Familia Productos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SisVentas.Properties.Resources.Producto;
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
            this.pnlTrabajo.Controls.Add(this.label5);
            this.pnlTrabajo.Controls.Add(this.txtDescripcionPr);
            this.pnlTrabajo.Controls.Add(this.label6);
            this.pnlTrabajo.Controls.Add(this.cmbFamiProdu);
            this.pnlTrabajo.Controls.Add(this.btnBusqueda);
            this.pnlTrabajo.Controls.Add(this.dgvListado);
            this.pnlTrabajo.Controls.Add(this.txtBusquedaPr);
            this.pnlTrabajo.Controls.Add(this.lbBusqueda);
            this.pnlTrabajo.Controls.Add(this.label4);
            this.pnlTrabajo.Controls.Add(this.label3);
            this.pnlTrabajo.Controls.Add(this.btnGuardarProdu);
            this.pnlTrabajo.Controls.Add(this.btnCancelarProdu);
            this.pnlTrabajo.Controls.Add(this.lbFamiliaProd);
            this.pnlTrabajo.Controls.Add(this.txtNombreProdu);
            this.pnlTrabajo.Controls.Add(this.lbNombreus);
            this.pnlTrabajo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTrabajo.Location = new System.Drawing.Point(0, 100);
            this.pnlTrabajo.Name = "pnlTrabajo";
            this.pnlTrabajo.Size = new System.Drawing.Size(922, 389);
            this.pnlTrabajo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(20, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "*";
            // 
            // txtDescripcionPr
            // 
            this.txtDescripcionPr.Location = new System.Drawing.Point(40, 91);
            this.txtDescripcionPr.MaxLength = 100;
            this.txtDescripcionPr.Name = "txtDescripcionPr";
            this.txtDescripcionPr.Size = new System.Drawing.Size(216, 20);
            this.txtDescripcionPr.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Descripcion";
            // 
            // cmbFamiProdu
            // 
            this.cmbFamiProdu.FormattingEnabled = true;
            this.cmbFamiProdu.Location = new System.Drawing.Point(40, 151);
            this.cmbFamiProdu.Name = "cmbFamiProdu";
            this.cmbFamiProdu.Size = new System.Drawing.Size(121, 21);
            this.cmbFamiProdu.TabIndex = 22;
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
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeight = 40;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListado.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListado.EnableHeadersVisualStyles = false;
            this.dgvListado.Location = new System.Drawing.Point(25, 321);
            this.dgvListado.Name = "dgvListado";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvListado.Size = new System.Drawing.Size(602, 115);
            this.dgvListado.TabIndex = 20;
            // 
            // txtBusquedaPr
            // 
            this.txtBusquedaPr.Location = new System.Drawing.Point(88, 284);
            this.txtBusquedaPr.MaxLength = 20;
            this.txtBusquedaPr.Name = "txtBusquedaPr";
            this.txtBusquedaPr.Size = new System.Drawing.Size(313, 20);
            this.txtBusquedaPr.TabIndex = 19;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(22, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(20, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "*";
            // 
            // btnGuardarProdu
            // 
            this.btnGuardarProdu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(235)))), ((int)(((byte)(58)))));
            this.btnGuardarProdu.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnGuardarProdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProdu.ForeColor = System.Drawing.Color.Snow;
            this.btnGuardarProdu.Location = new System.Drawing.Point(342, 200);
            this.btnGuardarProdu.Name = "btnGuardarProdu";
            this.btnGuardarProdu.Size = new System.Drawing.Size(162, 42);
            this.btnGuardarProdu.TabIndex = 13;
            this.btnGuardarProdu.Text = "Guardar";
            this.btnGuardarProdu.UseVisualStyleBackColor = false;
            this.btnGuardarProdu.Visible = false;
            // 
            // btnCancelarProdu
            // 
            this.btnCancelarProdu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(46)))), ((int)(((byte)(41)))));
            this.btnCancelarProdu.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnCancelarProdu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarProdu.ForeColor = System.Drawing.Color.Snow;
            this.btnCancelarProdu.Location = new System.Drawing.Point(131, 200);
            this.btnCancelarProdu.Name = "btnCancelarProdu";
            this.btnCancelarProdu.Size = new System.Drawing.Size(162, 42);
            this.btnCancelarProdu.TabIndex = 12;
            this.btnCancelarProdu.Text = "Cancelar";
            this.btnCancelarProdu.UseVisualStyleBackColor = false;
            this.btnCancelarProdu.Visible = false;
            // 
            // lbFamiliaProd
            // 
            this.lbFamiliaProd.AutoSize = true;
            this.lbFamiliaProd.Location = new System.Drawing.Point(40, 135);
            this.lbFamiliaProd.Name = "lbFamiliaProd";
            this.lbFamiliaProd.Size = new System.Drawing.Size(85, 13);
            this.lbFamiliaProd.TabIndex = 10;
            this.lbFamiliaProd.Text = "Familia Producto";
            // 
            // txtNombreProdu
            // 
            this.txtNombreProdu.Location = new System.Drawing.Point(40, 36);
            this.txtNombreProdu.MaxLength = 100;
            this.txtNombreProdu.Name = "txtNombreProdu";
            this.txtNombreProdu.Size = new System.Drawing.Size(216, 20);
            this.txtNombreProdu.TabIndex = 9;
            // 
            // lbNombreus
            // 
            this.lbNombreus.AutoSize = true;
            this.lbNombreus.Location = new System.Drawing.Point(37, 20);
            this.lbNombreus.Name = "lbNombreus";
            this.lbNombreus.Size = new System.Drawing.Size(44, 13);
            this.lbNombreus.TabIndex = 8;
            this.lbNombreus.Text = "Nombre";
            // 
            // pnlTareas
            // 
            this.pnlTareas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(232)))));
            this.pnlTareas.Controls.Add(this.btnMenuPrincipal);
            this.pnlTareas.Controls.Add(this.btnEstadoProd);
            this.pnlTareas.Controls.Add(this.btnActualizarProd);
            this.pnlTareas.Controls.Add(this.btnAgregarProd);
            this.pnlTareas.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTareas.Location = new System.Drawing.Point(722, 100);
            this.pnlTareas.Name = "pnlTareas";
            this.pnlTareas.Size = new System.Drawing.Size(200, 389);
            this.pnlTareas.TabIndex = 12;
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
            // 
            // btnEstadoProd
            // 
            this.btnEstadoProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEstadoProd.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnEstadoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstadoProd.Location = new System.Drawing.Point(26, 251);
            this.btnEstadoProd.Name = "btnEstadoProd";
            this.btnEstadoProd.Size = new System.Drawing.Size(162, 56);
            this.btnEstadoProd.TabIndex = 2;
            this.btnEstadoProd.Text = "Estado Producto";
            this.btnEstadoProd.UseVisualStyleBackColor = false;
            // 
            // btnActualizarProd
            // 
            this.btnActualizarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnActualizarProd.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarProd.Location = new System.Drawing.Point(26, 155);
            this.btnActualizarProd.Name = "btnActualizarProd";
            this.btnActualizarProd.Size = new System.Drawing.Size(162, 56);
            this.btnActualizarProd.TabIndex = 1;
            this.btnActualizarProd.Text = "Actualizar Producto";
            this.btnActualizarProd.UseVisualStyleBackColor = false;
            // 
            // btnAgregarProd
            // 
            this.btnAgregarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAgregarProd.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgregarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProd.Location = new System.Drawing.Point(26, 56);
            this.btnAgregarProd.Name = "btnAgregarProd";
            this.btnAgregarProd.Size = new System.Drawing.Size(162, 56);
            this.btnAgregarProd.TabIndex = 0;
            this.btnAgregarProd.Text = "Agregar Producto";
            this.btnAgregarProd.UseVisualStyleBackColor = false;
            // 
            // Frm_Familias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 489);
            this.Controls.Add(this.pnlTareas);
            this.Controls.Add(this.pnlTrabajo);
            this.Controls.Add(this.pnlTitulo);
            this.Name = "Frm_Familias";
            this.Text = "Frm_Familias";
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTrabajo.ResumeLayout(false);
            this.pnlTrabajo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.pnlTareas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFamiliaPr;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlTrabajo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescripcionPr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbFamiProdu;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.TextBox txtBusquedaPr;
        private System.Windows.Forms.Label lbBusqueda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardarProdu;
        private System.Windows.Forms.Button btnCancelarProdu;
        private System.Windows.Forms.Label lbFamiliaProd;
        private System.Windows.Forms.TextBox txtNombreProdu;
        private System.Windows.Forms.Label lbNombreus;
        private System.Windows.Forms.Panel pnlTareas;
        private System.Windows.Forms.Button btnMenuPrincipal;
        private System.Windows.Forms.Button btnEstadoProd;
        private System.Windows.Forms.Button btnActualizarProd;
        private System.Windows.Forms.Button btnAgregarProd;
    }
}