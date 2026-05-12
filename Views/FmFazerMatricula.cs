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
    public partial class FmFazerMatricula : Form
    {
        private Estudante Estudante;
        private Matricula Matricula;
        public FmFazerMatricula(Estudante estudante)
        {
            InitializeComponent();
            CarregarEstudante(estudante);
            Estudante = estudante;
        }

        private void FmFazerMatricula_Load(object sender, EventArgs e)
        {
            DgvDisciplinas.DataSource = DisciplinaDAL.TodosDisciplinas();
        }

        private void CarregarEstudante(Estudante estudante)
        {
            txtNome.Text = estudante.Nome;
            txtIdade.Text = estudante.Idade + "";
            txtMec.Text = estudante.Mec;
            txtCurso.Text = estudante.Curso;
            txtId.Text = estudante.IdEstudante + "";

        }

        private void DgvDisciplinas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvDisciplinas.SelectedRows.Count > 0)
            {
                btnMatricular.Enabled = true;

                DgvDisciplinas.ReadOnly = true;
            }

            int id = int.Parse(DgvDisciplinas.CurrentRow.Cells[0].Value.ToString());
            string nome = DgvDisciplinas.CurrentRow.Cells[1].Value.ToString();

            string codigo = DgvDisciplinas.CurrentRow.Cells[2].Value.ToString();
            int ch = int.Parse(DgvDisciplinas.CurrentRow.Cells[3].Value.ToString());
            string prof = DgvDisciplinas.CurrentRow.Cells[4].Value.ToString();
            string nif = DgvDisciplinas.CurrentRow.Cells[5].Value.ToString();
           
            Professor professor = new Professor();

            Disciplina disc = new Disciplina(id, nome, codigo, ch, professor);
            
            MessageBox.Show(Estudante.ToString());

            Matricula = new Matricula(0, "Activa", Estudante, disc);

        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Matricula.ToString());

           MessageBox.Show(MatriculaDAL.InserirMatricula(Matricula));
        }
    }
}
