namespace ClubManagement
{
    partial class formReservar
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
            lblTitulo = new Label();
            lblFecha = new Label();
            calendar = new MonthCalendar();
            lblHorario = new Label();
            label1 = new Label();
            cbActividad = new ComboBox();
            label2 = new Label();
            cbIntalacion = new ComboBox();
            cbHorario = new ComboBox();
            btnAceptar = new Button();
            btnAtras = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(300, 24);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(232, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Agregar Reserva";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(9, 166);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(123, 20);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Seleccione fecha:";
            // 
            // calendar
            // 
            calendar.Location = new Point(9, 195);
            calendar.MinDate = new DateTime(2023, 11, 9, 22, 5, 33, 0);
            calendar.Name = "calendar";
            calendar.TabIndex = 3;
            calendar.DateChanged += calendar_DateChanged;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Location = new Point(402, 166);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(135, 20);
            lblHorario.TabIndex = 4;
            lblHorario.Text = "Seleccione horario:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 84);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 5;
            label1.Text = "Seleccione actividad:";
            // 
            // cbActividad
            // 
            cbActividad.FormattingEnabled = true;
            cbActividad.Items.AddRange(new object[] { "Natación", "Fútbol", "Tenis", "Yoga", "Baloncesto", "Voleibol", "Hockey", "Rugby" });
            cbActividad.Location = new Point(173, 81);
            cbActividad.Name = "cbActividad";
            cbActividad.Size = new Size(253, 28);
            cbActividad.TabIndex = 6;
            cbActividad.SelectedValueChanged += cbActividad_SelectedValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 127);
            label2.Name = "label2";
            label2.Size = new Size(158, 20);
            label2.TabIndex = 7;
            label2.Text = "Seleccione instalacion:";
            // 
            // cbIntalacion
            // 
            cbIntalacion.FormattingEnabled = true;
            cbIntalacion.Location = new Point(173, 124);
            cbIntalacion.Name = "cbIntalacion";
            cbIntalacion.Size = new Size(253, 28);
            cbIntalacion.TabIndex = 8;
            // 
            // cbHorario
            // 
            cbHorario.FormattingEnabled = true;
            cbHorario.Location = new Point(402, 195);
            cbHorario.Name = "cbHorario";
            cbHorario.Size = new Size(231, 28);
            cbHorario.TabIndex = 9;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.Highlight;
            btnAceptar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnAceptar.Location = new Point(692, 454);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(123, 54);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnAtras
            // 
            btnAtras.Location = new Point(402, 454);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(123, 54);
            btnAtras.TabIndex = 11;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click;
            // 
            // formReservar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 534);
            Controls.Add(btnAtras);
            Controls.Add(btnAceptar);
            Controls.Add(cbHorario);
            Controls.Add(cbIntalacion);
            Controls.Add(label2);
            Controls.Add(cbActividad);
            Controls.Add(label1);
            Controls.Add(lblHorario);
            Controls.Add(calendar);
            Controls.Add(lblFecha);
            Controls.Add(lblTitulo);
            Name = "formReservar";
            Text = "Reservar";
            Load += formReservar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblFecha;
        private MonthCalendar calendar;
        private Label lblHorario;
        private Label label1;
        private ComboBox cbActividad;
        private Label label2;
        private ComboBox cbIntalacion;
        private ComboBox cbHorario;
        private Button btnAceptar;
        private Button btnAtras;
    }
}