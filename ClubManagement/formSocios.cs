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
            List<Persona> personasList = abmPersonas.obtenerSocios();

            dataSocios.DataSource = personasList;
        }
    }
}
