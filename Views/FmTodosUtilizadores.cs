using LoginMySQL.Controller;
using LoginMySQL.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoginMySQL.Views
{
    public partial class FmTodosUtilizadores : Form
    {
        private static Usuario Usuario;
        public FmTodosUtilizadores()
        {
            InitializeComponent();
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;


        }

        private void FmTodosUtilizadores_Load(object sender, EventArgs e)
        {
            CarregarDataGrid();
        }

        private void DgVUtilizadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { //id, nome, email, usuario, role, activo

            if (DgVUtilizadores.SelectedRows.Count > 0)
            {
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
                DgVUtilizadores.ReadOnly = true;
            }

            int id = int.Parse(DgVUtilizadores.CurrentRow.Cells[0].Value.ToString());
            string nome = DgVUtilizadores.CurrentRow.Cells[1].Value.ToString();
            string email = DgVUtilizadores.CurrentRow.Cells[2].Value.ToString();
            string usuario = DgVUtilizadores.CurrentRow.Cells[3].Value.ToString();
            string role = DgVUtilizadores.CurrentRow.Cells[4].Value.ToString();
            bool activo = bool.Parse(DgVUtilizadores.CurrentRow.Cells[5].Value.ToString());
            label1.Text = nome;

           Usuario = new Usuario(id, nome, email, activo, role, usuario, "");

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            fmUtilizador ut = new fmUtilizador(Usuario);
            ut.ShowDialog();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Desejas eliminar " + Usuario.Nome, "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            int id = int.Parse(DgVUtilizadores.CurrentRow.Cells[0].Value.ToString());
            if (resultado == DialogResult.Yes)
            {
               label1.Text = Controlador.EliminarUtilizador(id);
            }
            CarregarDataGrid();
        }

        private void CarregarDataGrid()
        {
            DgVUtilizadores.DataSource = Controlador.TodosUtilizadores();
        }
    }
}
