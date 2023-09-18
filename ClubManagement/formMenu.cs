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
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }
        public void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            formLogin formIngreso = new formLogin();
            formIngreso.ShowDialog();
        }
    }
}
