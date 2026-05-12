namespace LoginMySQL.Views
{
    partial class FmFazerMatricula
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
            DgvDisciplinas = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNome = new TextBox();
            txtMec = new TextBox();
            txtIdade = new TextBox();
            txtCurso = new TextBox();
            txtId = new TextBox();
            btnMatricular = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvDisciplinas).BeginInit();
            SuspendLayout();
            // 
            // DgvDisciplinas
            // 
            DgvDisciplinas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDisciplinas.Location = new Point(1, 90);
            DgvDisciplinas.Name = "DgvDisciplinas";
            DgvDisciplinas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvDisciplinas.Size = new Size(783, 171);
            DgvDisciplinas.TabIndex = 0;
            DgvDisciplinas.CellContentClick += DgvDisciplinas_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 12F);
            label1.Location = new Point(23, 18);
            label1.Name = "label1";
            label1.Size = new Size(53, 21);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 12F);
            label2.Location = new Point(441, 18);
            label2.Name = "label2";
            label2.Size = new Size(43, 21);
            label2.TabIndex = 2;
            label2.Text = "MEC";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 12F);
            label3.Location = new Point(299, 15);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 3;
            label3.Text = "Idade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 12F);
            label4.Location = new Point(24, 52);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 4;
            label4.Text = "Curso";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 12F);
            label5.Location = new Point(459, 52);
            label5.Name = "label5";
            label5.Size = new Size(25, 21);
            label5.TabIndex = 5;
            label5.Text = "ID";
            // 
            // txtNome
            // 
            txtNome.Enabled = false;
            txtNome.Font = new Font("Segoe UI Variable Display", 12F);
            txtNome.Location = new Point(78, 12);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(215, 29);
            txtNome.TabIndex = 6;
            // 
            // txtMec
            // 
            txtMec.Enabled = false;
            txtMec.Font = new Font("Segoe UI Variable Display", 12F);
            txtMec.Location = new Point(490, 10);
            txtMec.Name = "txtMec";
            txtMec.Size = new Size(109, 29);
            txtMec.TabIndex = 7;
            // 
            // txtIdade
            // 
            txtIdade.Enabled = false;
            txtIdade.Font = new Font("Segoe UI Variable Display", 12F);
            txtIdade.Location = new Point(353, 12);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(68, 29);
            txtIdade.TabIndex = 8;
            // 
            // txtCurso
            // 
            txtCurso.Enabled = false;
            txtCurso.Font = new Font("Segoe UI Variable Display", 12F);
            txtCurso.Location = new Point(78, 47);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(215, 29);
            txtCurso.TabIndex = 9;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Segoe UI", 12F);
            txtId.Location = new Point(490, 44);
            txtId.Name = "txtId";
            txtId.Size = new Size(109, 29);
            txtId.TabIndex = 10;
            // 
            // btnMatricular
            // 
            btnMatricular.Location = new Point(700, 267);
            btnMatricular.Name = "btnMatricular";
            btnMatricular.Size = new Size(75, 23);
            btnMatricular.TabIndex = 11;
            btnMatricular.Text = "Matricular";
            btnMatricular.UseVisualStyleBackColor = true;
            btnMatricular.Click += btnMatricular_Click;
            // 
            // FmFazerMatricula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 302);
            Controls.Add(btnMatricular);
            Controls.Add(txtId);
            Controls.Add(txtCurso);
            Controls.Add(txtIdade);
            Controls.Add(txtMec);
            Controls.Add(txtNome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DgvDisciplinas);
            Name = "FmFazerMatricula";
            Text = "FmFazerMatricula";
            Load += FmFazerMatricula_Load;
            ((System.ComponentModel.ISupportInitialize)DgvDisciplinas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvDisciplinas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNome;
        private TextBox txtMec;
        private TextBox txtIdade;
        private TextBox txtCurso;
        private TextBox txtId;
        private Button btnMatricular;
    }
}