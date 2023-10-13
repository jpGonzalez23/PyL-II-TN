namespace Ejercicio_I02
{
    partial class FrmView
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
            lblKilometro = new Label();
            txtKilometro = new TextBox();
            txtLitros = new TextBox();
            lblLitros = new Label();
            btnCalcular = new Button();
            rchtMostrar = new RichTextBox();
            SuspendLayout();
            // 
            // lblKilometro
            // 
            lblKilometro.AutoSize = true;
            lblKilometro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblKilometro.Location = new Point(12, 9);
            lblKilometro.Name = "lblKilometro";
            lblKilometro.Size = new Size(78, 21);
            lblKilometro.TabIndex = 0;
            lblKilometro.Text = "Kilometro";
            // 
            // txtKilometro
            // 
            txtKilometro.Location = new Point(12, 38);
            txtKilometro.Name = "txtKilometro";
            txtKilometro.Size = new Size(179, 23);
            txtKilometro.TabIndex = 1;
            // 
            // txtLitros
            // 
            txtLitros.Location = new Point(12, 93);
            txtLitros.Name = "txtLitros";
            txtLitros.Size = new Size(179, 23);
            txtLitros.TabIndex = 3;
            // 
            // lblLitros
            // 
            lblLitros.AutoSize = true;
            lblLitros.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLitros.Location = new Point(12, 64);
            lblLitros.Name = "lblLitros";
            lblLitros.Size = new Size(49, 21);
            lblLitros.TabIndex = 2;
            lblLitros.Text = "Litros";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(12, 122);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(179, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // rchtMostrar
            // 
            rchtMostrar.Location = new Point(221, 9);
            rchtMostrar.Name = "rchtMostrar";
            rchtMostrar.ReadOnly = true;
            rchtMostrar.Size = new Size(170, 107);
            rchtMostrar.TabIndex = 5;
            rchtMostrar.Text = "";
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(412, 154);
            Controls.Add(rchtMostrar);
            Controls.Add(btnCalcular);
            Controls.Add(txtLitros);
            Controls.Add(lblLitros);
            Controls.Add(txtKilometro);
            Controls.Add(lblKilometro);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calcular";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblKilometro;
        private TextBox txtKilometro;
        private TextBox txtLitros;
        private Label lblLitros;
        private Button btnCalcular;
        private RichTextBox rchtMostrar;
    }
}