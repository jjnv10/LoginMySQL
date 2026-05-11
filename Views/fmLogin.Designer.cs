namespace LoginMySQL.Views
{
    partial class fmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmLogin));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            btnLogin = new Button();
            button2 = new Button();
            lbInfo = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(113, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 14.25F);
            label1.Location = new Point(17, 111);
            label1.Name = "label1";
            label1.Size = new Size(76, 26);
            label1.TabIndex = 1;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 14.25F);
            label2.Location = new Point(2, 174);
            label2.Name = "label2";
            label2.Size = new Size(91, 26);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI Variable Display", 14.25F);
            txtUsuario.Location = new Point(113, 104);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(341, 33);
            txtUsuario.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI Variable Display", 14.25F);
            txtPassword.Location = new Point(113, 167);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(341, 33);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Historic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(203, 61);
            label3.Name = "label3";
            label3.Size = new Size(96, 37);
            label3.TabIndex = 5;
            label3.Text = "LOGIN";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Tahoma", 14.25F);
            btnLogin.Location = new Point(323, 236);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(131, 41);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Tahoma", 14.25F);
            button2.Location = new Point(184, 236);
            button2.Name = "button2";
            button2.Size = new Size(130, 39);
            button2.TabIndex = 7;
            button2.Text = "Sair";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lbInfo
            // 
            lbInfo.AutoSize = true;
            lbInfo.Location = new Point(6, 216);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(10, 15);
            lbInfo.TabIndex = 8;
            lbInfo.Text = ".";
            // 
            // button1
            // 
            button1.Location = new Point(74, 235);
            button1.Name = "button1";
            button1.Size = new Size(104, 40);
            button1.TabIndex = 9;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 280);
            Controls.Add(button1);
            Controls.Add(lbInfo);
            Controls.Add(button2);
            Controls.Add(btnLogin);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fmLogin";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtPassword;
        private Label label3;
        private Button btnLogin;
        private Button button2;
        private Label lbInfo;
        private Button button1;
    }
}