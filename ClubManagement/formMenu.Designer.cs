namespace ClubManagement
{
    partial class formMenu
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
            lblMenu = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            btn_menu_reserva = new Button();
            btn_menu_cuotas = new Button();
            btn_menu_salir = new Button();
            btn_menu_misDatos = new Button();
            SuspendLayout();
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblMenu.Location = new Point(323, 47);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(121, 50);
            lblMenu.TabIndex = 0;
            lblMenu.Text = "Menu";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // btn_menu_reserva
            // 
            btn_menu_reserva.Location = new Point(307, 145);
            btn_menu_reserva.Name = "btn_menu_reserva";
            btn_menu_reserva.Size = new Size(161, 33);
            btn_menu_reserva.TabIndex = 2;
            btn_menu_reserva.Text = "Reservas";
            btn_menu_reserva.UseVisualStyleBackColor = true;
            btn_menu_reserva.Click += btn_menu_reserva_Click;
            // 
            // btn_menu_cuotas
            // 
            btn_menu_cuotas.Location = new Point(307, 184);
            btn_menu_cuotas.Name = "btn_menu_cuotas";
            btn_menu_cuotas.Size = new Size(161, 33);
            btn_menu_cuotas.TabIndex = 3;
            btn_menu_cuotas.Text = "Cuotas";
            btn_menu_cuotas.UseVisualStyleBackColor = true;
            // 
            // btn_menu_salir
            // 
            btn_menu_salir.BackColor = Color.LightCoral;
            btn_menu_salir.Location = new Point(307, 262);
            btn_menu_salir.Name = "btn_menu_salir";
            btn_menu_salir.Size = new Size(161, 33);
            btn_menu_salir.TabIndex = 4;
            btn_menu_salir.Text = "Salir";
            btn_menu_salir.UseVisualStyleBackColor = false;
            btn_menu_salir.Click += btn_menu_salir_Click;
            // 
            // btn_menu_misDatos
            // 
            btn_menu_misDatos.Location = new Point(307, 223);
            btn_menu_misDatos.Name = "btn_menu_misDatos";
            btn_menu_misDatos.Size = new Size(161, 33);
            btn_menu_misDatos.TabIndex = 5;
            btn_menu_misDatos.Text = "Mis Datos";
            btn_menu_misDatos.UseVisualStyleBackColor = true;
            // 
            // formMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_menu_misDatos);
            Controls.Add(btn_menu_salir);
            Controls.Add(btn_menu_cuotas);
            Controls.Add(btn_menu_reserva);
            Controls.Add(lblMenu);
            Name = "formMenu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMenu;
        private ContextMenuStrip contextMenuStrip1;
        private Button btn_menu_reserva;
        private Button btn_menu_cuotas;
        private Button btn_menu_salir;
        private Button btn_menu_misDatos;
    }
}