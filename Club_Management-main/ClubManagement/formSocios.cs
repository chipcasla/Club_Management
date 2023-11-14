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
    public partial class formSocios : Form
    {
        public formSocios()
        {
            InitializeComponent();
        }

        private void formSocios_Load(object sender, EventArgs e)
        {
            ABMpersonas abmPersonas = new ABMpersonas();
            List<PersonaCuota> personasList = abmPersonas.obtenerSociosCuotas();

            foreach (PersonaCuota persona in personasList)
            {

                int rowIndex = dataSocios.Rows.Add();

                dataSocios.Rows[rowIndex].Cells["Dni"].Value = persona.getDni();
                dataSocios.Rows[rowIndex].Cells["Nombre"].Value = persona.getNombre();
                dataSocios.Rows[rowIndex].Cells["Apellido"].Value = persona.getApellido();
                dataSocios.Rows[rowIndex].Cells["Email"].Value = persona.getMail();
                dataSocios.Rows[rowIndex].Cells["CuotasAsignadas"].Value = persona.getCuotasAsignadas();
                dataSocios.Rows[rowIndex].Cells["Debe"].Value = persona.getDebe();
                dataSocios.Rows[rowIndex].Cells["Monto"].Value = persona.getMonto();


            }
            foreach (DataGridViewColumn column in dataSocios.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMenuAdmin formMenuAd = new formMenuAdmin();
            formMenuAd.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Quieres continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

                ABMpersonas abmPersonas = new ABMpersonas();
                int personaExiste = abmPersonas.buscaPersona(int.Parse(txtDni.Text));
                if (personaExiste == 2)
                {
                    abmPersonas.delete(txtDni.Text);
                    MessageBox.Show("Usuario eliminado con exito!");
                    this.Hide();
                    formSocios formSoci = new formSocios();
                    formSoci.Show();
                    this.Close();
                }
                else MessageBox.Show("No existe el dni ingresado.");

            }

        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {

            ABMpersonas abmPersonas = new ABMpersonas();
            Persona personaExiste = abmPersonas.buscaPersonaXDni(txtDni.Text.ToString());
            if (personaExiste != null)
            {
                this.Hide();
                formActualizarSocio formAcySoc = new formActualizarSocio(personaExiste);
                formAcySoc.Show();
            }
            else MessageBox.Show("No existe el dni ingresado.");

        }
    }
}
