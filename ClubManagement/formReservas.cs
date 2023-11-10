using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubManagement
{
    public partial class FormReservas : Form
    {
        private Persona persona;
        public FormReservas(Persona p)
        {
            InitializeComponent();
            this.persona = p;

            ABMreservas aBMreservas = new ABMreservas();

            List<Reserva> reservasList = aBMreservas.consultarReservaCliente(p);

            // dataGridView1.DataSource = reservasList;


            foreach (Reserva reserva in reservasList)
            {
                // Crea una nueva fila para el DataGridView
                int rowIndex = dataGridView1.Rows.Add();

                dataGridView1.Rows[rowIndex].Cells["Id"].Value = reserva.Id;
                dataGridView1.Rows[rowIndex].Cells["estado"].Value = reserva.Estado;
                dataGridView1.Rows[rowIndex].Cells["fecha"].Value = reserva.Turno.ToString("dd/MM/yyyy HH:mm");
                dataGridView1.Rows[rowIndex].Cells["instalacion"].Value = reserva.Instalacion.getDescripcion();
                dataGridView1.Rows[rowIndex].Cells["actividad"].Value = reserva.Instalacion.Actividad.getDescripcion();
                //dataGridView1.Rows[rowIndex].Cells["DescripcionInstalacion"].Value = reserva.Instalacion.getDescripcion();
                // Agrega más columnas según sea necesario

            }
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                // O puedes utilizar otro modo, como DisplayedCells, DisplayedCellsExceptHeader o Fill
            }

            this.persona = persona;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMenu formMenup = Application.OpenForms["formMenu"] as formMenu;
            formMenup.Show();
            this.Close();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formReservar formReser = new formReservar(persona);
            formReser.ShowDialog();
        }

        private void FormReservas_Load(object sender, EventArgs e)
        {
            dataGridView1.Refresh();
        }
    }
}
