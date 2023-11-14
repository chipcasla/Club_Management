namespace ClubManagement
{
    partial class formActualizarSocio
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
            txtDNI = new TextBox();
            lblDNI = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtMail = new TextBox();
            lblApellido = new Label();
            lblNombre = new Label();
            lblMail = new Label();
            lblTitle = new Label();
            btnCancelar = new Button();
            btnAcpetar = new Button();
            SuspendLayout();
            // 
            // txtDNI
            // 
            txtDNI.BackColor = SystemColors.InactiveCaption;
            txtDNI.Cursor = Cursors.IBeam;
            txtDNI.Enabled = false;
            txtDNI.Location = new Point(269, 143);
            txtDNI.Margin = new Padding(3, 4, 3, 4);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(298, 27);
            txtDNI.TabIndex = 16;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDNI.Location = new Point(228, 147);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(37, 20);
            lblDNI.TabIndex = 24;
            lblDNI.Text = "DNI";
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(269, 202);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(298, 27);
            txtNombre.TabIndex = 19;
            // 
            // txtApellido
            // 
            txtApellido.Cursor = Cursors.IBeam;
            txtApellido.Location = new Point(269, 265);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(298, 27);
            txtApellido.TabIndex = 20;
            // 
            // txtMail
            // 
            txtMail.Cursor = Cursors.IBeam;
            txtMail.Location = new Point(269, 319);
            txtMail.Margin = new Padding(3, 4, 3, 4);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(298, 27);
            txtMail.TabIndex = 21;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(203, 265);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(67, 20);
            lblApellido.TabIndex = 13;
            lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(201, 206);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 14;
            lblNombre.Text = "Nombre";
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMail.Location = new Point(228, 323);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(39, 20);
            lblMail.TabIndex = 15;
            lblMail.Text = "Mail";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(269, 39);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(298, 50);
            lblTitle.TabIndex = 25;
            lblTitle.Text = "Modificar Socio";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(269, 420);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(96, 44);
            btnCancelar.TabIndex = 26;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAcpetar
            // 
            btnAcpetar.Location = new Point(471, 420);
            btnAcpetar.Name = "btnAcpetar";
            btnAcpetar.Size = new Size(96, 44);
            btnAcpetar.TabIndex = 27;
            btnAcpetar.Text = "Actualizar";
            btnAcpetar.UseVisualStyleBackColor = true;
            btnAcpetar.Click += btnAcpetar_Click;
            // 
            // formActualizarSocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 548);
            Controls.Add(btnAcpetar);
            Controls.Add(btnCancelar);
            Controls.Add(lblTitle);
            Controls.Add(txtDNI);
            Controls.Add(lblDNI);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtMail);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblMail);
            Name = "formActualizarSocio";
            Text = "Modificar Socio";
            Load += formActualizarSocio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDNI;
        private Label lblDNI;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtMail;
        private Label lblApellido;
        private Label lblNombre;
        private Label lblMail;
        private Label lblTitle;
        private Button btnCancelar;
        private Button btnAcpetar;
    }
}