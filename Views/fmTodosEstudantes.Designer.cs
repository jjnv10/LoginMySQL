namespace Menu.Vistas
{
    partial class fmTodosEstudantes
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
            btnFechar = new Button();
            DgVEstudantes = new DataGridView();
            btnMatricular = new Button();
            LbInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)DgVEstudantes).BeginInit();
            SuspendLayout();
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFechar.Location = new Point(613, 281);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(130, 38);
            btnFechar.TabIndex = 1;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // DgVEstudantes
            // 
            DgVEstudantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgVEstudantes.Location = new Point(12, 12);
            DgVEstudantes.Name = "DgVEstudantes";
            DgVEstudantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgVEstudantes.Size = new Size(731, 263);
            DgVEstudantes.TabIndex = 2;
            DgVEstudantes.CellContentClick += DgVEstudantes_CellContentClick;
            // 
            // btnMatricular
            // 
            btnMatricular.Font = new Font("Segoe UI Variable Display", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMatricular.Location = new Point(492, 281);
            btnMatricular.Name = "btnMatricular";
            btnMatricular.Size = new Size(115, 33);
            btnMatricular.TabIndex = 3;
            btnMatricular.Text = "Matricular";
            btnMatricular.UseVisualStyleBackColor = true;
            btnMatricular.Click += btnMatricular_Click;
            // 
            // LbInfo
            // 
            LbInfo.AutoSize = true;
            LbInfo.Location = new Point(17, 298);
            LbInfo.Name = "LbInfo";
            LbInfo.Size = new Size(10, 15);
            LbInfo.TabIndex = 4;
            LbInfo.Text = ".";
            // 
            // fmTodosEstudantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 326);
            Controls.Add(LbInfo);
            Controls.Add(btnMatricular);
            Controls.Add(DgVEstudantes);
            Controls.Add(btnFechar);
            Name = "fmTodosEstudantes";
            Text = "fmTodosEstudantes";
            Load += fmTodosEstudantes_Load;
            ((System.ComponentModel.ISupportInitialize)DgVEstudantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnFechar;
        private DataGridView DgVEstudantes;
        private Button btnMatricular;
        private Label LbInfo;
    }
}