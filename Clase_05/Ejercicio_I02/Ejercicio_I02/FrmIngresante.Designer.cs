namespace Ejercicio_I02
{
    partial class FrmIngresante
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
            gpbxDetalles = new GroupBox();
            nrupdmEdad = new NumericUpDown();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            lblEdad = new Label();
            lblApelido = new Label();
            lblNombre = new Label();
            grpbxGenero = new GroupBox();
            rdbtnGeneroTres = new RadioButton();
            rdbtnGeneroDos = new RadioButton();
            rdbtnGeneroUno = new RadioButton();
            grpbxCursos = new GroupBox();
            chckCursoTres = new CheckBox();
            chckCursoDos = new CheckBox();
            chckCursoUno = new CheckBox();
            lstbPaises = new ListBox();
            btnIngresar = new Button();
            lblPais = new Label();
            gpbxDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nrupdmEdad).BeginInit();
            grpbxGenero.SuspendLayout();
            grpbxCursos.SuspendLayout();
            SuspendLayout();
            // 
            // gpbxDetalles
            // 
            gpbxDetalles.Controls.Add(nrupdmEdad);
            gpbxDetalles.Controls.Add(txtApellido);
            gpbxDetalles.Controls.Add(txtNombre);
            gpbxDetalles.Controls.Add(lblEdad);
            gpbxDetalles.Controls.Add(lblApelido);
            gpbxDetalles.Controls.Add(lblNombre);
            gpbxDetalles.Location = new Point(12, 12);
            gpbxDetalles.Name = "gpbxDetalles";
            gpbxDetalles.Size = new Size(200, 100);
            gpbxDetalles.TabIndex = 0;
            gpbxDetalles.TabStop = false;
            gpbxDetalles.Text = "Detalles del usuario";
            // 
            // nrupdmEdad
            // 
            nrupdmEdad.Location = new Point(74, 73);
            nrupdmEdad.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            nrupdmEdad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nrupdmEdad.Name = "nrupdmEdad";
            nrupdmEdad.Size = new Size(120, 23);
            nrupdmEdad.TabIndex = 7;
            nrupdmEdad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(74, 43);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(120, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(74, 16);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(120, 23);
            txtNombre.TabIndex = 3;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(6, 73);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 5;
            lblEdad.Text = "Edad";
            // 
            // lblApelido
            // 
            lblApelido.AutoSize = true;
            lblApelido.Location = new Point(6, 46);
            lblApelido.Name = "lblApelido";
            lblApelido.Size = new Size(51, 15);
            lblApelido.TabIndex = 4;
            lblApelido.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(6, 19);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // grpbxGenero
            // 
            grpbxGenero.Controls.Add(rdbtnGeneroTres);
            grpbxGenero.Controls.Add(rdbtnGeneroDos);
            grpbxGenero.Controls.Add(rdbtnGeneroUno);
            grpbxGenero.Location = new Point(241, 12);
            grpbxGenero.Name = "grpbxGenero";
            grpbxGenero.Size = new Size(106, 100);
            grpbxGenero.TabIndex = 1;
            grpbxGenero.TabStop = false;
            grpbxGenero.Text = "Género";
            // 
            // rdbtnGeneroTres
            // 
            rdbtnGeneroTres.AutoSize = true;
            rdbtnGeneroTres.Location = new Point(6, 71);
            rdbtnGeneroTres.Name = "rdbtnGeneroTres";
            rdbtnGeneroTres.Size = new Size(49, 19);
            rdbtnGeneroTres.TabIndex = 2;
            rdbtnGeneroTres.TabStop = true;
            rdbtnGeneroTres.Text = "Otro";
            rdbtnGeneroTres.UseVisualStyleBackColor = true;
            // 
            // rdbtnGeneroDos
            // 
            rdbtnGeneroDos.AutoSize = true;
            rdbtnGeneroDos.Location = new Point(6, 46);
            rdbtnGeneroDos.Name = "rdbtnGeneroDos";
            rdbtnGeneroDos.Size = new Size(56, 19);
            rdbtnGeneroDos.TabIndex = 1;
            rdbtnGeneroDos.TabStop = true;
            rdbtnGeneroDos.Text = "Mujer";
            rdbtnGeneroDos.UseVisualStyleBackColor = true;
            // 
            // rdbtnGeneroUno
            // 
            rdbtnGeneroUno.AutoSize = true;
            rdbtnGeneroUno.Location = new Point(6, 22);
            rdbtnGeneroUno.Name = "rdbtnGeneroUno";
            rdbtnGeneroUno.Size = new Size(69, 19);
            rdbtnGeneroUno.TabIndex = 0;
            rdbtnGeneroUno.TabStop = true;
            rdbtnGeneroUno.Text = "Hombre";
            rdbtnGeneroUno.UseVisualStyleBackColor = true;
            // 
            // grpbxCursos
            // 
            grpbxCursos.Controls.Add(chckCursoTres);
            grpbxCursos.Controls.Add(chckCursoDos);
            grpbxCursos.Controls.Add(chckCursoUno);
            grpbxCursos.Location = new Point(241, 118);
            grpbxCursos.Name = "grpbxCursos";
            grpbxCursos.Size = new Size(106, 100);
            grpbxCursos.TabIndex = 1;
            grpbxCursos.TabStop = false;
            grpbxCursos.Text = "Cursos";
            // 
            // chckCursoTres
            // 
            chckCursoTres.AutoSize = true;
            chckCursoTres.Location = new Point(6, 72);
            chckCursoTres.Name = "chckCursoTres";
            chckCursoTres.Size = new Size(83, 19);
            chckCursoTres.TabIndex = 2;
            chckCursoTres.Text = "checkBox3";
            chckCursoTres.UseVisualStyleBackColor = true;
            // 
            // chckCursoDos
            // 
            chckCursoDos.AutoSize = true;
            chckCursoDos.Location = new Point(6, 47);
            chckCursoDos.Name = "chckCursoDos";
            chckCursoDos.Size = new Size(64, 19);
            chckCursoDos.TabIndex = 1;
            chckCursoDos.Text = "Python";
            chckCursoDos.UseVisualStyleBackColor = true;
            // 
            // chckCursoUno
            // 
            chckCursoUno.AutoSize = true;
            chckCursoUno.Location = new Point(6, 22);
            chckCursoUno.Name = "chckCursoUno";
            chckCursoUno.Size = new Size(78, 19);
            chckCursoUno.TabIndex = 0;
            chckCursoUno.Text = "JavaScript";
            chckCursoUno.UseVisualStyleBackColor = true;
            // 
            // lstbPaises
            // 
            lstbPaises.FormattingEnabled = true;
            lstbPaises.ItemHeight = 15;
            lstbPaises.Location = new Point(12, 136);
            lstbPaises.Name = "lstbPaises";
            lstbPaises.Size = new Size(200, 94);
            lstbPaises.TabIndex = 2;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(241, 227);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(106, 23);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(12, 118);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(28, 15);
            lblPais.TabIndex = 8;
            lblPais.Text = "País";
            // 
            // FrmIngresante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 270);
            Controls.Add(lblPais);
            Controls.Add(btnIngresar);
            Controls.Add(lstbPaises);
            Controls.Add(grpbxCursos);
            Controls.Add(grpbxGenero);
            Controls.Add(gpbxDetalles);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmIngresante";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario Ingresante";
            gpbxDetalles.ResumeLayout(false);
            gpbxDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nrupdmEdad).EndInit();
            grpbxGenero.ResumeLayout(false);
            grpbxGenero.PerformLayout();
            grpbxCursos.ResumeLayout(false);
            grpbxCursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gpbxDetalles;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label lblEdad;
        private Label lblApelido;
        private Label lblNombre;
        private GroupBox grpbxGenero;
        private GroupBox grpbxCursos;
        private ListBox lstbPaises;
        private NumericUpDown nrupdmEdad;
        private RadioButton rdbtnGeneroTres;
        private RadioButton rdbtnGeneroDos;
        private RadioButton rdbtnGeneroUno;
        private CheckBox chckCursoTres;
        private CheckBox chckCursoDos;
        private CheckBox chckCursoUno;
        private Button btnIngresar;
        private Label lblPais;
    }
}