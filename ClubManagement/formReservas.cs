using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubManagement
{
    public partial class FormReservas : Form
    {
        public FormReservas()
        {
            InitializeComponent();

            ABMreservas aBMreservas = new ABMreservas();

            List<Reserva> reservasList = aBMreservas.consultarReservas();

            // dataGridView1.DataSource = reservasList;


            // Recorre la lista de reservas y agrega cada reserva al DataGridView
            foreach (Reserva reserva in reservasList)
            {
                // Crea una nueva fila para el DataGridView
                int rowIndex = dataGridView1.Rows.Add();

                // Asigna manualmente los valores de cada columna
                dataGridView1.Rows[rowIndex].Cells["Id"].Value = reserva.Id;
                //dataGridView1.Rows[rowIndex].Cells["Persona"].Value = reserva.Persona.getDni().ToString();
                //dataGridView1.Rows[rowIndex].Cells["Turno"].Value = reserva.Turno;
                dataGridView1.Rows[rowIndex].Cells["estado"].Value = reserva.Estado;
                //dataGridView1.Rows[rowIndex].Cells["DescripcionInstalacion"].Value = reserva.Instalacion.getDescripcion();
                // Agrega más columnas según sea necesario

                // Puedes repetir estos pasos para cada reserva en la lista
            }

        }
    }
}
