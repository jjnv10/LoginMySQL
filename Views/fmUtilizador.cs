using LoginMySQL.Controller;
using LoginMySQL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace LoginMySQL.Views
{
    public partial class fmUtilizador : Form
    {
        private bool Activo = false;
        private int Id = 0;
        public fmUtilizador()
        {
            InitializeComponent();
        }
        public fmUtilizador(Usuario usuario)
        {
            InitializeComponent();
            txtPassword.Text = usuario.Password;
            txtNome.Text = usuario.Nome;
            txtEmail.Text = usuario.Email;
            txtPassword.Text = "123456";
            txtUtilizador.Text = usuario.Utilizador;
            cbRole.Text= usuario.Role;
            chkActivo.Checked = usuario.Activo;
            Id = usuario.Id;

            if (usuario != null)
            {
                btnGuardar.Text = "Editar";
            }

        }
        private void chbVerPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkVerPassword.Checked;
        }

        private void cbActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActivo.Checked)
            {
                Activo = true;
            }
            else
            {
                Activo = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                LabelInfo("Email");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
              LabelInfo("Password");
              return;
            }

            if (string.IsNullOrWhiteSpace(txtUtilizador.Text))
            {
                LabelInfo("Utilizador");
                return;
            }
            if (cbRole.SelectedIndex == -1)
            {
                LabelInfo("Role");
                return;
            }

            if (!chkActivo.Checked)
            {
                LbInfo.Text = $"Deves Seleccionar o Role do Utilizador!";
                LbInfo.ForeColor = Color.Red;
                LbInfo.Visible = true;
                return;
            }

            if (Id != 0)
            {
                LbInfo.Text = Controlador.ActualizarUtilizador(
                new Usuario(Id, txtNome.Text, txtEmail.Text, Activo,
                cbRole.SelectedItem.ToString(),
                txtUtilizador.Text, txtPassword.Text));

                this.Close();
            }
            else
            {
                 LbInfo.Text = Controlador.InserirUtilizadores(
                new Usuario(0, txtNome.Text, txtEmail.Text, Activo, 
                cbRole.SelectedItem.ToString(), 
                txtUtilizador.Text,txtPassword.Text ));

                   LbInfo.ForeColor = Color.Green; 
                    LbInfo.Visible = true;
            }


            LimparCampos();

        }

        private void LabelInfo(string text) {
            LbInfo.Text = $"O Campo {text} é obrigatório!";
            LbInfo.ForeColor = Color.Red;
            LbInfo.Visible = true;
            return;
        }

        private void LimparCampos()
        {
            txtPassword.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUtilizador.Text = string.Empty;
            cbRole.SelectedIndex = -1;
            chkActivo.Checked = false;
            chkVerPassword.Checked = false;
        }
    }
}
