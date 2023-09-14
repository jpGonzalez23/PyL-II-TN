using System.Text;

namespace Ejercicio_I01
{
    public partial class FrmSaludar : Form
    {
        /// <summary>
        /// Constructor para inicializar
        /// </summary>
        public FrmSaludar()
        {
            InitializeComponent();
            cmbMateria.Items.Add("Seleccione una materia....");
            cmbMateria.Items.Add("Programaci�n I");
            cmbMateria.Items.Add("Laboratorio de Computaci�n I");
            cmbMateria.Items.Add("Sistema de procesamiento de datos");
            cmbMateria.Items.Add("Ingl�s I");
            cmbMateria.Items.Add("Matem�tica");
            cmbMateria.Items.Add("Programaci�n II");
            cmbMateria.Items.Add("Laboratorio de Computaci�n II");
            cmbMateria.Items.Add("Ingl�s II");
            cmbMateria.Items.Add("Metodolog�a de la investigaci�n");
            cmbMateria.Items.Add("Arquitectura y sistemas operativos");
            cmbMateria.Items.Add("Estad�stica");
            cmbMateria.SelectedIndex = 0;
        }

        /// <summary>
        /// Metodo del evento btnSaludar_Clik
        /// </summary>
        /// <param name="sender">Recibe un objeto</param>
        /// <param name="e">Recibe un Evento</param>
        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string titulo = "Hola Windows Froms";
            string mensaje = $"Soy {this.txtNombre.Text} {this.txtApellido.Text}, y mi materia favorita es {this.cmbMateria.SelectedItem}";

            if (this.Validar())
            {
                FrmMensaje frmMensaje = new FrmMensaje(titulo, mensaje);
                frmMensaje.ShowDialog();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private bool Validar()
        {
            bool esValido = true;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Se deben completar los siguientes campos:");

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                esValido = false;
                sb.AppendLine("Nombre");
            }

            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                esValido = false;
                sb.AppendLine("Apellido");
            }

            if (!esValido)
            {
                MessageBox.Show(sb.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }
    }
}