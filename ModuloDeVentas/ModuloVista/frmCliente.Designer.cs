namespace ModuloVista
{
    partial class frmCliente
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
            this.dgdMostrar = new System.Windows.Forms.DataGridView();
            this.btlBuscar = new System.Windows.Forms.Button();
            this.btlModificar = new System.Windows.Forms.Button();
            this.btlEliminar = new System.Windows.Forms.Button();
            this.btlGuardar = new System.Windows.Forms.Button();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cbxIdCliente = new System.Windows.Forms.ComboBox();
            this.cbxNombre = new System.Windows.Forms.ComboBox();
            this.cbxApellido = new System.Windows.Forms.ComboBox();
            this.cbxFechaNacimiento = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgdMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgdMostrar
            // 
            this.dgdMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdMostrar.Location = new System.Drawing.Point(152, 291);
            this.dgdMostrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgdMostrar.Name = "dgdMostrar";
            this.dgdMostrar.Size = new System.Drawing.Size(610, 186);
            this.dgdMostrar.TabIndex = 9;
            // 
            // btlBuscar
            // 
            this.btlBuscar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlBuscar.Location = new System.Drawing.Point(646, 255);
            this.btlBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btlBuscar.Name = "btlBuscar";
            this.btlBuscar.Size = new System.Drawing.Size(87, 28);
            this.btlBuscar.TabIndex = 8;
            this.btlBuscar.Text = "Buscar";
            this.btlBuscar.UseVisualStyleBackColor = true;
            // 
            // btlModificar
            // 
            this.btlModificar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlModificar.Location = new System.Drawing.Point(646, 201);
            this.btlModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btlModificar.Name = "btlModificar";
            this.btlModificar.Size = new System.Drawing.Size(87, 28);
            this.btlModificar.TabIndex = 7;
            this.btlModificar.Text = "Modificar";
            this.btlModificar.UseVisualStyleBackColor = true;
            // 
            // btlEliminar
            // 
            this.btlEliminar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlEliminar.Location = new System.Drawing.Point(646, 147);
            this.btlEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btlEliminar.Name = "btlEliminar";
            this.btlEliminar.Size = new System.Drawing.Size(87, 28);
            this.btlEliminar.TabIndex = 6;
            this.btlEliminar.Text = "Eliminar";
            this.btlEliminar.UseVisualStyleBackColor = true;
            // 
            // btlGuardar
            // 
            this.btlGuardar.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlGuardar.Location = new System.Drawing.Point(646, 90);
            this.btlGuardar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btlGuardar.Name = "btlGuardar";
            this.btlGuardar.Size = new System.Drawing.Size(87, 28);
            this.btlGuardar.TabIndex = 5;
            this.btlGuardar.Text = "Guardar";
            this.btlGuardar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.Location = new System.Drawing.Point(372, 40);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(145, 17);
            this.lblTitulo1.TabIndex = 0;
            this.lblTitulo1.Text = "Ingreso de clientes";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(182, 94);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Id cliente";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(182, 151);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(55, 16);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(180, 201);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(56, 16);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(182, 255);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(127, 16);
            this.lblFecha.TabIndex = 4;
            this.lblFecha.Text = "Fecha de nacimiento";
            // 
            // cbxIdCliente
            // 
            this.cbxIdCliente.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxIdCliente.FormattingEnabled = true;
            this.cbxIdCliente.Location = new System.Drawing.Point(375, 94);
            this.cbxIdCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxIdCliente.Name = "cbxIdCliente";
            this.cbxIdCliente.Size = new System.Drawing.Size(140, 24);
            this.cbxIdCliente.TabIndex = 10;
            // 
            // cbxNombre
            // 
            this.cbxNombre.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNombre.FormattingEnabled = true;
            this.cbxNombre.Location = new System.Drawing.Point(375, 143);
            this.cbxNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxNombre.Name = "cbxNombre";
            this.cbxNombre.Size = new System.Drawing.Size(140, 24);
            this.cbxNombre.TabIndex = 11;
            // 
            // cbxApellido
            // 
            this.cbxApellido.Font = new System.Drawing.Font("Rockwell", 10F);
            this.cbxApellido.FormattingEnabled = true;
            this.cbxApellido.Location = new System.Drawing.Point(375, 195);
            this.cbxApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxApellido.Name = "cbxApellido";
            this.cbxApellido.Size = new System.Drawing.Size(140, 24);
            this.cbxApellido.TabIndex = 12;
            // 
            // cbxFechaNacimiento
            // 
            this.cbxFechaNacimiento.FormattingEnabled = true;
            this.cbxFechaNacimiento.Location = new System.Drawing.Point(375, 249);
            this.cbxFechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxFechaNacimiento.Name = "cbxFechaNacimiento";
            this.cbxFechaNacimiento.Size = new System.Drawing.Size(140, 24);
            this.cbxFechaNacimiento.TabIndex = 13;
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.cbxFechaNacimiento);
            this.Controls.Add(this.cbxApellido);
            this.Controls.Add(this.cbxNombre);
            this.Controls.Add(this.cbxIdCliente);
            this.Controls.Add(this.dgdMostrar);
            this.Controls.Add(this.btlGuardar);
            this.Controls.Add(this.lblTitulo1);
            this.Controls.Add(this.btlBuscar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btlModificar);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btlEliminar);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblFecha);
            this.Font = new System.Drawing.Font("Rockwell", 10F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCliente";
            this.Text = "frmCliente";
            this.Load += new System.EventHandler(this.frmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgdMostrar;
        private System.Windows.Forms.Button btlBuscar;
        private System.Windows.Forms.Button btlModificar;
        private System.Windows.Forms.Button btlEliminar;
        private System.Windows.Forms.Button btlGuardar;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cbxIdCliente;
        private System.Windows.Forms.ComboBox cbxNombre;
        private System.Windows.Forms.ComboBox cbxApellido;
        private System.Windows.Forms.ComboBox cbxFechaNacimiento;
    }
}