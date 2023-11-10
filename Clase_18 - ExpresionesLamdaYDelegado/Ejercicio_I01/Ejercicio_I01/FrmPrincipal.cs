namespace Ejercicio_I01
{
    public partial class FrmPrincipal : Form
    {
        private FrmTestDelegado frmTest;
        private FrmMostrar frmMostrar;

        public FrmPrincipal()
        {
            InitializeComponent();

        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            frmMostrar = new FrmMostrar();
            frmMostrar.MdiParent = this;

            frmTest = new FrmTestDelegado(frmMostrar.ActualizarNombre);
            frmTest.MdiParent = this;
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void testDelegadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTest.Show();
            mostrarToolStripMenuItem.Enabled = true;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrar.Show();
        }
    }
}