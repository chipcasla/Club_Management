namespace ClubManagement
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.lblValidar.Visible = true;
        }

        private void lnkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            formRegistro formregistro = new formRegistro();
            formregistro.ShowDialog();
        }
    }
}