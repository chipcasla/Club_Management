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
    public partial class formActualizarSocio : Form
    {
        Persona persona;
        public formActualizarSocio(Persona persona)
        {
            this.persona = persona;
            InitializeComponent();
        }

        private void formActualizarSocio_Load(object sender, EventArgs e)
        {
            txtApellido.Text = this.persona.getApellido();
            txtNombre.Text = this.persona.getNombre();
            txtDNI.Text = this.persona.getDni().ToString();
            txtMail.Text = this.persona.getMail();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formSocios formSoci = new formSocios();
            formSoci.Show();
            this.Close();
        }

        private void btnAcpetar_Click(object sender, EventArgs e)
        {
            if (!(this.txtDNI.Text.Length == 0 || this.txtNombre.Text.Length == 0 || this.txtApellido.Text.Length == 0 ||
                this.txtMail.Text.Length == 0))
            {
                ABMpersonas abmPers = new ABMpersonas();
                Persona pers = new Persona(
                    this.persona.getDni(),
                    txtNombre.Text,
                    txtApellido.Text,
                    txtMail.Text,
                    "",
                    ""
                    );
                abmPers.update(pers);
                MessageBox.Show("Socio actualizado con exito!");
                this.Hide();
                formSocios formSoci = new formSocios();
                formSoci.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Complete todos los campos.");
            }
        }
    }
}
