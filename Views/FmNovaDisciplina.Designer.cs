namespace LoginMySQL.Views
{
    partial class FmNovaDisciplina
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
            btnGuardar = new Button();
            btnSair = new Button();
            txtCarga = new TextBox();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            LbInfo = new Label();
            txtPArea = new TextBox();
            txtPNIF = new TextBox();
            txtPIdade = new TextBox();
            txtPNome = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(btnSair);
            groupBox1.Controls.Add(txtCarga);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(1, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 276);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nova Disciplina";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(284, 232);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 33);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(160, 232);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(99, 33);
            btnSair.TabIndex = 6;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // txtCarga
            // 
            txtCarga.Location = new Point(160, 181);
            txtCarga.Name = "txtCarga";
            txtCarga.Size = new Size(224, 33);
            txtCarga.TabIndex = 5;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(93, 125);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(291, 33);
            txtCodigo.TabIndex = 4;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(93, 60);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(291, 33);
            txtNome.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 189);
            label3.Name = "label3";
            label3.Size = new Size(130, 25);
            label3.TabIndex = 2;
            label3.Text = "Carga Horária";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 125);
            label2.Name = "label2";
            label2.Size = new Size(73, 25);
            label2.TabIndex = 1;
            label2.Text = "Código";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 63);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(LbInfo);
            groupBox2.Controls.Add(txtPArea);
            groupBox2.Controls.Add(txtPNIF);
            groupBox2.Controls.Add(txtPIdade);
            groupBox2.Controls.Add(txtPNome);
            groupBox2.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(427, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(345, 276);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Informações do Professor";
            // 
            // LbInfo
            // 
            LbInfo.AutoSize = true;
            LbInfo.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbInfo.Location = new Point(0, 240);
            LbInfo.Name = "LbInfo";
            LbInfo.Size = new Size(12, 17);
            LbInfo.TabIndex = 4;
            LbInfo.Text = ".";
            // 
            // txtPArea
            // 
            txtPArea.Enabled = false;
            txtPArea.Location = new Point(0, 189);
            txtPArea.Name = "txtPArea";
            txtPArea.Size = new Size(339, 33);
            txtPArea.TabIndex = 3;
            // 
            // txtPNIF
            // 
            txtPNIF.Enabled = false;
            txtPNIF.Location = new Point(0, 138);
            txtPNIF.Name = "txtPNIF";
            txtPNIF.Size = new Size(339, 33);
            txtPNIF.TabIndex = 2;
            // 
            // txtPIdade
            // 
            txtPIdade.Enabled = false;
            txtPIdade.Location = new Point(0, 86);
            txtPIdade.Name = "txtPIdade";
            txtPIdade.Size = new Size(339, 33);
            txtPIdade.TabIndex = 1;
            // 
            // txtPNome
            // 
            txtPNome.Enabled = false;
            txtPNome.Location = new Point(0, 32);
            txtPNome.Name = "txtPNome";
            txtPNome.Size = new Size(339, 33);
            txtPNome.TabIndex = 0;
            // 
            // FmNovaDisciplina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(788, 318);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FmNovaDisciplina";
            Text = "Nova Disciplina";
            Load += FmNovaDisciplina_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtCarga;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private TextBox txtPArea;
        private TextBox txtPNIF;
        private TextBox txtPIdade;
        private TextBox txtPNome;
        private Button btnGuardar;
        private Button btnSair;
        private Label LbInfo;
    }
}