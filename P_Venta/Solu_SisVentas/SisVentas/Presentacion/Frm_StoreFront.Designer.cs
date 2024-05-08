namespace SisVentas.Presentacion
{
    partial class Frm_StoreFront
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
            this.dataGridView_venta = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_buscar = new System.Windows.Forms.Button();
            this.button_AddtoList = new System.Windows.Forms.Button();
            this.tBox_precio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numUD_cantidad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tBox_desc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBox_Codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Cerrar_venta = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tBox_SaleTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBox_Id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_venta)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_cantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_venta
            // 
            this.dataGridView_venta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_venta.Location = new System.Drawing.Point(13, 12);
            this.dataGridView_venta.Name = "dataGridView_venta";
            this.dataGridView_venta.Size = new System.Drawing.Size(492, 426);
            this.dataGridView_venta.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBox_Id);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button_buscar);
            this.groupBox1.Controls.Add(this.button_AddtoList);
            this.groupBox1.Controls.Add(this.tBox_precio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numUD_cantidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tBox_desc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tBox_Codigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(511, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 269);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Product controls";
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(193, 80);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(75, 23);
            this.button_buscar.TabIndex = 9;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // button_AddtoList
            // 
            this.button_AddtoList.Location = new System.Drawing.Point(193, 226);
            this.button_AddtoList.Name = "button_AddtoList";
            this.button_AddtoList.Size = new System.Drawing.Size(75, 23);
            this.button_AddtoList.TabIndex = 8;
            this.button_AddtoList.Text = "Agregar";
            this.button_AddtoList.UseVisualStyleBackColor = true;
            this.button_AddtoList.Click += new System.EventHandler(this.button_AddtoList_Click);
            // 
            // tBox_precio
            // 
            this.tBox_precio.Enabled = false;
            this.tBox_precio.Location = new System.Drawing.Point(156, 173);
            this.tBox_precio.Name = "tBox_precio";
            this.tBox_precio.ReadOnly = true;
            this.tBox_precio.Size = new System.Drawing.Size(100, 20);
            this.tBox_precio.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio Unitario";
            // 
            // numUD_cantidad
            // 
            this.numUD_cantidad.DecimalPlaces = 2;
            this.numUD_cantidad.Location = new System.Drawing.Point(10, 173);
            this.numUD_cantidad.Name = "numUD_cantidad";
            this.numUD_cantidad.Size = new System.Drawing.Size(80, 20);
            this.numUD_cantidad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad";
            // 
            // tBox_desc
            // 
            this.tBox_desc.Location = new System.Drawing.Point(7, 124);
            this.tBox_desc.Name = "tBox_desc";
            this.tBox_desc.ReadOnly = true;
            this.tBox_desc.Size = new System.Drawing.Size(261, 20);
            this.tBox_desc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // tBox_Codigo
            // 
            this.tBox_Codigo.Location = new System.Drawing.Point(7, 80);
            this.tBox_Codigo.Name = "tBox_Codigo";
            this.tBox_Codigo.Size = new System.Drawing.Size(171, 20);
            this.tBox_Codigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo producto";
            // 
            // button_Exit
            // 
            this.button_Exit.Location = new System.Drawing.Point(713, 415);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 9;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Cerrar_venta);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tBox_SaleTotal);
            this.groupBox2.Location = new System.Drawing.Point(511, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Venta";
            // 
            // button_Cerrar_venta
            // 
            this.button_Cerrar_venta.Location = new System.Drawing.Point(196, 69);
            this.button_Cerrar_venta.Name = "button_Cerrar_venta";
            this.button_Cerrar_venta.Size = new System.Drawing.Size(75, 23);
            this.button_Cerrar_venta.TabIndex = 2;
            this.button_Cerrar_venta.Text = "Cerrar venta";
            this.button_Cerrar_venta.UseVisualStyleBackColor = true;
            this.button_Cerrar_venta.Click += new System.EventHandler(this.button_Cerrar_venta_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total";
            // 
            // tBox_SaleTotal
            // 
            this.tBox_SaleTotal.Enabled = false;
            this.tBox_SaleTotal.Location = new System.Drawing.Point(7, 36);
            this.tBox_SaleTotal.Name = "tBox_SaleTotal";
            this.tBox_SaleTotal.Size = new System.Drawing.Size(264, 20);
            this.tBox_SaleTotal.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Id Producto";
            // 
            // tBox_Id
            // 
            this.tBox_Id.Location = new System.Drawing.Point(6, 36);
            this.tBox_Id.Name = "tBox_Id";
            this.tBox_Id.ReadOnly = true;
            this.tBox_Id.Size = new System.Drawing.Size(172, 20);
            this.tBox_Id.TabIndex = 11;
            // 
            // Frm_StoreFront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_venta);
            this.Name = "Frm_StoreFront";
            this.Text = "Frm_StoreFront";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_venta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_cantidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_venta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBox_desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBox_Codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUD_cantidad;
        private System.Windows.Forms.Button button_AddtoList;
        private System.Windows.Forms.TextBox tBox_precio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tBox_SaleTotal;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.Button button_Cerrar_venta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBox_Id;
        private System.Windows.Forms.Label label6;
    }
}