namespace Menu.Vistas
{
    partial class fmNovoProfessor
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
            groupBox1 = new GroupBox();
            btnSair = new Button();
            btnLimpar = new Button();
            button1 = new Button();
            txtArea = new TextBox();
            txtNIF = new TextBox();
            txtIdade = new TextBox();
            txtNome = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSair);
            groupBox1.Controls.Add(btnLimpar);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtArea);
            groupBox1.Controls.Add(txtNIF);
            groupBox1.Controls.Add(txtIdade);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(445, 247);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Novo Professor";
            // 
            // btnSair
            // 
            btnSair.Location = new Point(90, 184);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(95, 48);
            btnSair.TabIndex = 10;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(203, 184);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(105, 47);
            btnLimpar.TabIndex = 9;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(314, 184);
            button1.Name = "button1";
            button1.Size = new Size(116, 47);
            button1.TabIndex = 8;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(139, 135);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(291, 33);
            txtArea.TabIndex = 7;
            // 
            // txtNIF
            // 
            txtNIF.Location = new Point(246, 93);
            txtNIF.Name = "txtNIF";
            txtNIF.Size = new Size(184, 33);
            txtNIF.TabIndex = 6;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(85, 88);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(100, 33);
            txtIdade.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(85, 41);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(345, 33);
            txtNome.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 138);
            label4.Name = "label4";
            label4.Size = new Size(127, 25);
            label4.TabIndex = 3;
            label4.Text = "Especialidade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 96);
            label3.Name = "label3";
            label3.Size = new Size(40, 25);
            label3.TabIndex = 2;
            label3.Text = "NIF";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 91);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "Idade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 44);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // fmNovoProfessor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 259);
            Controls.Add(groupBox1);
            Name = "fmNovoProfessor";
            Text = "fmNovoProfessor";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtArea;
        private TextBox txtNIF;
        private TextBox txtIdade;
        private TextBox txtNome;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSair;
        private Button btnLimpar;
        private Button button1;
    }
}