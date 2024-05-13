namespace SisVentas.Presentacion
{
    partial class Frm_Inventario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_Inv = new System.Windows.Forms.Button();
            this.nud_Inv = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dGV_Inv = new System.Windows.Forms.DataGridView();
            this.b_Salir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Inv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Inv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_Inv);
            this.groupBox1.Controls.Add(this.nud_Inv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controles de Inventario";
            // 
            // b_Inv
            // 
            this.b_Inv.Location = new System.Drawing.Point(449, 17);
            this.b_Inv.Name = "b_Inv";
            this.b_Inv.Size = new System.Drawing.Size(120, 23);
            this.b_Inv.TabIndex = 2;
            this.b_Inv.Text = "Cargar Inventario";
            this.b_Inv.UseVisualStyleBackColor = true;
            this.b_Inv.MouseClick += new System.Windows.Forms.MouseEventHandler(this.b_Inv_MouseClick);
            // 
            // nud_Inv
            // 
            this.nud_Inv.Location = new System.Drawing.Point(210, 17);
            this.nud_Inv.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Inv.Name = "nud_Inv";
            this.nud_Inv.Size = new System.Drawing.Size(108, 20);
            this.nud_Inv.TabIndex = 1;
            this.nud_Inv.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos con inventario menor a: ";
            // 
            // dGV_Inv
            // 
            this.dGV_Inv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Inv.Location = new System.Drawing.Point(13, 73);
            this.dGV_Inv.Name = "dGV_Inv";
            this.dGV_Inv.Size = new System.Drawing.Size(575, 332);
            this.dGV_Inv.TabIndex = 1;
            // 
            // b_Salir
            // 
            this.b_Salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Salir.Location = new System.Drawing.Point(497, 415);
            this.b_Salir.Name = "b_Salir";
            this.b_Salir.Size = new System.Drawing.Size(91, 23);
            this.b_Salir.TabIndex = 2;
            this.b_Salir.Text = "Salir";
            this.b_Salir.UseVisualStyleBackColor = true;
            this.b_Salir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.b_Salir_MouseClick);
            // 
            // Frm_Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.ControlBox = false;
            this.Controls.Add(this.b_Salir);
            this.Controls.Add(this.dGV_Inv);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Inventario";
            this.Text = "Frm_Inventario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Inv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Inv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_Inv;
        private System.Windows.Forms.NumericUpDown nud_Inv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGV_Inv;
        private System.Windows.Forms.Button b_Salir;
    }
}