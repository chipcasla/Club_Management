using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClubManagement
{
    public partial class FormCuotas : Form
    {
        private Persona persona;
        public FormCuotas(Persona p)
        {
            InitializeComponent();
            this.persona = p;
            CargarCuotas(p);

        }
        public void CargarCuotas(Persona p)
        {
            this.persona = p;
            ABMcuotas instanciaABM = new ABMcuotas();
            List<Cuota> cuotasDePersona = instanciaABM.consultarCuotas(p);
            decimal contador = 0;
            string pagado = "";
            foreach (Cuota cuota in cuotasDePersona)
            {
                int rowIndex = dataGridViewCuotas.Rows.Add();
                if (cuota.Pagado)
                {
                    pagado = "Pago";
                }
                else
                {
                    contador += cuota.Monto;
                    pagado = "Sin pagar";
                }
                lblMontoDeuda.Visible = true;
                lblMontoDeuda.Text = "$" + contador.ToString();

                dataGridViewCuotas.Rows[rowIndex].Cells["anio"].Value = cuota.Anio;
                dataGridViewCuotas.Rows[rowIndex].Cells["mes"].Value = cuota.Mes;
                dataGridViewCuotas.Rows[rowIndex].Cells["monto"].Value = cuota.Monto;
                dataGridViewCuotas.Rows[rowIndex].Cells["pago"].Value = pagado;
            }
            foreach (DataGridViewColumn column in dataGridViewCuotas.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbAnio_Click(object sender, EventArgs e)
        {
            cbAnio.DroppedDown = true;
        }

        private void lblMontoDeuda_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            formMenu formMenup = Application.OpenForms["formMenu"] as formMenu;
            formMenup.Show();
            this.Close();
        }
    }
}
