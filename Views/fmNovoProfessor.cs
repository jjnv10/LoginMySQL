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
    public partial class fmNovoProfessor : Form
    {
        private readonly ProfessorDAL _profeDAL = new ProfessorDAL();
        public fmNovoProfessor()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtIdade.Clear();
            txtNIF.Clear();
            txtArea.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Professor profe = new(txtNome.Text, int.Parse(txtIdade.Text), txtNIF.Text, txtArea.Text);

                          
                MessageBox.Show(ProfessorDAL.Inserir(profe));
                LimparCampos();
           
        }
    }
}
