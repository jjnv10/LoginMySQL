namespace Menu.Vistas
{
    partial class fmNovoEstudante
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbInfo = new Label();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            txtMec = new TextBox();
            txtCurso = new TextBox();
            btnGuardar = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 14.25F);
            label1.Location = new Point(21, 26);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Symbol", 14.25F);
            label2.Location = new Point(21, 91);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Idade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Symbol", 14.25F);
            label3.Location = new Point(208, 91);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 2;
            label3.Text = "MEC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Symbol", 14.25F);
            label4.Location = new Point(23, 152);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 3;
            label4.Text = "Curso";
            // 
            // lbInfo
            // 
            lbInfo.AutoSize = true;
            lbInfo.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbInfo.Location = new Point(23, 189);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(12, 20);
            lbInfo.TabIndex = 4;
            lbInfo.Text = ".";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(102, 26);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome completo do Estudante";
            txtNome.Size = new Size(280, 23);
            txtNome.TabIndex = 5;
            txtNome.KeyPress += txtNome_KeyPress;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(102, 91);
            txtIdade.MaxLength = 3;
            txtIdade.Name = "txtIdade";
            txtIdade.PlaceholderText = "A Idade ";
            txtIdade.Size = new Size(100, 23);
            txtIdade.TabIndex = 6;
            txtIdade.KeyPress += txtIdade_KeyPress;
            // 
            // txtMec
            // 
            txtMec.Location = new Point(265, 91);
            txtMec.Name = "txtMec";
            txtMec.PlaceholderText = "Número Mecanográfico";
            txtMec.Size = new Size(117, 23);
            txtMec.TabIndex = 7;
            // 
            // txtCurso
            // 
            txtCurso.Location = new Point(102, 152);
            txtCurso.Name = "txtCurso";
            txtCurso.PlaceholderText = "Curso do Estudante";
            txtCurso.Size = new Size(280, 23);
            txtCurso.TabIndex = 8;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 14.25F);
            btnGuardar.Location = new Point(283, 220);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(99, 31);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14.25F);
            button2.Location = new Point(178, 220);
            button2.Name = "button2";
            button2.Size = new Size(99, 31);
            button2.TabIndex = 10;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14.25F);
            button3.Location = new Point(97, 220);
            button3.Name = "button3";
            button3.Size = new Size(75, 31);
            button3.TabIndex = 11;
            button3.Text = "Sair";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // fmNovoEstudante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 273);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnGuardar);
            Controls.Add(txtCurso);
            Controls.Add(txtMec);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(lbInfo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fmNovoEstudante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Novo Estudante";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lbInfo;
        private TextBox txtNome;
        private TextBox txtIdade;
        private TextBox txtMec;
        private TextBox txtCurso;
        private Button btnGuardar;
        private Button button2;
        private Button button3;
    }
}