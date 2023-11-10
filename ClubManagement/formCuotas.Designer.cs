namespace ClubManagement
{
    partial class FormCuotas
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
            reservaBindingSource = new BindingSource(components);
            dataGridViewCuotas = new DataGridView();
            mes = new DataGridViewTextBoxColumn();
            anio = new DataGridViewTextBoxColumn();
            monto = new DataGridViewTextBoxColumn();
            pago = new DataGridViewTextBoxColumn();
            cuotaBindingSource2 = new BindingSource(components);
            cuotaBindingSource1 = new BindingSource(components);
            cuotaBindingSource = new BindingSource(components);
            lblDeuda = new Label();
            lblMontoDeuda = new Label();
            btnAtras = new Button();
            lblCuotas = new Label();
            cbAnio = new ComboBox();
            lblFiltro = new Label();
            ((System.ComponentModel.ISupportInitialize)reservaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCuotas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cuotaBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cuotaBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cuotaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // reservaBindingSource
            // 
            reservaBindingSource.DataSource = typeof(Entidades.Reserva);
            // 
            // dataGridViewCuotas
            // 
            dataGridViewCuotas.AllowUserToOrderColumns = true;
            dataGridViewCuotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCuotas.Columns.AddRange(new DataGridViewColumn[] { mes, anio, monto, pago });
            dataGridViewCuotas.Location = new Point(98, 74);
            dataGridViewCuotas.Name = "dataGridViewCuotas";
            dataGridViewCuotas.ReadOnly = true;
            dataGridViewCuotas.RowHeadersWidth = 51;
            dataGridViewCuotas.RowTemplate.Height = 29;
            dataGridViewCuotas.Size = new Size(555, 260);
            dataGridViewCuotas.TabIndex = 0;
            dataGridViewCuotas.CellContentClick += dataGridView1_CellContentClick;
            // 
            // mes
            // 
            mes.HeaderText = "Mes";
            mes.MinimumWidth = 6;
            mes.Name = "mes";
            mes.ReadOnly = true;
            mes.Width = 125;
            // 
            // anio
            // 
            anio.HeaderText = "Año";
            anio.MinimumWidth = 6;
            anio.Name = "anio";
            anio.ReadOnly = true;
            anio.Width = 125;
            // 
            // monto
            // 
            monto.HeaderText = "Monto";
            monto.MinimumWidth = 6;
            monto.Name = "monto";
            monto.ReadOnly = true;
            monto.Width = 125;
            // 
            // pago
            // 
            pago.HeaderText = "Pago";
            pago.MinimumWidth = 6;
            pago.Name = "pago";
            pago.ReadOnly = true;
            pago.Width = 125;
            // 
            // cuotaBindingSource2
            // 
            cuotaBindingSource2.DataSource = typeof(Entidades.Cuota);
            // 
            // cuotaBindingSource1
            // 
            cuotaBindingSource1.DataSource = typeof(Entidades.Cuota);
            // 
            // cuotaBindingSource
            // 
            cuotaBindingSource.DataSource = typeof(Entidades.Cuota);
            // 
            // lblDeuda
            // 
            lblDeuda.AutoSize = true;
            lblDeuda.Location = new Point(77, 365);
            lblDeuda.Name = "lblDeuda";
            lblDeuda.Size = new Size(146, 20);
            lblDeuda.TabIndex = 1;
            lblDeuda.Text = "Monto total a pagar:";
            // 
            // lblMontoDeuda
            // 
            lblMontoDeuda.AutoSize = true;
            lblMontoDeuda.Location = new Point(220, 365);
            lblMontoDeuda.Name = "lblMontoDeuda";
            lblMontoDeuda.Size = new Size(53, 20);
            lblMontoDeuda.TabIndex = 2;
            lblMontoDeuda.Text = "monto";
            lblMontoDeuda.Visible = false;
            lblMontoDeuda.Click += lblMontoDeuda_Click;
            // 
            // btnAtras
            // 
            btnAtras.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtras.Location = new Point(12, 395);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(104, 43);
            btnAtras.TabIndex = 3;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCuotas.Location = new Point(292, 0);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(177, 62);
            lblCuotas.TabIndex = 4;
            lblCuotas.Text = "Cuotas";
            // 
            // cbAnio
            // 
            cbAnio.FormattingEnabled = true;
            cbAnio.Items.AddRange(new object[] { "2023", "2022", "2021", "2020" });
            cbAnio.Location = new Point(618, 357);
            cbAnio.Name = "cbAnio";
            cbAnio.Size = new Size(151, 28);
            cbAnio.TabIndex = 5;
            cbAnio.SelectedIndexChanged += cbAnio_SelectedIndexChanged;
            cbAnio.Click += cbAnio_Click;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(506, 360);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(106, 20);
            lblFiltro.TabIndex = 6;
            lblFiltro.Text = "Filtrar por año:";
            // 
            // FormCuotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblFiltro);
            Controls.Add(cbAnio);
            Controls.Add(lblCuotas);
            Controls.Add(btnAtras);
            Controls.Add(lblMontoDeuda);
            Controls.Add(lblDeuda);
            Controls.Add(dataGridViewCuotas);
            Name = "FormCuotas";
            Text = "Cuotas";
            ((System.ComponentModel.ISupportInitialize)reservaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCuotas).EndInit();
            ((System.ComponentModel.ISupportInitialize)cuotaBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)cuotaBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cuotaBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource reservaBindingSource;
        private DataGridView dataGridViewCuotas;
        private BindingSource cuotaBindingSource;
        private BindingSource cuotaBindingSource1;
        private Label lblDeuda;
        private Label lblMontoDeuda;
        private Button btnAtras;
        private Label lblCuotas;
        private ComboBox cbAnio;
        private BindingSource cuotaBindingSource2;
        private DataGridViewTextBoxColumn mes;
        private DataGridViewTextBoxColumn anio;
        private DataGridViewTextBoxColumn monto;
        private DataGridViewTextBoxColumn pago;
        private Label lblFiltro;
    }
}