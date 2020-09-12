namespace ModuloVista
{
    partial class frmMenuVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuVentas));
            this.pbxCliente = new System.Windows.Forms.PictureBox();
            this.pbxFactura = new System.Windows.Forms.PictureBox();
            this.pbxProducto = new System.Windows.Forms.PictureBox();
            this.pbxVenta = new System.Windows.Forms.PictureBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxCliente
            // 
            this.pbxCliente.Image = ((System.Drawing.Image)(resources.GetObject("pbxCliente.Image")));
            this.pbxCliente.Location = new System.Drawing.Point(163, 75);
            this.pbxCliente.Name = "pbxCliente";
            this.pbxCliente.Size = new System.Drawing.Size(152, 137);
            this.pbxCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCliente.TabIndex = 0;
            this.pbxCliente.TabStop = false;
            // 
            // pbxFactura
            // 
            this.pbxFactura.Image = ((System.Drawing.Image)(resources.GetObject("pbxFactura.Image")));
            this.pbxFactura.Location = new System.Drawing.Point(589, 88);
            this.pbxFactura.Name = "pbxFactura";
            this.pbxFactura.Size = new System.Drawing.Size(152, 137);
            this.pbxFactura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFactura.TabIndex = 1;
            this.pbxFactura.TabStop = false;
            // 
            // pbxProducto
            // 
            this.pbxProducto.Image = ((System.Drawing.Image)(resources.GetObject("pbxProducto.Image")));
            this.pbxProducto.Location = new System.Drawing.Point(163, 310);
            this.pbxProducto.Name = "pbxProducto";
            this.pbxProducto.Size = new System.Drawing.Size(152, 137);
            this.pbxProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProducto.TabIndex = 2;
            this.pbxProducto.TabStop = false;
            // 
            // pbxVenta
            // 
            this.pbxVenta.Image = ((System.Drawing.Image)(resources.GetObject("pbxVenta.Image")));
            this.pbxVenta.Location = new System.Drawing.Point(589, 310);
            this.pbxVenta.Name = "pbxVenta";
            this.pbxVenta.Size = new System.Drawing.Size(152, 137);
            this.pbxVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxVenta.TabIndex = 3;
            this.pbxVenta.TabStop = false;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Rockwell", 11F);
            this.lblNumero.Location = new System.Drawing.Point(160, 43);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(89, 21);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "CLIENTE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11F);
            this.label1.Location = new System.Drawing.Point(586, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "FACTURA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 11F);
            this.label2.Location = new System.Drawing.Point(160, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "PRODUCTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 11F);
            this.label3.Location = new System.Drawing.Point(589, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "VENTAS";
            // 
            // frmMenuVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(932, 503);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.pbxVenta);
            this.Controls.Add(this.pbxProducto);
            this.Controls.Add(this.pbxFactura);
            this.Controls.Add(this.pbxCliente);
            this.Name = "frmMenuVentas";
            this.Text = "Menu Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.pbxCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxCliente;
        private System.Windows.Forms.PictureBox pbxFactura;
        private System.Windows.Forms.PictureBox pbxProducto;
        private System.Windows.Forms.PictureBox pbxVenta;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}