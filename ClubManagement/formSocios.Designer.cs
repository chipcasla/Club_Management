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
            label1 = new Label();
            dataSocios = new DataGridView();
            personaBindingSource = new BindingSource(components);
            socioBindingSource = new BindingSource(components);
            cuotaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataSocios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)socioBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(328, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 32);
            label1.TabIndex = 0;
            label1.Text = "Socios";
            // 
            // dataSocios
            // 
            dataSocios.AllowUserToOrderColumns = true;
            dataSocios.AutoGenerateColumns = false;
            dataSocios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSocios.Columns.AddRange(new DataGridViewColumn[] { cuotaDataGridViewTextBoxColumn });
            dataSocios.DataSource = socioBindingSource;
            dataSocios.Location = new Point(119, 63);
            dataSocios.Name = "dataSocios";
            dataSocios.RowTemplate.Height = 25;
            dataSocios.Size = new Size(525, 150);
            dataSocios.TabIndex = 1;
            // 
            // personaBindingSource
            // 
            personaBindingSource.DataSource = typeof(Entidades.Persona);
            // 
            // socioBindingSource
            // 
            socioBindingSource.DataSource = typeof(Entidades.Socio);
            // 
            // cuotaDataGridViewTextBoxColumn
            // 
            cuotaDataGridViewTextBoxColumn.DataPropertyName = "Cuota";
            cuotaDataGridViewTextBoxColumn.HeaderText = "Cuota";
            cuotaDataGridViewTextBoxColumn.Name = "cuotaDataGridViewTextBoxColumn";
            // 
            // formSocios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataSocios);
            Controls.Add(label1);
            Name = "formSocios";
            Text = "formSocios";
            Load += formSocios_Load;
            ((System.ComponentModel.ISupportInitialize)dataSocios).EndInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)socioBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataSocios;
        private DataGridViewTextBoxColumn cuotaDataGridViewTextBoxColumn;
        private BindingSource socioBindingSource;
        private BindingSource personaBindingSource;
    }
}