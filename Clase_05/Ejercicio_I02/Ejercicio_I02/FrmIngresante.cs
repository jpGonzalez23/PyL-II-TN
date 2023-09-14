using System.Text;

namespace Ejercicio_I02
{
    public partial class FrmIngresante : Form
    {
        public FrmIngresante()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidarTextBoxVacios())
            {

            }
        }

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

            if (string.IsNullOrWhiteSpace(this.txtApellido.Text))
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