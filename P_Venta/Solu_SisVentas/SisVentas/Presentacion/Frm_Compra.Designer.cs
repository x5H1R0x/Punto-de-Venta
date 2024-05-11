namespace SisVentas.Presentacion
{
    partial class Frm_Compra
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
            this.dGV_Pedido = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_Inventario = new System.Windows.Forms.ComboBox();
            this.b_buscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.b_Agregar = new System.Windows.Forms.Button();
            this.tBox_precio = new System.Windows.Forms.TextBox();
            this.nud_cant = new System.Windows.Forms.NumericUpDown();
            this.tBox_desc = new System.Windows.Forms.TextBox();
            this.tBox_id = new System.Windows.Forms.TextBox();
            this.tBox_codigo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b_regCompra = new System.Windows.Forms.Button();
            this.tBox_total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.b_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Pedido)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cant)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV_Pedido
            // 
            this.dGV_Pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Pedido.Location = new System.Drawing.Point(13, 13);
            this.dGV_Pedido.Name = "dGV_Pedido";
            this.dGV_Pedido.Size = new System.Drawing.Size(492, 425);
            this.dGV_Pedido.TabIndex = 0;
            this.dGV_Pedido.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGV_Pedido_RowHeaderMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmb_Inventario);
            this.groupBox1.Controls.Add(this.b_buscar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.b_Agregar);
            this.groupBox1.Controls.Add(this.tBox_precio);
            this.groupBox1.Controls.Add(this.nud_cant);
            this.groupBox1.Controls.Add(this.tBox_desc);
            this.groupBox1.Controls.Add(this.tBox_id);
            this.groupBox1.Controls.Add(this.tBox_codigo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(512, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 264);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product Controls";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 213);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Proveedor";
            // 
            // cmb_Inventario
            // 
            this.cmb_Inventario.FormattingEnabled = true;
            this.cmb_Inventario.Location = new System.Drawing.Point(7, 232);
            this.cmb_Inventario.Name = "cmb_Inventario";
            this.cmb_Inventario.Size = new System.Drawing.Size(121, 21);
            this.cmb_Inventario.TabIndex = 12;
            this.cmb_Inventario.SelectedIndexChanged += new System.EventHandler(this.cmb_Inventario_SelectedIndexChanged);
            // 
            // b_buscar
            // 
            this.b_buscar.Location = new System.Drawing.Point(195, 29);
            this.b_buscar.Name = "b_buscar";
            this.b_buscar.Size = new System.Drawing.Size(75, 23);
            this.b_buscar.TabIndex = 11;
            this.b_buscar.Text = "Buscar";
            this.b_buscar.UseVisualStyleBackColor = true;
            this.b_buscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.b_buscar_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio Unitario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id del producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo producto";
            // 
            // b_Agregar
            // 
            this.b_Agregar.Location = new System.Drawing.Point(173, 232);
            this.b_Agregar.Name = "b_Agregar";
            this.b_Agregar.Size = new System.Drawing.Size(99, 23);
            this.b_Agregar.TabIndex = 5;
            this.b_Agregar.Text = "Agregar";
            this.b_Agregar.UseVisualStyleBackColor = true;
            this.b_Agregar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.b_Agregar_MouseClick);
            // 
            // tBox_precio
            // 
            this.tBox_precio.Location = new System.Drawing.Point(149, 182);
            this.tBox_precio.Name = "tBox_precio";
            this.tBox_precio.ReadOnly = true;
            this.tBox_precio.Size = new System.Drawing.Size(112, 20);
            this.tBox_precio.TabIndex = 4;
            // 
            // nud_cant
            // 
            this.nud_cant.Location = new System.Drawing.Point(9, 182);
            this.nud_cant.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_cant.Name = "nud_cant";
            this.nud_cant.Size = new System.Drawing.Size(76, 20);
            this.nud_cant.TabIndex = 3;
            this.nud_cant.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tBox_desc
            // 
            this.tBox_desc.Location = new System.Drawing.Point(9, 129);
            this.tBox_desc.Name = "tBox_desc";
            this.tBox_desc.ReadOnly = true;
            this.tBox_desc.Size = new System.Drawing.Size(263, 20);
            this.tBox_desc.TabIndex = 2;
            // 
            // tBox_id
            // 
            this.tBox_id.Location = new System.Drawing.Point(9, 81);
            this.tBox_id.Name = "tBox_id";
            this.tBox_id.ReadOnly = true;
            this.tBox_id.Size = new System.Drawing.Size(155, 20);
            this.tBox_id.TabIndex = 1;
            // 
            // tBox_codigo
            // 
            this.tBox_codigo.Location = new System.Drawing.Point(6, 32);
            this.tBox_codigo.Name = "tBox_codigo";
            this.tBox_codigo.Size = new System.Drawing.Size(155, 20);
            this.tBox_codigo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_regCompra);
            this.groupBox2.Controls.Add(this.tBox_total);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(512, 283);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(276, 106);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compra";
            // 
            // b_regCompra
            // 
            this.b_regCompra.Location = new System.Drawing.Point(149, 77);
            this.b_regCompra.Name = "b_regCompra";
            this.b_regCompra.Size = new System.Drawing.Size(123, 23);
            this.b_regCompra.TabIndex = 2;
            this.b_regCompra.Text = "Registrar compra";
            this.b_regCompra.UseVisualStyleBackColor = true;
            this.b_regCompra.MouseClick += new System.Windows.Forms.MouseEventHandler(this.b_regCompra_MouseClick);
            // 
            // tBox_total
            // 
            this.tBox_total.Location = new System.Drawing.Point(7, 36);
            this.tBox_total.Name = "tBox_total";
            this.tBox_total.ReadOnly = true;
            this.tBox_total.Size = new System.Drawing.Size(143, 20);
            this.tBox_total.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total";
            // 
            // b_Salir
            // 
            this.b_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Salir.Location = new System.Drawing.Point(713, 415);
            this.b_Salir.Name = "b_Salir";
            this.b_Salir.Size = new System.Drawing.Size(75, 23);
            this.b_Salir.TabIndex = 3;
            this.b_Salir.Text = "Salir";
            this.b_Salir.UseVisualStyleBackColor = true;
            this.b_Salir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.b_Salir_MouseClick);
            // 
            // Frm_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.b_Salir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dGV_Pedido);
            this.Name = "Frm_Compra";
            this.Text = "Frm_Compra";
            this.Load += new System.EventHandler(this.Frm_Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Pedido)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_cant)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Pedido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBox_id;
        private System.Windows.Forms.TextBox tBox_codigo;
        private System.Windows.Forms.TextBox tBox_desc;
        private System.Windows.Forms.NumericUpDown nud_cant;
        private System.Windows.Forms.Button b_Agregar;
        private System.Windows.Forms.TextBox tBox_precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_buscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tBox_total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_regCompra;
        private System.Windows.Forms.Button b_Salir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_Inventario;
    }
}