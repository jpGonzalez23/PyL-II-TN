namespace Ejercicio_C01
{
    partial class FrmLlamador
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
            txtNumeroDestino = new TextBox();
            grpTeclado = new GroupBox();
            btnAsterisco = new Button();
            btnNumero0 = new Button();
            btnNumeral = new Button();
            btnNumero9 = new Button();
            btnNumero8 = new Button();
            btnNumero7 = new Button();
            btnNumero6 = new Button();
            btnNumero5 = new Button();
            btnNumero4 = new Button();
            btnNumero3 = new Button();
            btnNumero2 = new Button();
            btnNumero1 = new Button();
            btnLlamador = new Button();
            btnLimpiar = new Button();
            txtNumeroOrigen = new TextBox();
            btnSalir = new Button();
            cmbFranja = new ComboBox();
            grpTeclado.SuspendLayout();
            SuspendLayout();
            // 
            // txtNumeroDestino
            // 
            txtNumeroDestino.Location = new Point(12, 12);
            txtNumeroDestino.Name = "txtNumeroDestino";
            txtNumeroDestino.Size = new Size(389, 23);
            txtNumeroDestino.TabIndex = 0;
            txtNumeroDestino.TextChanged += txtNumeroDestino_TextChanged;
            // 
            // grpTeclado
            // 
            grpTeclado.Controls.Add(btnAsterisco);
            grpTeclado.Controls.Add(btnNumero0);
            grpTeclado.Controls.Add(btnNumeral);
            grpTeclado.Controls.Add(btnNumero9);
            grpTeclado.Controls.Add(btnNumero8);
            grpTeclado.Controls.Add(btnNumero7);
            grpTeclado.Controls.Add(btnNumero6);
            grpTeclado.Controls.Add(btnNumero5);
            grpTeclado.Controls.Add(btnNumero4);
            grpTeclado.Controls.Add(btnNumero3);
            grpTeclado.Controls.Add(btnNumero2);
            grpTeclado.Controls.Add(btnNumero1);
            grpTeclado.Location = new Point(12, 41);
            grpTeclado.Name = "grpTeclado";
            grpTeclado.Size = new Size(226, 140);
            grpTeclado.TabIndex = 1;
            grpTeclado.TabStop = false;
            grpTeclado.Text = "Panel";
            // 
            // btnAsterisco
            // 
            btnAsterisco.Location = new Point(165, 109);
            btnAsterisco.Name = "btnAsterisco";
            btnAsterisco.Size = new Size(55, 23);
            btnAsterisco.TabIndex = 17;
            btnAsterisco.Text = "#";
            btnAsterisco.UseVisualStyleBackColor = true;
            btnAsterisco.Click += btnAsterisco_Click;
            // 
            // btnNumero0
            // 
            btnNumero0.Location = new Point(86, 109);
            btnNumero0.Name = "btnNumero0";
            btnNumero0.Size = new Size(55, 23);
            btnNumero0.TabIndex = 16;
            btnNumero0.Text = "0";
            btnNumero0.UseVisualStyleBackColor = true;
            btnNumero0.Click += btnNumero0_Click;
            // 
            // btnNumeral
            // 
            btnNumeral.Location = new Point(6, 109);
            btnNumeral.Name = "btnNumeral";
            btnNumeral.Size = new Size(55, 23);
            btnNumeral.TabIndex = 15;
            btnNumeral.Text = "*";
            btnNumeral.UseVisualStyleBackColor = true;
            btnNumeral.Click += btnNumeral_Click;
            // 
            // btnNumero9
            // 
            btnNumero9.Location = new Point(165, 80);
            btnNumero9.Name = "btnNumero9";
            btnNumero9.Size = new Size(55, 23);
            btnNumero9.TabIndex = 14;
            btnNumero9.Text = "9";
            btnNumero9.UseVisualStyleBackColor = true;
            btnNumero9.Click += btnNumero9_Click;
            // 
            // btnNumero8
            // 
            btnNumero8.Location = new Point(86, 80);
            btnNumero8.Name = "btnNumero8";
            btnNumero8.Size = new Size(55, 23);
            btnNumero8.TabIndex = 13;
            btnNumero8.Text = "8";
            btnNumero8.UseVisualStyleBackColor = true;
            btnNumero8.Click += btnNumero8_Click;
            // 
            // btnNumero7
            // 
            btnNumero7.Location = new Point(6, 80);
            btnNumero7.Name = "btnNumero7";
            btnNumero7.RightToLeft = RightToLeft.No;
            btnNumero7.Size = new Size(55, 23);
            btnNumero7.TabIndex = 12;
            btnNumero7.Text = "7";
            btnNumero7.UseVisualStyleBackColor = true;
            btnNumero7.Click += btnNumero7_Click;
            // 
            // btnNumero6
            // 
            btnNumero6.Location = new Point(165, 51);
            btnNumero6.Name = "btnNumero6";
            btnNumero6.Size = new Size(55, 23);
            btnNumero6.TabIndex = 11;
            btnNumero6.Text = "6";
            btnNumero6.UseVisualStyleBackColor = true;
            btnNumero6.Click += btnNumero6_Click;
            // 
            // btnNumero5
            // 
            btnNumero5.Location = new Point(86, 51);
            btnNumero5.Name = "btnNumero5";
            btnNumero5.Size = new Size(55, 23);
            btnNumero5.TabIndex = 10;
            btnNumero5.Text = "5";
            btnNumero5.UseVisualStyleBackColor = true;
            btnNumero5.Click += btnNumero5_Click;
            // 
            // btnNumero4
            // 
            btnNumero4.Location = new Point(6, 51);
            btnNumero4.Name = "btnNumero4";
            btnNumero4.Size = new Size(55, 23);
            btnNumero4.TabIndex = 9;
            btnNumero4.Text = "4";
            btnNumero4.UseVisualStyleBackColor = true;
            btnNumero4.Click += btnNumero4_Click;
            // 
            // btnNumero3
            // 
            btnNumero3.Location = new Point(165, 22);
            btnNumero3.Name = "btnNumero3";
            btnNumero3.Size = new Size(55, 23);
            btnNumero3.TabIndex = 8;
            btnNumero3.Text = "3";
            btnNumero3.UseVisualStyleBackColor = true;
            btnNumero3.Click += btnNumero3_Click;
            // 
            // btnNumero2
            // 
            btnNumero2.Location = new Point(86, 22);
            btnNumero2.Name = "btnNumero2";
            btnNumero2.Size = new Size(55, 23);
            btnNumero2.TabIndex = 7;
            btnNumero2.Text = "2";
            btnNumero2.UseVisualStyleBackColor = true;
            btnNumero2.Click += btnNumero2_Click;
            // 
            // btnNumero1
            // 
            btnNumero1.Location = new Point(6, 22);
            btnNumero1.Name = "btnNumero1";
            btnNumero1.Size = new Size(55, 23);
            btnNumero1.TabIndex = 6;
            btnNumero1.Text = "1";
            btnNumero1.UseVisualStyleBackColor = true;
            btnNumero1.Click += btnNumero1_Click;
            // 
            // btnLlamador
            // 
            btnLlamador.Location = new Point(244, 51);
            btnLlamador.Name = "btnLlamador";
            btnLlamador.Size = new Size(157, 23);
            btnLlamador.TabIndex = 0;
            btnLlamador.Text = "Llamar";
            btnLlamador.UseVisualStyleBackColor = true;
            btnLlamador.Click += btnLlamador_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(244, 80);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(157, 23);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtNumeroOrigen
            // 
            txtNumeroOrigen.Location = new Point(244, 121);
            txtNumeroOrigen.Name = "txtNumeroOrigen";
            txtNumeroOrigen.Size = new Size(157, 23);
            txtNumeroOrigen.TabIndex = 3;
            txtNumeroOrigen.KeyPress += txtNumeroOrigen_KeyPress;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(244, 158);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(157, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // cmbFranja
            // 
            cmbFranja.FormattingEnabled = true;
            cmbFranja.Location = new Point(11, 187);
            cmbFranja.Name = "cmbFranja";
            cmbFranja.Size = new Size(390, 23);
            cmbFranja.TabIndex = 5;
            cmbFranja.Text = "Franja";
            // 
            // FrmLlamador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 219);
            Controls.Add(cmbFranja);
            Controls.Add(btnSalir);
            Controls.Add(txtNumeroOrigen);
            Controls.Add(btnLimpiar);
            Controls.Add(btnLlamador);
            Controls.Add(grpTeclado);
            Controls.Add(txtNumeroDestino);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FrmLlamador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMostrar";
            Load += FrmLlamador_Load;
            grpTeclado.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumeroDestino;
        private GroupBox grpTeclado;
        private Button btnNumero9;
        private Button btnNumero8;
        private Button btnNumero7;
        private Button btnNumero6;
        private Button btnNumero5;
        private Button btnNumero4;
        private Button btnNumero3;
        private Button btnNumero2;
        private Button btnNumero1;
        private Button btnLlamador;
        private Button btnLimpiar;
        private TextBox txtNumeroOrigen;
        private Button btnSalir;
        private ComboBox cmbFranja;
        private Button btnAsterisco;
        private Button btnNumero0;
        private Button btnNumeral;
    }
}