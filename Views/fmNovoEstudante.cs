using Menu.DAL;
using Menu.Modelos;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Menu.Vistas
{
    public partial class fmNovoEstudante : Form
    {
        
       
        public fmNovoEstudante()
        {
            InitializeComponent();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            string nome = txtNome.Text.TrimStart().TrimEnd();
            if (string.IsNullOrWhiteSpace(nome) || nome == " ")
            {
                InformacaoErro("Nome");
                return;
            }
            else
            {
                LabelInfoEsconder();
            }

            int idade = int.Parse(txtIdade.Text);

            if (idade == 0)
            {
                InformacaoErro("Idade");
                return;
            }
            string curso = txtCurso.Text.TrimStart().TrimEnd();
            if (string.IsNullOrWhiteSpace(curso) || curso == " ")
            {
                InformacaoErro("Curso");
                return;
            }

            string mec = txtMec.Text.TrimStart().TrimEnd();
            if (string.IsNullOrWhiteSpace(mec) || mec == " ")
            {
                InformacaoErro("Mec");
                return;
            }



            Estudante est = new(nome, idade, mec, curso);
            MessageBox.Show(EstudanteDAL.Inserir(est));
                     

            LimparCampos();
            this.Close();
        } 


        void LimparCampos()
        {
            txtNome.Text = "";
            txtIdade.Text = "";
            txtMec.Text = "";
            txtCurso.Text = "";
        }
        void InformacaoErro(string campo)
        {
            lbInfo.Text = "O campo " + campo + " é obrigatório.";
            lbInfo.Visible = true;
            lbInfo.ForeColor = Color.Red;
            lbInfo.Visible = true;
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas letras e espaços
            // Permitir hífens e apóstrofos para nomes compostos    


            if (!char.IsLetter(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar) &&
                e.KeyChar != '-' &&
                e.KeyChar != '\'' &&
                !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // bloqueia o caractere

                lbInfo.Text = "Apenas letras são permitidas no campo Nome.";
                lbInfo.Visible = true;
                lbInfo.ForeColor = Color.Red;

                return;
            }
            LabelInfoEsconder();
        }

        void LabelInfoEsconder()
        {
            lbInfo.Text = "";
            lbInfo.Visible = false;
            lbInfo.ForeColor = Color.Green;
        }
        private void txtIdade_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas números e teclas de controlo (Backspace, Delete, etc.)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // bloqueia o caractere

                lbInfo.Text = "Apenas números são permitidos no campo Idade.";
                lbInfo.Visible = true;
                lbInfo.ForeColor = Color.Red;

                return;
            }
            LabelInfoEsconder();
        }
    }
}
