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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            textBox4 = new TextBox();
            cbActivo = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbActivo);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(519, 356);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Novo Utilizador";
            // 
            // button1
            // 
            button1.Location = new Point(419, 317);
            button1.Name = "button1";
            button1.Size = new Size(93, 35);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(303, 317);
            button2.Name = "button2";
            button2.Size = new Size(93, 35);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 108);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 208);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 4;
            label3.Text = "Utilizador";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(78, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(434, 33);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(78, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(434, 33);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(91, 200);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(199, 33);
            textBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 208);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 8;
            label4.Text = "Role";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Administrador", "Professor", "Estudante" });
            comboBox1.Location = new Point(351, 200);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(162, 33);
            comboBox1.TabIndex = 9;
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
            // textBox4
            // 
            textBox4.Location = new Point(107, 154);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(405, 33);
            textBox4.TabIndex = 11;
            textBox4.UseSystemPasswordChar = true;
            // 
            // cbActivo
            // 
            cbActivo.AutoSize = true;
            cbActivo.Location = new Point(351, 256);
            cbActivo.Name = "cbActivo";
            cbActivo.Size = new Size(131, 29);
            cbActivo.TabIndex = 12;
            cbActivo.Text = "Está Activo?";
            cbActivo.UseVisualStyleBackColor = true;
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
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private CheckBox cbActivo;
        private TextBox textBox4;
        private Label label5;
    }
}