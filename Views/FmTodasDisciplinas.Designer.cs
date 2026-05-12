namespace LoginMySQL.Views
{
    partial class FmTodasDisciplinas
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
            ((System.ComponentModel.ISupportInitialize)DgvDisciplinas).BeginInit();
            SuspendLayout();
            // 
            // DgvDisciplinas
            // 
            DgvDisciplinas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvDisciplinas.Location = new Point(3, 1);
            DgvDisciplinas.Name = "DgvDisciplinas";
            DgvDisciplinas.Size = new Size(699, 300);
            DgvDisciplinas.TabIndex = 0;
            // 
            // FmTodasDisciplinas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 349);
            Controls.Add(DgvDisciplinas);
            Name = "FmTodasDisciplinas";
            Text = "FmTodasDisciplinas";
            Load += FmTodasDisciplinas_Load;
            ((System.ComponentModel.ISupportInitialize)DgvDisciplinas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvDisciplinas;
    }
}