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
            ((System.ComponentModel.ISupportInitialize)reservaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reservaBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblReservas
            // 
            lblReservas.AutoSize = true;
            lblReservas.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblReservas.Location = new Point(299, 30);
            lblReservas.Name = "lblReservas";
            lblReservas.Size = new Size(172, 50);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Id, Estado });
            dataGridView1.Location = new Point(127, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(544, 150);
            dataGridView1.TabIndex = 2;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Estado
            // 
            Estado.HeaderText = "estado";
            Estado.Name = "Estado";
            // 
            // FormReservas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(lblReservas);
            Name = "FormReservas";
            Text = "Reservas";
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
    }
}