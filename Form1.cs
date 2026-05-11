using MySqlX.XDevAPI.Common;
using LoginMySQL.Views;
{
    
}
namespace LoginMySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ValidarPermissao();

        }

        private void ValidarPermissao()
        {
            if (Program.utilizador.Role == "Admin")
            {
                mnInserir.Visible = true;
                mnTodosUtilizadores.Visible = true;
            }
            else
            {
                mnInserir.Visible = false;
                mnTodosUtilizadores.Visible = false;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnInserir_Click(object sender, EventArgs e)
        {
            //fmUtilizador fmUtilizador = new fmUtilizador();

            //fmUtilizador.ShowDialog();

         }
    }
}
