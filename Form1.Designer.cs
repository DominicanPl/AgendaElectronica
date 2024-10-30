namespace AgendaElectronica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtCorreo = new TextBox();
            txtDireccion = new TextBox();
            txtGenero = new TextBox();
            txtEstadoCivil = new TextBox();
            txtMovil = new TextBox();
            txtTelefono = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            dataGridViewContactos = new DataGridView();
            InsertarContacto = new Button();
            ModificarContacto = new Button();
            BuscarContactos = new Button();
            EliminarContacto = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewContactos).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(643, 27);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(181, 39);
            txtNombre.TabIndex = 15;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(643, 72);
            txtApellido.Multiline = true;
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(181, 37);
            txtApellido.TabIndex = 1;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(643, 330);
            txtCorreo.Multiline = true;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(181, 37);
            txtCorreo.TabIndex = 2;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(643, 115);
            txtDireccion.Multiline = true;
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(181, 37);
            txtDireccion.TabIndex = 3;
            // 
            // txtGenero
            // 
            txtGenero.Location = new Point(643, 158);
            txtGenero.Multiline = true;
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(181, 37);
            txtGenero.TabIndex = 4;
            // 
            // txtEstadoCivil
            // 
            txtEstadoCivil.Location = new Point(643, 201);
            txtEstadoCivil.Multiline = true;
            txtEstadoCivil.Name = "txtEstadoCivil";
            txtEstadoCivil.Size = new Size(181, 37);
            txtEstadoCivil.TabIndex = 5;
            // 
            // txtMovil
            // 
            txtMovil.Location = new Point(643, 244);
            txtMovil.Multiline = true;
            txtMovil.Name = "txtMovil";
            txtMovil.Size = new Size(181, 37);
            txtMovil.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(643, 287);
            txtTelefono.Multiline = true;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(181, 37);
            txtTelefono.TabIndex = 7;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(633, 381);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(200, 23);
            dtpFechaNacimiento.TabIndex = 14;
            // 
            // dataGridViewContactos
            // 
            dataGridViewContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewContactos.Location = new Point(12, 27);
            dataGridViewContactos.Name = "dataGridViewContactos";
            dataGridViewContactos.Size = new Size(625, 291);
            dataGridViewContactos.TabIndex = 9;
            // 
            // InsertarContacto
            // 
            InsertarContacto.Location = new Point(13, 341);
            InsertarContacto.Name = "InsertarContacto";
            InsertarContacto.Size = new Size(149, 63);
            InsertarContacto.TabIndex = 10;
            InsertarContacto.Text = "Nuevo Contacto";
            InsertarContacto.UseVisualStyleBackColor = true;
            InsertarContacto.Click += InsertarContacto_Click;
            // 
            // ModificarContacto
            // 
            ModificarContacto.Location = new Point(168, 341);
            ModificarContacto.Name = "ModificarContacto";
            ModificarContacto.Size = new Size(149, 63);
            ModificarContacto.TabIndex = 11;
            ModificarContacto.Text = "Modificar";
            ModificarContacto.UseVisualStyleBackColor = true;
            ModificarContacto.Click += ModificarContacto_Click;
            // 
            // BuscarContactos
            // 
            BuscarContactos.Location = new Point(323, 341);
            BuscarContactos.Name = "BuscarContactos";
            BuscarContactos.Size = new Size(149, 63);
            BuscarContactos.TabIndex = 12;
            BuscarContactos.Text = "Buscar";
            BuscarContactos.UseVisualStyleBackColor = true;
            BuscarContactos.Click += BuscarContactos_Click;
            // 
            // EliminarContacto
            // 
            EliminarContacto.Location = new Point(478, 341);
            EliminarContacto.Name = "EliminarContacto";
            EliminarContacto.Size = new Size(149, 63);
            EliminarContacto.TabIndex = 13;
            EliminarContacto.Text = "Eliminar";
            EliminarContacto.UseVisualStyleBackColor = true;
            EliminarContacto.Click += EliminarContacto_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 412);
            Controls.Add(EliminarContacto);
            Controls.Add(BuscarContactos);
            Controls.Add(ModificarContacto);
            Controls.Add(InsertarContacto);
            Controls.Add(dataGridViewContactos);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtTelefono);
            Controls.Add(txtMovil);
            Controls.Add(txtEstadoCivil);
            Controls.Add(txtGenero);
            Controls.Add(txtDireccion);
            Controls.Add(txtCorreo);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewContactos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtCorreo;
        private TextBox txtDireccion;
        private TextBox txtGenero;
        private TextBox txtEstadoCivil;
        private TextBox txtMovil;
        private TextBox txtTelefono;
        private DateTimePicker dtpFechaNacimiento;
        private DataGridView dataGridViewContactos;
        private Button InsertarContacto;
        private Button ModificarContacto;
        private Button BuscarContactos;
        private Button EliminarContacto;
    }
}
