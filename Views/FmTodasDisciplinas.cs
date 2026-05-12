using LoginMySQL.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LoginMySQL.Views
{
    public partial class FmTodasDisciplinas : Form
    {
        public FmTodasDisciplinas()
        {
            InitializeComponent();
        }

        private void FmTodasDisciplinas_Load(object sender, EventArgs e)
        {
            DgvDisciplinas.DataSource = DisciplinaDAL.TodosDisciplinas();
        }
    }
}
