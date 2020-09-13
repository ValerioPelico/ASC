namespace ModuloVista
{
    partial class frmVenta
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
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblIdEmpleado = new System.Windows.Forms.Label();
            this.lblIdVenta = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.Consultar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgdMostrar = new System.Windows.Forms.DataGridView();
            this.cbxIdVenta = new System.Windows.Forms.ComboBox();
            this.cbxFecha = new System.Windows.Forms.ComboBox();
            this.cbxIdCliente = new System.Windows.Forms.ComboBox();
            this.cbxIDProducto = new System.Windows.Forms.ComboBox();
            this.cbxIdEmpleado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgdMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.Location = new System.Drawing.Point(257, 9);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(113, 17);
            this.lblSubtitulo.TabIndex = 0;
            this.lblSubtitulo.Text = "Ingresar Venta";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCliente.Location = new System.Drawing.Point(187, 123);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(85, 16);
            this.lblIdCliente.TabIndex = 1;
            this.lblIdCliente.Text = "Id del Cliente";
            this.lblIdCliente.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.AutoSize = true;
            this.lblIdProducto.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProducto.Location = new System.Drawing.Point(187, 150);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(97, 16);
            this.lblIdProducto.TabIndex = 2;
            this.lblIdProducto.Text = "Id del producto";
            this.lblIdProducto.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(187, 184);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(43, 16);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // lblIdEmpleado
            // 
            this.lblIdEmpleado.AutoSize = true;
            this.lblIdEmpleado.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdEmpleado.Location = new System.Drawing.Point(187, 214);
            this.lblIdEmpleado.Name = "lblIdEmpleado";
            this.lblIdEmpleado.Size = new System.Drawing.Size(95, 16);
            this.lblIdEmpleado.TabIndex = 4;
            this.lblIdEmpleado.Text = "Id del emplado";
            this.lblIdEmpleado.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblIdVenta
            // 
            this.lblIdVenta.AutoSize = true;
            this.lblIdVenta.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdVenta.Location = new System.Drawing.Point(187, 88);
            this.lblIdVenta.Name = "lblIdVenta";
            this.lblIdVenta.Size = new System.Drawing.Size(55, 16);
            this.lblIdVenta.TabIndex = 5;
            this.lblIdVenta.Text = "Id venta";
            this.lblIdVenta.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertar.Location = new System.Drawing.Point(515, 88);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 23);
            this.btnInsertar.TabIndex = 6;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(515, 190);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // Consultar
            // 
            this.Consultar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultar.Location = new System.Drawing.Point(515, 161);
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(75, 23);
            this.Consultar.TabIndex = 8;
            this.Consultar.Text = "Buscar";
            this.Consultar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(515, 123);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // dgdMostrar
            // 
            this.dgdMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdMostrar.Location = new System.Drawing.Point(152, 244);
            this.dgdMostrar.Name = "dgdMostrar";
            this.dgdMostrar.Size = new System.Drawing.Size(473, 174);
            this.dgdMostrar.TabIndex = 10;
            // 
            // cbxIdVenta
            // 
            this.cbxIdVenta.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIdVenta.FormattingEnabled = true;
            this.cbxIdVenta.Location = new System.Drawing.Point(327, 84);
            this.cbxIdVenta.Name = "cbxIdVenta";
            this.cbxIdVenta.Size = new System.Drawing.Size(121, 24);
            this.cbxIdVenta.TabIndex = 17;
            // 
            // cbxFecha
            // 
            this.cbxFecha.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFecha.FormattingEnabled = true;
            this.cbxFecha.Location = new System.Drawing.Point(327, 184);
            this.cbxFecha.Name = "cbxFecha";
            this.cbxFecha.Size = new System.Drawing.Size(121, 24);
            this.cbxFecha.TabIndex = 18;
            // 
            // cbxIdCliente
            // 
            this.cbxIdCliente.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIdCliente.FormattingEnabled = true;
            this.cbxIdCliente.Location = new System.Drawing.Point(327, 117);
            this.cbxIdCliente.Name = "cbxIdCliente";
            this.cbxIdCliente.Size = new System.Drawing.Size(121, 24);
            this.cbxIdCliente.TabIndex = 19;
            // 
            // cbxIDProducto
            // 
            this.cbxIDProducto.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIDProducto.FormattingEnabled = true;
            this.cbxIDProducto.Location = new System.Drawing.Point(327, 147);
            this.cbxIDProducto.Name = "cbxIDProducto";
            this.cbxIDProducto.Size = new System.Drawing.Size(121, 24);
            this.cbxIDProducto.TabIndex = 20;
            // 
            // cbxIdEmpleado
            // 
            this.cbxIdEmpleado.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIdEmpleado.FormattingEnabled = true;
            this.cbxIdEmpleado.Location = new System.Drawing.Point(327, 214);
            this.cbxIdEmpleado.Name = "cbxIdEmpleado";
            this.cbxIdEmpleado.Size = new System.Drawing.Size(121, 24);
            this.cbxIdEmpleado.TabIndex = 21;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.cbxIdEmpleado);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblIdEmpleado);
            this.Controls.Add(this.lblIdVenta);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cbxIdVenta);
            this.Controls.Add(this.lblIdProducto);
            this.Controls.Add(this.cbxFecha);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.cbxIdCliente);
            this.Controls.Add(this.cbxIDProducto);
            this.Controls.Add(this.dgdMostrar);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.Consultar);
            this.Name = "frmVenta";
            this.Text = "frmVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dgdMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblIdEmpleado;
        private System.Windows.Forms.Label lblIdVenta;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button Consultar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgdMostrar;
        private System.Windows.Forms.ComboBox cbxIdVenta;
        private System.Windows.Forms.ComboBox cbxFecha;
        private System.Windows.Forms.ComboBox cbxIdCliente;
        private System.Windows.Forms.ComboBox cbxIDProducto;
        private System.Windows.Forms.ComboBox cbxIdEmpleado;
    }
}