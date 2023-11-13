namespace ClubManagement
{
    partial class FormReservas
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
            lblReservas = new Label();
            reservaBindingSource = new BindingSource(components);
            reservaBindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewLinkColumn();
            instalacion = new DataGridViewTextBoxColumn();
            actividad = new DataGridViewTextBoxColumn();
            btnAtras = new Button();
            txtId = new TextBox();
            lblId = new Label();
            btnCancelar = new Button();
            label1 = new Label();
            btnReservar = new Button();
            ((System.ComponentModel.ISupportInitialize)reservaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reservaBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblReservas
            // 
            lblReservas.AutoSize = true;
            lblReservas.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblReservas.Location = new Point(342, 40);
            lblReservas.Name = "lblReservas";
            lblReservas.Size = new Size(219, 62);
            lblReservas.TabIndex = 1;
            lblReservas.Text = "Reservas";
            // 
            // reservaBindingSource
            // 
            reservaBindingSource.DataSource = typeof(Entidades.Reserva);
            // 
            // reservaBindingSource1
            // 
            reservaBindingSource1.DataSource = typeof(Entidades.Reserva);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Estado, fecha, instalacion, actividad });
            dataGridView1.Location = new Point(125, 115);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(692, 200);
            dataGridView1.TabIndex = 2;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.Width = 125;
            // 
            // fecha
            // 
            fecha.HeaderText = "Fecha";
            fecha.MinimumWidth = 6;
            fecha.Name = "fecha";
            fecha.Width = 125;
            // 
            // instalacion
            // 
            instalacion.HeaderText = "Instalacion";
            instalacion.MinimumWidth = 6;
            instalacion.Name = "instalacion";
            instalacion.Width = 125;
            // 
            // actividad
            // 
            actividad.HeaderText = "Actividad";
            actividad.MinimumWidth = 6;
            actividad.Name = "actividad";
            actividad.Width = 125;
            // 
            // btnAtras
            // 
            btnAtras.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtras.Location = new Point(27, 444);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(118, 46);
            btnAtras.TabIndex = 3;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(598, 365);
            txtId.Name = "txtId";
            txtId.Size = new Size(171, 27);
            txtId.TabIndex = 4;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(519, 368);
            lblId.Name = "lblId";
            lblId.Size = new Size(73, 20);
            lblId.TabIndex = 5;
            lblId.Text = "Id reserva";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(775, 363);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(519, 332);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 7;
            label1.Text = "Cancelar reservas:";
            // 
            // btnReservar
            // 
            btnReservar.Location = new Point(743, 54);
            btnReservar.Name = "btnReservar";
            btnReservar.Size = new Size(126, 48);
            btnReservar.TabIndex = 8;
            btnReservar.Text = "Agregar Reserva";
            btnReservar.UseVisualStyleBackColor = true;
            btnReservar.Click += btnReservar_Click;
            // 
            // FormReservas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnReservar);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(lblId);
            Controls.Add(txtId);
            Controls.Add(btnAtras);
            Controls.Add(dataGridView1);
            Controls.Add(lblReservas);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormReservas";
            Text = "Reservas";
            Load += FormReservas_Load;
            ((System.ComponentModel.ISupportInitialize)reservaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)reservaBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReservas;
        private BindingSource reservaBindingSource;
        private BindingSource reservaBindingSource1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn actividadDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewLinkColumn fecha;
        private Button btnAtras;
        private DataGridViewTextBoxColumn instalacion;
        private DataGridViewTextBoxColumn actividad;
        private TextBox txtId;
        private Label lblId;
        private Button btnCancelar;
        private Label label1;
        private Button btnReservar;
    }
}