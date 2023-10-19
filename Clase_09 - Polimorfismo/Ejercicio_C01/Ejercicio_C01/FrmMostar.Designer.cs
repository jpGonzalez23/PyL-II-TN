namespace Ejercicio_C01
{
    partial class FrmMostar
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
            rchtTextInformer = new RichTextBox();
            SuspendLayout();
            // 
            // rchtTextInformer
            // 
            rchtTextInformer.Location = new Point(12, 12);
            rchtTextInformer.Name = "rchtTextInformer";
            rchtTextInformer.Size = new Size(410, 255);
            rchtTextInformer.TabIndex = 0;
            rchtTextInformer.Text = "";
            // 
            // FrmMostar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 280);
            Controls.Add(rchtTextInformer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMostar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMostrar";
            Load += FrmMostar_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rchtTextInformer;
    }
}