using LoginMySQL.Controller;
using LoginMySQL.DAL;
using LoginMySQL.Models;

namespace LoginMySQL.Views
{
    public partial class fmLogin : Form
    {
        public fmLogin()
        {
            InitializeComponent();
            lbInfo.Text = "";
            lbInfo.Visible = false;
            Console.WriteLine("Chegou");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var authService = new AuthService("");

            Usuario? utilizador = await authService.LoginAsync(
                Email: txtEmail.Text,
                Password: txtPassword.Text
            );

            if (utilizador != null)
            {
                Program.utilizador = utilizador;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                lbInfo.Text = "Utilizador ou senha incorretos!";
                lbInfo.Visible = true;
                lbInfo.ForeColor = Color.Red;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controlador.Inserir();
        }
    }
}
