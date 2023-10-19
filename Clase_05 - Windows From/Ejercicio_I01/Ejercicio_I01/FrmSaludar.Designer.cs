namespace Ejercicio_I01
{
    partial class FrmSaludar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombre = new Label();
            lblApellido = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            btnSaludar = new Button();
            cmbMateria = new ComboBox();
            lblMateria = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombre.Location = new Point(12, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(86, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblApellido.Location = new Point(212, 9);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(86, 25);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 37);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(160, 23);
            txtNombre.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(212, 37);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(160, 23);
            txtApellido.TabIndex = 3;
            // 
            // btnSaludar
            // 
            btnSaludar.Location = new Point(297, 100);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(75, 23);
            btnSaludar.TabIndex = 4;
            btnSaludar.Text = "Saludar";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // cmbMateria
            // 
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new Point(12, 100);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new Size(236, 23);
            cmbMateria.TabIndex = 5;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblMateria.Location = new Point(12, 72);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(80, 25);
            lblMateria.TabIndex = 6;
            lblMateria.Text = "Materia";
            // 
            // FrmSaludar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 135);
            Controls.Add(lblMateria);
            Controls.Add(cmbMateria);
            Controls.Add(btnSaludar);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSaludar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Saludar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Button btnSaludar;
        private ComboBox cmbMateria;
        private Label lblMateria;
    }
}