namespace Ejercicio_C01
{
    partial class FrmLlamada
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
            btnGenerarLlamada = new Button();
            btnFacturaTotal = new Button();
            btnFacturaLocal = new Button();
            btnFacturaProvincial = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnGenerarLlamada
            // 
            btnGenerarLlamada.Location = new Point(12, 12);
            btnGenerarLlamada.Name = "btnGenerarLlamada";
            btnGenerarLlamada.Size = new Size(168, 60);
            btnGenerarLlamada.TabIndex = 0;
            btnGenerarLlamada.Text = "Generar Llamada";
            btnGenerarLlamada.UseVisualStyleBackColor = true;
            // 
            // btnFacturaTotal
            // 
            btnFacturaTotal.Location = new Point(12, 78);
            btnFacturaTotal.Name = "btnFacturaTotal";
            btnFacturaTotal.Size = new Size(168, 60);
            btnFacturaTotal.TabIndex = 1;
            btnFacturaTotal.Text = "Factura Total";
            btnFacturaTotal.UseVisualStyleBackColor = true;
            // 
            // btnFacturaLocal
            // 
            btnFacturaLocal.Location = new Point(12, 144);
            btnFacturaLocal.Name = "btnFacturaLocal";
            btnFacturaLocal.Size = new Size(168, 60);
            btnFacturaLocal.TabIndex = 2;
            btnFacturaLocal.Text = "Factura Local";
            btnFacturaLocal.UseVisualStyleBackColor = true;
            // 
            // btnFacturaProvincial
            // 
            btnFacturaProvincial.Location = new Point(12, 210);
            btnFacturaProvincial.Name = "btnFacturaProvincial";
            btnFacturaProvincial.Size = new Size(168, 60);
            btnFacturaProvincial.TabIndex = 3;
            btnFacturaProvincial.Text = "Factura Provincial";
            btnFacturaProvincial.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(12, 276);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(168, 60);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // FrmLlamada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(195, 345);
            Controls.Add(btnSalir);
            Controls.Add(btnFacturaProvincial);
            Controls.Add(btnFacturaLocal);
            Controls.Add(btnFacturaTotal);
            Controls.Add(btnGenerarLlamada);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLlamada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Llamada";
            ResumeLayout(false);
        }

        #endregion

        private Button btnGenerarLlamada;
        private Button btnFacturaTotal;
        private Button btnFacturaLocal;
        private Button btnFacturaProvincial;
        private Button btnSalir;
    }
}