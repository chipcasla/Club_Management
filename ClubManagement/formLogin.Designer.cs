namespace ClubManagement
{
    partial class formLogin
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
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblTitle = new Label();
            lblDNI = new Label();
            lblPass = new Label();
            txtDNI = new TextBox();
            txtPass = new TextBox();
            lnkRegistro = new LinkLabel();
            lblRegistro = new Label();
            lblValidar = new Label();
            lnkOlvidaPass = new LinkLabel();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.Location = new Point(340, 218);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(96, 23);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(142, 218);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(97, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(168, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(238, 47);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Iniciar Sesión";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDNI.Location = new Point(158, 93);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(29, 15);
            lblDNI.TabIndex = 3;
            lblDNI.Text = "DNI";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPass.Location = new Point(118, 137);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(69, 15);
            lblPass.TabIndex = 4;
            lblPass.Text = "Contraseña";
            // 
            // txtDNI
            // 
            txtDNI.Cursor = Cursors.IBeam;
            txtDNI.Location = new Point(196, 90);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(240, 23);
            txtDNI.TabIndex = 6;
            // 
            // txtPass
            // 
            txtPass.Cursor = Cursors.IBeam;
            txtPass.Location = new Point(196, 134);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(240, 23);
            txtPass.TabIndex = 7;
            // 
            // lnkRegistro
            // 
            lnkRegistro.AutoSize = true;
            lnkRegistro.Cursor = Cursors.Hand;
            lnkRegistro.Location = new Point(142, 267);
            lnkRegistro.Name = "lnkRegistro";
            lnkRegistro.Size = new Size(59, 15);
            lnkRegistro.TabIndex = 8;
            lnkRegistro.TabStop = true;
            lnkRegistro.Text = "Registrate";
            lnkRegistro.LinkClicked += lnkRegistro_LinkClicked;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Location = new Point(12, 267);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(124, 15);
            lblRegistro.TabIndex = 9;
            lblRegistro.Text = "¿Aun no tiene cuenta?";
            // 
            // lblValidar
            // 
            lblValidar.AutoSize = true;
            lblValidar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblValidar.Location = new Point(261, 176);
            lblValidar.Name = "lblValidar";
            lblValidar.Size = new Size(50, 15);
            lblValidar.TabIndex = 10;
            lblValidar.Text = "textoVal";
            lblValidar.Visible = false;
            // 
            // lnkOlvidaPass
            // 
            lnkOlvidaPass.AutoSize = true;
            lnkOlvidaPass.Cursor = Cursors.Hand;
            lnkOlvidaPass.Location = new Point(12, 292);
            lnkOlvidaPass.Name = "lnkOlvidaPass";
            lnkOlvidaPass.Size = new Size(131, 15);
            lnkOlvidaPass.TabIndex = 5;
            lnkOlvidaPass.TabStop = true;
            lnkOlvidaPass.Text = "Olvidaste tu contraseña";
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 316);
            Controls.Add(lblValidar);
            Controls.Add(lblRegistro);
            Controls.Add(lnkRegistro);
            Controls.Add(txtPass);
            Controls.Add(txtDNI);
            Controls.Add(lnkOlvidaPass);
            Controls.Add(lblPass);
            Controls.Add(lblDNI);
            Controls.Add(lblTitle);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Name = "formLogin";
            Text = "Inicio de Sesión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblTitle;
        private Label lblDNI;
        private Label lblPass;
        private TextBox txtDNI;
        private TextBox txtPass;
        private LinkLabel lnkRegistro;
        private Label lblRegistro;
        private Label lblValidar;
        private LinkLabel lnkOlvidaPass;
    }
}