namespace LoginMySQL.Views
{
    partial class FmTodosUtilizadores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DgVUtilizadores = new DataGridView();
            btnSair = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgVUtilizadores).BeginInit();
            SuspendLayout();
            // 
            // DgVUtilizadores
            // 
            DgVUtilizadores.BackgroundColor = Color.Gainsboro;
            DgVUtilizadores.BorderStyle = BorderStyle.None;
            DgVUtilizadores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgVUtilizadores.Location = new Point(3, 12);
            DgVUtilizadores.Name = "DgVUtilizadores";
            DgVUtilizadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgVUtilizadores.Size = new Size(630, 350);
            DgVUtilizadores.TabIndex = 0;
            DgVUtilizadores.CellContentClick += DgVUtilizadores_CellContentClick;
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Microsoft Tai Le", 12F);
            btnSair.Location = new Point(383, 379);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 29);
            btnSair.TabIndex = 1;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Microsoft Tai Le", 12F);
            btnEditar.Location = new Point(558, 379);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 29);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Microsoft Tai Le", 12F);
            btnEliminar.Location = new Point(464, 379);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 420);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // FmTodosUtilizadores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 445);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnSair);
            Controls.Add(DgVUtilizadores);
            Name = "FmTodosUtilizadores";
            Text = "FmTodosUtilizadores";
            Load += FmTodosUtilizadores_Load;
            ((System.ComponentModel.ISupportInitialize)DgVUtilizadores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgVUtilizadores;
        private Button btnSair;
        private Button btnEditar;
        private Button btnEliminar;
        private Label label1;
    }
}