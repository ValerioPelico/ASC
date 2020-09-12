namespace ModuloVista
{
    partial class frmFacturacion
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
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cmbNumero = new System.Windows.Forms.ComboBox();
            this.dgvFacturacion = new System.Windows.Forms.DataGridView();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Rockwell", 10F);
            this.txtCliente.Location = new System.Drawing.Point(271, 65);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(97, 27);
            this.txtCliente.TabIndex = 0;
            this.txtCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbCliente
            // 
            this.cmbCliente.Font = new System.Drawing.Font("Rockwell", 10F);
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(165, 63);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(72, 28);
            this.cmbCliente.TabIndex = 1;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Rockwell", 10F);
            this.lblCliente.Location = new System.Drawing.Point(35, 63);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(80, 20);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "CLIENTE";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Rockwell", 10F);
            this.lblNumero.Location = new System.Drawing.Point(35, 13);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(83, 20);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "NUMERO";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Rockwell", 10F);
            this.lblProducto.Location = new System.Drawing.Point(35, 111);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(104, 20);
            this.lblProducto.TabIndex = 6;
            this.lblProducto.Text = "PRODUCTO";
            this.lblProducto.Click += new System.EventHandler(this.label3_Click);
            // 
            // cmbProducto
            // 
            this.cmbProducto.Font = new System.Drawing.Font("Rockwell", 10F);
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(165, 111);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(72, 28);
            this.cmbProducto.TabIndex = 5;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Rockwell", 10F);
            this.txtProducto.Location = new System.Drawing.Point(271, 113);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(97, 27);
            this.txtProducto.TabIndex = 4;
            this.txtProducto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Rockwell", 10F);
            this.lblCantidad.Location = new System.Drawing.Point(35, 157);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(97, 20);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "CANTIDAD";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Rockwell", 10F);
            this.txtCantidad.Location = new System.Drawing.Point(165, 157);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(203, 27);
            this.txtCantidad.TabIndex = 8;
            // 
            // btnCliente
            // 
            this.btnCliente.Font = new System.Drawing.Font("Rockwell", 10F);
            this.btnCliente.Location = new System.Drawing.Point(392, 65);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(41, 23);
            this.btnCliente.TabIndex = 9;
            this.btnCliente.Text = "...";
            this.btnCliente.UseVisualStyleBackColor = true;
            // 
            // btnProducto
            // 
            this.btnProducto.Font = new System.Drawing.Font("Rockwell", 10F);
            this.btnProducto.Location = new System.Drawing.Point(392, 113);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(41, 23);
            this.btnProducto.TabIndex = 10;
            this.btnProducto.Text = "...";
            this.btnProducto.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.btnAgregar.Location = new System.Drawing.Point(462, 150);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(157, 30);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.btnEliminar.Location = new System.Drawing.Point(666, 153);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(161, 30);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // cmbNumero
            // 
            this.cmbNumero.Font = new System.Drawing.Font("Rockwell", 10F);
            this.cmbNumero.FormattingEnabled = true;
            this.cmbNumero.Location = new System.Drawing.Point(165, 10);
            this.cmbNumero.Name = "cmbNumero";
            this.cmbNumero.Size = new System.Drawing.Size(203, 28);
            this.cmbNumero.TabIndex = 13;
            // 
            // dgvFacturacion
            // 
            this.dgvFacturacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturacion.Location = new System.Drawing.Point(12, 203);
            this.dgvFacturacion.Name = "dgvFacturacion";
            this.dgvFacturacion.RowHeadersWidth = 51;
            this.dgvFacturacion.RowTemplate.Height = 24;
            this.dgvFacturacion.Size = new System.Drawing.Size(679, 252);
            this.dgvFacturacion.TabIndex = 14;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Font = new System.Drawing.Font("Rockwell", 10F);
            this.btnFacturar.Location = new System.Drawing.Point(462, 82);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(161, 32);
            this.btnFacturar.TabIndex = 15;
            this.btnFacturar.Text = "FACTURAR";
            this.btnFacturar.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Rockwell", 10F);
            this.btnImprimir.Location = new System.Drawing.Point(666, 82);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(161, 32);
            this.btnImprimir.TabIndex = 16;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(733, 226);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(97, 27);
            this.textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(736, 296);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(97, 27);
            this.textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(736, 355);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(97, 27);
            this.textBox6.TabIndex = 19;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(736, 414);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(97, 27);
            this.textBox7.TabIndex = 20;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(733, 203);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(113, 20);
            this.lblDescuento.TabIndex = 21;
            this.lblDescuento.Text = "DESCUENTO";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(733, 273);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(38, 20);
            this.lblIva.TabIndex = 22;
            this.lblIva.Text = "IVA";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(733, 332);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(95, 20);
            this.lblSubtotal.TabIndex = 23;
            this.lblSubtotal.Text = "SUBTOTAL";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(733, 391);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(64, 20);
            this.lblTotal.TabIndex = 24;
            this.lblTotal.Text = "TOTAL";
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(932, 503);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.dgvFacturacion);
            this.Controls.Add(this.cmbNumero);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.txtCliente);
            this.Name = "frmFacturacion";
            this.Text = "Facturacion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cmbNumero;
        private System.Windows.Forms.DataGridView dgvFacturacion;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblTotal;
    }
}