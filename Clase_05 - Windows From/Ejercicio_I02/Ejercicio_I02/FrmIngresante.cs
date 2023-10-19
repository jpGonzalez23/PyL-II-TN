using Entidades;
using System.Text;

namespace Ejercicio_I02
{
    public partial class FrmIngresante : Form
    {
        Ingresante ingresante;

        public FrmIngresante()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmIngresante_Load(object sender, EventArgs e)
        {
            this.lstbPaises.DataSource = new object[] { "Argentia", "Chile", "Uruguay" };
            this.rdbtnGeneroUno.Checked = true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Ingresante ingresante;

            string genero = "";
            string[] curso = new string[3];
            int indice = 0;

            if (this.ValidarTextBoxVacios())
            {
                //if (this.lstbPaises.SelectedIndex != -1)
                if (this.lstbPaises.SelectedItem is not null)
                {
                    foreach (Control control in grpbxGenero.Controls)
                    {
                        if (control is RadioButton && ((RadioButton)control).Checked)
                        {
                            genero = control.Text;
                            break;
                        }
                    }

                    foreach (Control control in grpbxCursos.Controls)
                    {
                        if (control is CheckBox && ((CheckBox)control).Checked)
                        {
                            curso[indice] = control.Text;
                            indice++;
                            break;
                        }
                    }

                    ingresante = new Ingresante(this.txtNombre.Text, this.txtDireccion.Text, genero, this.lstbPaises.SelectedItem.ToString(), curso, (int)this.nrupdmEdad.Value);
                }
            }
        }

        /// <summary>
        /// Metodo para validar que no este vacio los textsbox
        /// </summary>
        /// <returns>
        ///     Retorna false si estan vacio los textsbox
        ///     Retorna true si esta completos
        /// </returns>
        private bool ValidarTextBoxVacios()
        {
            StringBuilder sb = new StringBuilder();

            bool esValido = true;

            sb.AppendLine("Se deben completar los siguientes campos:");

            if (string.IsNullOrWhiteSpace(this.txtNombre.Text))
            {
                esValido = false;
                sb.AppendLine("Nombre");
            }

            if (string.IsNullOrWhiteSpace(this.txtDireccion.Text))
            {
                esValido = false;
                sb.AppendLine("Apellido");
            }

            if (!esValido)
            {
                MessageBox.Show(sb.ToString(), "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }


    }
}