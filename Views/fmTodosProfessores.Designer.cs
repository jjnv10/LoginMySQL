namespace Menu.Vistas
{
    partial class fmTodosProfessores
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
            button1 = new Button();
            DgvProfessores = new DataGridView();
            btnAdicionar = new Button();
            btnNovo = new Button();
            LbInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvProfessores).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(324, 380);
            button1.Name = "button1";
            button1.Size = new Size(104, 34);
            button1.TabIndex = 1;
            button1.Text = "Sair";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DgvProfessores
            // 
            DgvProfessores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvProfessores.Location = new Point(12, 12);
            DgvProfessores.Name = "DgvProfessores";
            DgvProfessores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvProfessores.Size = new Size(776, 343);
            DgvProfessores.TabIndex = 2;
            DgvProfessores.CellContentClick += DgvProfessores_CellContentClick;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(434, 380);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(198, 34);
            btnAdicionar.TabIndex = 3;
            btnAdicionar.Text = "Adicionar Disciplina";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNovo.Location = new Point(638, 380);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(150, 32);
            btnNovo.TabIndex = 4;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // LbInfo
            // 
            LbInfo.AutoSize = true;
            LbInfo.Location = new Point(19, 377);
            LbInfo.Name = "LbInfo";
            LbInfo.Size = new Size(0, 15);
            LbInfo.TabIndex = 5;
            // 
            // fmTodosProfessores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 421);
            Controls.Add(LbInfo);
            Controls.Add(btnNovo);
            Controls.Add(btnAdicionar);
            Controls.Add(DgvProfessores);
            Controls.Add(button1);
            Name = "fmTodosProfessores";
            Text = "fmTodosProfessores";
            Load += fmTodosProfessores_Load;
            ((System.ComponentModel.ISupportInitialize)DgvProfessores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private DataGridView DgvProfessores;
        private Button btnAdicionar;
        private Button btnNovo;
        private Label LbInfo;
    }
}