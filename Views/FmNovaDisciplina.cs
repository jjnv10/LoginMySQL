using LoginMySQL.DAL;
using Menu.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoginMySQL.Views
{
    public partial class FmNovaDisciplina : Form
    {
        private Professor Professor;
        public FmNovaDisciplina(Professor professor)
        {
            Professor = professor;
            InitializeComponent();
            CarregarProfessor(professor);
        }

        private void FmNovaDisciplina_Load(object sender, EventArgs e)
        {

        }

        private void CarregarProfessor(Professor professor)
        {
            txtPNome.Text = professor.Nome;
            txtPIdade.Text = professor.Idade + "";
            txtPNIF.Text = professor.NIF + " (" + professor.IdProfessor + ")";
            txtPArea.Text = professor.AreaEspecialidade;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                LabelInfo("Nome");
                return;

            }
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                LabelInfo("Código da Disciplina");
                return;

            }
            if (string.IsNullOrWhiteSpace(txtCarga.Text))
            {
                LabelInfo("Carga Horária");
                return;

            }

            Disciplina Disciplina = new Disciplina(txtNome.Text, txtCodigo.Text, int.Parse(txtCarga.Text), Professor);

            MessageBox.Show(DisciplinaDAL.Inserir(Disciplina));

            this.Close();
        }

        private void LabelInfo(string text)
        {
            LbInfo.Text = $"O Campo {text} é obrigatório!";
            LbInfo.ForeColor = Color.Red;
            LbInfo.Visible = true;
            return;
        }
    }
}
