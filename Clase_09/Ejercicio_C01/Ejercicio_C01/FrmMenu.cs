using Entidades.Modelos;

namespace Ejercicio_C01
{
    public partial class FrmMenu : Form
    {
        protected Centralita centralita;

        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmLlamada_Load(object sender, EventArgs e)
        {
            this.centralita = new Centralita("Telecom");
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador llamador = new FrmLlamador(this.centralita);
            llamador.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MostrarFacturacion()
        {
            FrmMostar informe = new FrmMostar(this.centralita);
            informe.ShowDialog();
        }

        private void btnFacturaTotal_Click(object sender, EventArgs e)
        {
            MostrarFacturacion();
        }

        private void btnFacturaLocal_Click(object sender, EventArgs e)
        {
            MostrarFacturacion();
        }

        private void btnFacturaProvincial_Click(object sender, EventArgs e)
        {
            MostrarFacturacion();
        }
    }
}