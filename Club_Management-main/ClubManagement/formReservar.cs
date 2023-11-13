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
    public partial class formReservar : Form
    {
        Persona persona;
        public formReservar(Persona pers)
        {
            this.persona = pers;
            InitializeComponent();
        }

        private void formReservar_Load(object sender, EventArgs e)
        {
            calendar.MinDate = DateTime.Now;

        }

        private void cbActividad_SelectedValueChanged(object sender, EventArgs e)
        {
            cbIntalacion.Items.Clear();
            string actividad = cbActividad.SelectedItem.ToString();
            ABMInstalaciones abmi = new ABMInstalaciones();
            List<Instalacion> instalaciones = abmi.consultarInstalaciones(actividad);
            foreach (Instalacion instalacion in instalaciones)
            {
                cbIntalacion.Items.Add(instalacion.getDescripcion());
            }
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            cbHorario.Items.Clear();
            List<TimeOnly> todasLasHoras = ObtenerTodasLasHoras();
            ABMreservas abmres = new ABMreservas();
            List<Reserva> reservas = abmres.consultarReservasDisponibles(cbIntalacion.SelectedItem.ToString(), calendar.SelectionRange.Start);
            foreach (var reserva in reservas)
            {
                todasLasHoras.RemoveAll(hora => hora == reserva.Hora);
            }
            foreach (var hora in todasLasHoras)
            {
                cbHorario.Items.Add(hora.ToString("hh:mm tt"));
            }
        }
        private static List<TimeOnly> ObtenerTodasLasHoras()
        {
            return new List<TimeOnly>
        {
            new TimeOnly(8, 0), new TimeOnly(9, 0), new TimeOnly(10, 0), new TimeOnly(11, 0),
            new TimeOnly(12, 0), new TimeOnly(13, 0), new TimeOnly(14, 0), new TimeOnly(15, 0),
            new TimeOnly(16, 0), new TimeOnly(17, 0), new TimeOnly(18, 0), new TimeOnly(19, 0)
};
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReservas formReservas = Application.OpenForms["formReservas"] as FormReservas;
            formReservas.Show();
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
             Reserva reserva = new Reserva();
            reserva.Estado = "Pendiente";
            reserva.Hora = TimeOnly.Parse(cbHorario.SelectedItem.ToString());
            reserva.Turno = new DateTime(
                calendar.SelectionRange.Start.Year, 
                calendar.SelectionRange.Start.Month, 
                calendar.SelectionRange.Start.Day, 
                reserva.Hora.Hour,
                0,
                0
                );
            reserva.Persona = persona;
            ABMInstalaciones abmi= new ABMInstalaciones();
            reserva.Instalacion = abmi.obtenerXDescripcion(cbIntalacion.SelectedItem.ToString());
            ABMreservas ambr = new ABMreservas();
            if(ambr.agregarReserva(reserva) == 1)
            {
                MessageBox.Show("Reserva creada con exito!");
                this.Hide();
                FormReservas formReservas = new FormReservas(persona);
                formReservas.Show();
                this.Close();
            }
            else MessageBox.Show("Ocurrio un problema, intente nuevamente");
        }
    }
}
