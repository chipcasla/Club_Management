using Negocio;
using Entidades;

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
            if (this.txtDNI.Text.Length == 0 || this.txtPass.Text.Length == 0)
            {
                this.lblValidar.Visible = true;
                this.lblValidar.ForeColor = Color.Red;
                this.lblValidar.Text = "Complete todos los campos";
            }
            else
            {
                //this.lblValidar.Visible = false;
                ABMpersonas pers = new ABMpersonas();
                Persona p = pers.validarInicio(this.txtDNI.Text, this.txtPass.Text);
                if (p != null)
                {
                    if(p.getRol() == "admin")
                    {
                        this.Hide();
                        formMenuAdmin formMenuAdm= new formMenuAdmin();
                        formMenuAdm.ShowDialog();
                    }
                    else
                    {
                        if(p.getRol() == "user")
                        {
                            this.Hide();
                            formMenu formMenup = new formMenu(p);
                            formMenup.ShowDialog();
                        }
                        else
                        {
                            this.Hide();
                            formMenuProfe formMenuProf = new formMenuProfe();
                            formMenuProf.ShowDialog();
                        }
                    }
                }
                else
                {
                    this.lblValidar.Visible = true;
                    this.lblValidar.ForeColor = Color.Red;
                    this.lblValidar.Text = "Usuario y/o contraseņa incorrectos";
                }

            }
        }

        private void lnkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            formRegistro formregistro = new formRegistro();
            formregistro.ShowDialog();
        }
    }
}