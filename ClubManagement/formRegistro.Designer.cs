namespace ClubManagement
{
    partial class formRegistro
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
        private void InitializeComponent()
        {
            lblMail = new Label();
            lblPass = new Label();
            lblConfPass = new Label();
            lblTitle = new Label();
            txtMail = new TextBox();
            txtPass = new TextBox();
            txtRepitePass = new TextBox();
            lblIngreso = new Label();
            lnkIngresar = new LinkLabel();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblNombre = new Label();
            lblApellido = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            lblValidar = new Label();
            txtDNI = new TextBox();
            lblDNI = new Label();
            SuspendLayout();
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblMail.Location = new Point(138, 223);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(30, 15);
            lblMail.TabIndex = 0;
            lblMail.Text = "Mail";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPass.Location = new Point(99, 273);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(69, 15);
            lblPass.TabIndex = 1;
            lblPass.Text = "Contraseña";
            // 
            // lblConfPass
            // 
            lblConfPass.AutoSize = true;
            lblConfPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblConfPass.Location = new Point(46, 320);
            lblConfPass.Name = "lblConfPass";
            lblConfPass.Size = new Size(122, 15);
            lblConfPass.TabIndex = 2;
            lblConfPass.Text = "Confirma contraseña";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(201, 21);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(170, 40);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Registrarse";
            // 
            // txtMail
            // 
            txtMail.Cursor = Cursors.IBeam;
            txtMail.Location = new Point(174, 220);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(261, 23);
            txtMail.TabIndex = 4;
            txtMail.Leave += txtMail_Leave;
            // 
            // txtPass
            // 
            txtPass.Cursor = Cursors.IBeam;
            txtPass.Location = new Point(174, 270);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(261, 23);
            txtPass.TabIndex = 5;
            txtPass.TextChanged += txtPass_TextChanged;
            txtPass.Leave += txtPass_Leave;
            // 
            // txtRepitePass
            // 
            txtRepitePass.BackColor = SystemColors.Window;
            txtRepitePass.BorderStyle = BorderStyle.FixedSingle;
            txtRepitePass.Cursor = Cursors.IBeam;
            txtRepitePass.Location = new Point(174, 317);
            txtRepitePass.Name = "txtRepitePass";
            txtRepitePass.PasswordChar = '*';
            txtRepitePass.Size = new Size(261, 23);
            txtRepitePass.TabIndex = 6;
            txtRepitePass.TextChanged += txtRepitePass_TextChanged;
            txtRepitePass.Leave += txtRepitePass_Leave;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(12, 450);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(97, 15);
            lblIngreso.TabIndex = 7;
            lblIngreso.Text = "¿Ya tiene cuenta?";
            // 
            // lnkIngresar
            // 
            lnkIngresar.AutoSize = true;
            lnkIngresar.Cursor = Cursors.Hand;
            lnkIngresar.Location = new Point(119, 450);
            lnkIngresar.Name = "lnkIngresar";
            lnkIngresar.Size = new Size(49, 15);
            lnkIngresar.TabIndex = 8;
            lnkIngresar.TabStop = true;
            lnkIngresar.Text = "Ingresar";
            lnkIngresar.LinkClicked += lnkIngresar_LinkClicked;
            // 
            // btnAceptar
            // 
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.Enabled = false;
            btnAceptar.Location = new Point(333, 402);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(102, 23);
            btnAceptar.TabIndex = 9;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(174, 402);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(104, 23);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(115, 135);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(53, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(116, 179);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(52, 15);
            lblApellido.TabIndex = 0;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Cursor = Cursors.IBeam;
            txtNombre.Location = new Point(174, 132);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(261, 23);
            txtNombre.TabIndex = 4;
            txtNombre.Leave += txtNombre_Leave;
            // 
            // txtApellido
            // 
            txtApellido.Cursor = Cursors.IBeam;
            txtApellido.Location = new Point(174, 179);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(261, 23);
            txtApellido.TabIndex = 4;
            txtApellido.Leave += txtApellido_Leave;
            // 
            // lblValidar
            // 
            lblValidar.AutoSize = true;
            lblValidar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblValidar.Location = new Point(174, 361);
            lblValidar.Name = "lblValidar";
            lblValidar.Size = new Size(72, 20);
            lblValidar.TabIndex = 11;
            lblValidar.Text = "validador";
            lblValidar.Visible = false;
            // 
            // txtDNI
            // 
            txtDNI.Cursor = Cursors.IBeam;
            txtDNI.Location = new Point(174, 88);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(261, 23);
            txtDNI.TabIndex = 1;
            txtDNI.Leave += txtDNI_Leave;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDNI.Location = new Point(138, 91);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(29, 15);
            lblDNI.TabIndex = 12;
            lblDNI.Text = "DNI";
            // 
            // formRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 487);
            Controls.Add(txtDNI);
            Controls.Add(lblDNI);
            Controls.Add(lblValidar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lnkIngresar);
            Controls.Add(lblIngreso);
            Controls.Add(txtRepitePass);
            Controls.Add(txtPass);
            Controls.Add(txtNombre);
            Controls.Add(txtApellido);
            Controls.Add(txtMail);
            Controls.Add(lblTitle);
            Controls.Add(lblConfPass);
            Controls.Add(lblPass);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblMail);
            Name = "formRegistro";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMail;
        private Label lblPass;
        private Label lblConfPass;
        private Label lblTitle;
        private TextBox txtMail;
        private TextBox txtPass;
        private TextBox txtRepitePass;
        private Label lblIngreso;
        private LinkLabel lnkIngresar;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Label lblValidar;
        private TextBox txtDNI;
        private Label lblDNI;
    }
}