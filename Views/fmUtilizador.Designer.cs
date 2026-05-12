namespace LoginMySQL.Views
{
    partial class fmUtilizador
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
            chkVerPassword = new CheckBox();
            chkActivo = new CheckBox();
            txtPassword = new TextBox();
            label5 = new Label();
            cbRole = new ComboBox();
            label4 = new Label();
            txtUtilizador = new TextBox();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            LbInfo = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(LbInfo);
            groupBox1.Controls.Add(chkVerPassword);
            groupBox1.Controls.Add(chkActivo);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cbRole);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtUtilizador);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(519, 356);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Novo Utilizador";
            // 
            // chkVerPassword
            // 
            chkVerPassword.AutoSize = true;
            chkVerPassword.Location = new Point(330, 190);
            chkVerPassword.Name = "chkVerPassword";
            chkVerPassword.Size = new Size(182, 29);
            chkVerPassword.TabIndex = 13;
            chkVerPassword.Text = "Mostrar Password";
            chkVerPassword.UseVisualStyleBackColor = true;
            chkVerPassword.CheckedChanged += chbVerPassword_CheckedChanged;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(330, 264);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(131, 29);
            chkActivo.TabIndex = 12;
            chkActivo.Text = "Está Activo?";
            chkActivo.UseVisualStyleBackColor = true;
            chkActivo.CheckedChanged += cbActivo_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(107, 154);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(405, 33);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 157);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Administrador", "Professor", "Estudante" });
            cbRole.Location = new Point(351, 225);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(162, 33);
            cbRole.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 233);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 8;
            label4.Text = "Role";
            // 
            // txtUtilizador
            // 
            txtUtilizador.Location = new Point(91, 225);
            txtUtilizador.Name = "txtUtilizador";
            txtUtilizador.Size = new Size(199, 33);
            txtUtilizador.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(78, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(434, 33);
            txtEmail.TabIndex = 6;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(78, 47);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(434, 33);
            txtNome.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 233);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 4;
            label3.Text = "Utilizador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 108);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 55);
            label1.Name = "label1";
            label1.Size = new Size(63, 25);
            label1.TabIndex = 2;
            label1.Text = "Nome";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(303, 317);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 35);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Transparent;
            btnGuardar.FlatStyle = FlatStyle.System;
            btnGuardar.ForeColor = SystemColors.ActiveCaptionText;
            btnGuardar.Location = new Point(419, 317);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(93, 35);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // LbInfo
            // 
            LbInfo.AutoSize = true;
            LbInfo.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LbInfo.Location = new Point(4, 289);
            LbInfo.Name = "LbInfo";
            LbInfo.Size = new Size(11, 17);
            LbInfo.TabIndex = 14;
            LbInfo.Text = ".";
            // 
            // fmUtilizador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 366);
            Controls.Add(groupBox1);
            Name = "fmUtilizador";
            Text = "fmUtilizador";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtUtilizador;
        private TextBox txtEmail;
        private TextBox txtNome;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnGuardar;
        private ComboBox cbRole;
        private CheckBox chkActivo;
        private TextBox txtPassword;
        private Label label5;
        private CheckBox chkVerPassword;
        private Label LbInfo;
    }
}