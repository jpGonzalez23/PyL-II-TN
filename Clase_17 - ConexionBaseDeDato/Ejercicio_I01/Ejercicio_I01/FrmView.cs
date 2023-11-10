using Entidades.BD;
using Entidades.Modelos;

namespace Ejercicio_I01
{
    public partial class FrmView : Form
    {
        private Persona persona;
        private PersonaDAO personaDAO;
        public FrmView()
        {
            InitializeComponent();
            this.personaDAO = new PersonaDAO();
            this.persona = null;
        }

        private void FrmView_Load(object sender, EventArgs e)
        {
            //this.ActualizarListBox();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != null && this.txtApellido.Text != null)
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                this.persona = new Persona(nombre, apellido);
                personaDAO.Guardar(this.persona);
                //ActualizarListBox();
                //LimpiarCampos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //if (persona != null)
            //{
            //    int id = persona.Id;
            //    personaDAO.el(id);
            //    ActualizarListBox();
            //    LimpiarCampos();
            //}
        }

        private void btnLeerPorId_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //if (persona != null)
            //{
            //    persona.Nombre = txtNombre.Text;
            //    persona.Apellido = txtApellido.Text;
            //    personaDAO.Modificar(persona);
            //    ActualizarListBox();
            //    LimpiarCampos();
            //}
        }

        private void ActualizarListBox()
        {
            //lstPersona.DataSource = null;
            //lstPersona.DataSource = personaDAO.Leer();
            //LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            //txtNombre.Text = "";
            //txtApellido.Text = "";
            //persona = null;
        }

        
    }
}