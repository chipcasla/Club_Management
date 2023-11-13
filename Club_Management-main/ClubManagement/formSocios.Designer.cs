namespace ClubManagement
{
    partial class formSocios
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
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            dataSocios = new DataGridView();
            Dni = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            CuotasAsignadas = new DataGridViewTextBoxColumn();
            Debe = new DataGridViewTextBoxColumn();
            Monto = new DataGridViewTextBoxColumn();
            personaBindingSource1 = new BindingSource(components);
            personaBindingSource = new BindingSource(components);
            btnAtras = new Button();
            txtDni = new TextBox();
            btnActualiza = new Button();
            btnEliminar = new Button();
            lblDni = new Label();
            ((System.ComponentModel.ISupportInitialize)dataSocios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(456, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(107, 41);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Socios";
            // 
            // dataSocios
            // 
            dataSocios.AllowUserToOrderColumns = true;
            dataSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSocios.Columns.AddRange(new DataGridViewColumn[] { Dni, Nombre, Apellido, Email, CuotasAsignadas, Debe, Monto });
            dataSocios.Location = new Point(46, 57);
            dataSocios.Margin = new Padding(3, 4, 3, 4);
            dataSocios.Name = "dataSocios";
            dataSocios.RowHeadersWidth = 51;
            dataSocios.RowTemplate.Height = 25;
            dataSocios.Size = new Size(944, 312);
            dataSocios.TabIndex = 1;
            // 
            // Dni
            // 
            Dni.HeaderText = "Dni";
            Dni.MinimumWidth = 6;
            Dni.Name = "Dni";
            Dni.Width = 125;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 125;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.Width = 125;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // CuotasAsignadas
            // 
            CuotasAsignadas.HeaderText = "Cuotas Asignadas";
            CuotasAsignadas.MinimumWidth = 6;
            CuotasAsignadas.Name = "CuotasAsignadas";
            CuotasAsignadas.Width = 125;
            // 
            // Debe
            // 
            Debe.HeaderText = "Debe";
            Debe.MinimumWidth = 6;
            Debe.Name = "Debe";
            Debe.Width = 125;
            // 
            // Monto
            // 
            Monto.HeaderText = "Monto Deuda";
            Monto.MinimumWidth = 6;
            Monto.Name = "Monto";
            Monto.Width = 125;
            // 
            // personaBindingSource1
            // 
            personaBindingSource1.DataSource = typeof(Entidades.Persona);
            // 
            // personaBindingSource
            // 
            personaBindingSource.DataSource = typeof(Entidades.Persona);
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(46, 395);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(95, 40);
            btnAtras.TabIndex = 2;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(616, 403);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(155, 27);
            txtDni.TabIndex = 3;
            // 
            // btnActualiza
            // 
            btnActualiza.Location = new Point(792, 402);
            btnActualiza.Name = "btnActualiza";
            btnActualiza.Size = new Size(94, 29);
            btnActualiza.TabIndex = 4;
            btnActualiza.Text = "Actualizar";
            btnActualiza.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(896, 401);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(525, 406);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(85, 20);
            lblDni.TabIndex = 6;
            lblDni.Text = "Ingrese dni:";
            // 
            // formSocios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 600);
            Controls.Add(lblDni);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualiza);
            Controls.Add(txtDni);
            Controls.Add(btnAtras);
            Controls.Add(dataSocios);
            Controls.Add(lblTitulo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "formSocios";
            Text = "formSocios";
            Load += formSocios_Load;
            ((System.ComponentModel.ISupportInitialize)dataSocios).EndInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dataSocios;
        private BindingSource personaBindingSource;
        private BindingSource personaBindingSource1;
        private Button btnAtras;
        private TextBox txtDni;
        private Button btnActualiza;
        private Button btnEliminar;
        private Label lblDni;
        private DataGridViewTextBoxColumn Dni;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn CuotasAsignadas;
        private DataGridViewTextBoxColumn Debe;
        private DataGridViewTextBoxColumn Monto;
    }
}