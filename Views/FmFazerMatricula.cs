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
        private int IdDisciplina;
        public FmFazerMatricula(Estudante estudante)
        {
            InitializeComponent();
            CarregarEstudante(estudante);
            Estudante = estudante;
            
        }

        private void FmFazerMatricula_Load(object sender, EventArgs e)
        {
            DgvDisciplinas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

            ;

            Matricula = new Matricula(0, "Activa", Estudante, disc);
            btnMatricular.Visible = ActivarMatricula(Matricula);

        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(MatriculaDAL.InserirMatricula(Matricula));
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecciona Uma Disciplina" + ex.Message);
               
            }
            
        }

        private bool ActivarMatricula(Matricula m)
        {
            return m.GetType().GetProperty("Estudante") != null;
        }
    }
}
