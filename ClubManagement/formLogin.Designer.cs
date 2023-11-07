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
            btnAceptar.Location = new Point(389, 291);
            btnAceptar.Margin = new Padding(3, 4, 3, 4);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(110, 31);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Location = new Point(162, 291);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 31);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(192, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(302, 60);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Iniciar Sesión";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblDNI.Location = new Point(181, 124);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(37, 20);
            lblDNI.TabIndex = 3;
            lblDNI.Text = "DNI";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPass.Location = new Point(135, 183);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(88, 20);
            lblPass.TabIndex = 4;
            lblPass.Text = "Contraseña";
            // 
            // txtDNI
            // 
            txtDNI.Cursor = Cursors.IBeam;
            txtDNI.Location = new Point(224, 120);
            txtDNI.Margin = new Padding(3, 4, 3, 4);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(274, 27);
            txtDNI.TabIndex = 6;
            // 
            // txtPass
            // 
            txtPass.Cursor = Cursors.IBeam;
            txtPass.Location = new Point(224, 179);
            txtPass.Margin = new Padding(3, 4, 3, 4);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(274, 27);
            txtPass.TabIndex = 7;
            // 
            // lnkRegistro
            // 
            lnkRegistro.AutoSize = true;
            lnkRegistro.Cursor = Cursors.Hand;
            lnkRegistro.Location = new Point(175, 356);
            lnkRegistro.Name = "lnkRegistro";
            lnkRegistro.Size = new Size(76, 20);
            lnkRegistro.TabIndex = 8;
            lnkRegistro.TabStop = true;
            lnkRegistro.Text = "Registrate";
            lnkRegistro.LinkClicked += lnkRegistro_LinkClicked;
            // 
            // lblRegistro
            // 
            lblRegistro.AutoSize = true;
            lblRegistro.Location = new Point(14, 356);
            lblRegistro.Name = "lblRegistro";
            lblRegistro.Size = new Size(155, 20);
            lblRegistro.TabIndex = 9;
            lblRegistro.Text = "¿Aun no tiene cuenta?";
            // 
            // lblValidar
            // 
            lblValidar.AutoSize = true;
            lblValidar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblValidar.Location = new Point(298, 235);
            lblValidar.Name = "lblValidar";
            lblValidar.Size = new Size(65, 20);
            lblValidar.TabIndex = 10;
            lblValidar.Text = "textoVal";
            lblValidar.Visible = false;
            // 
            // lnkOlvidaPass
            // 
            lnkOlvidaPass.AutoSize = true;
            lnkOlvidaPass.Cursor = Cursors.Hand;
            lnkOlvidaPass.Location = new Point(14, 389);
            lnkOlvidaPass.Name = "lnkOlvidaPass";
            lnkOlvidaPass.Size = new Size(164, 20);
            lnkOlvidaPass.TabIndex = 5;
            lnkOlvidaPass.TabStop = true;
            lnkOlvidaPass.Text = "Olvidaste tu contraseña";
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 421);
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
            Margin = new Padding(3, 4, 3, 4);
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