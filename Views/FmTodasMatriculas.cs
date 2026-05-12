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
    public partial class FmTodasMatriculas : Form
    {
        public FmTodasMatriculas()
        {
            InitializeComponent();
        }

        private void FmTodasMatriculas_Load(object sender, EventArgs e)
        {
            CarregarMatriculas();
            
        }
        private void CarregarMatriculas()
        {
            DgvMatriculas.DataSource = MatriculaDAL.TodasMatriculas();
        }
    }
}
