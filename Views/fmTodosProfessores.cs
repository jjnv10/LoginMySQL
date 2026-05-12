using Menu.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Menu.Modelos;
using LoginMySQL.Views;

namespace Menu.Vistas
{
    public partial class fmTodosProfessores : Form
    {
        private Professor Professor;
        public fmTodosProfessores()
        {
            InitializeComponent();
            CarregarProfessores();

            DgvProfessores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvProfessores.MultiSelect = false;
            DgvProfessores.ReadOnly = true;

        }

        private void CarregarProfessores()
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvProfessores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvProfessores.SelectedRows.Count > 0)
            {
                btnAdicionar.Enabled = true;
            }
            int idProfessor = int.Parse(DgvProfessores.CurrentRow.Cells[0].Value.ToString());
            int idPessoa = int.Parse(DgvProfessores.CurrentRow.Cells[1].Value.ToString());
            string nome = DgvProfessores.CurrentRow.Cells[2].Value.ToString();
            int idade = int.Parse(DgvProfessores.CurrentRow.Cells[3].Value.ToString());
            string nif = DgvProfessores.CurrentRow.Cells[4].Value.ToString();
            string area = DgvProfessores.CurrentRow.Cells[5].Value.ToString();

            Professor = new Professor(idProfessor, idPessoa, nome, idade, nif, area);

            LbInfo.Text = idProfessor+"";

        }

        private void Carregar()
        {
            DgvProfessores.DataSource = ProfessorDAL.TodosProfessores();
            DgvProfessores.ReadOnly = true;
        }

        private void fmTodosProfessores_Load(object sender, EventArgs e)
        {
            Carregar();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FmNovaDisciplina nd = new(Professor);
            nd.ShowDialog(this);
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            fmNovoProfessor Np = new fmNovoProfessor();
            Np.ShowDialog(this);
            this.Close();
        }
    }
}
