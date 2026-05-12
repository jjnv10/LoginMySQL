namespace LoginMySQL.Views
{
    partial class FmTodasMatriculas
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
            DgvMatriculas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DgvMatriculas).BeginInit();
            SuspendLayout();
            // 
            // DgvMatriculas
            // 
            DgvMatriculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvMatriculas.Location = new Point(12, 12);
            DgvMatriculas.Name = "DgvMatriculas";
            DgvMatriculas.Size = new Size(1028, 282);
            DgvMatriculas.TabIndex = 0;
            // 
            // FmTodasMatriculas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 371);
            Controls.Add(DgvMatriculas);
            Name = "FmTodasMatriculas";
            Text = "FmTodasMatriculas";
            Load += FmTodasMatriculas_Load;
            ((System.ComponentModel.ISupportInitialize)DgvMatriculas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvMatriculas;
    }
}