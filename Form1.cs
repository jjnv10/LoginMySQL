
using LoginMySQL.Views;
using Menu.Vistas;
using System;
using System.Windows.Forms;
namespace LoginMySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



        }

        private void ValidarPermissao()
        {
            if (Program.utilizador.Role == "Administrador")
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
            fmUtilizador fmUtilizador = new fmUtilizador();

            fmUtilizador.ShowDialog();

        }

        private void mnTodosUtilizadores_Click(object sender, EventArgs e)
        {
            FmTodosUtilizadores Utilizadores = new FmTodosUtilizadores();
            Utilizadores.ShowDialog();
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmNovoEstudante estudante = new fmNovoEstudante();
            estudante.ShowDialog();
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fmNovoProfessor professor = new fmNovoProfessor();
            professor.ShowDialog();
        }

        private void todosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmTodosProfessores pro = new fmTodosProfessores();
            pro.ShowDialog();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmTodosEstudantes est = new fmTodosEstudantes();
            est.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ValidarPermissao();
            ssUser.Text = Program.utilizador.Nome;
        }

        private void todasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmTodasDisciplinas Td = new FmTodasDisciplinas();
            Td.Show(this);
        }

        private void novaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmTodosProfessores pro = new fmTodosProfessores();
            pro.ShowDialog();
        }

        private void todasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FmTodasMatriculas tm = new FmTodasMatriculas();
            tm.ShowDialog(this);
        }
    }
}
