using LoginMySQL.Views;
using Menu.DAL;
using Menu.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Menu.Vistas
{
    public partial class fmTodosEstudantes : Form
    {

        private Estudante Estudante;
        public fmTodosEstudantes()
        {
            InitializeComponent();
            //
            CarregarEstudantes();

        }

        private void CarregarEstudantes()
        {
            DgVEstudantes.DataSource = EstudanteDAL.ListarTodos();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmTodosEstudantes_Load(object sender, EventArgs e)
        {

        }

        private void DgVEstudantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (DgVEstudantes.SelectedRows.Count > 0)
            {
                btnMatricular.Enabled = true;

                DgVEstudantes.ReadOnly = true;
            }

            int id = int.Parse(DgVEstudantes.CurrentRow.Cells[0].Value.ToString());
            int idade = int.Parse(DgVEstudantes.CurrentRow.Cells[3].Value.ToString());
            string nome = DgVEstudantes.CurrentRow.Cells[2].Value.ToString();
            string mec = DgVEstudantes.CurrentRow.Cells[4].Value.ToString();
            string curso = DgVEstudantes.CurrentRow.Cells[5].Value.ToString();

            Estudante = new(id, nome, idade, mec, curso);

            LbInfo.Text = Estudante.ToString();

        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            if (Estudante != null)
            {
                FmFazerMatricula fm = new FmFazerMatricula(Estudante);
                fm.ShowDialog(this);
            }
            
        }
    }
}
