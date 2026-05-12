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

       

    }
}
