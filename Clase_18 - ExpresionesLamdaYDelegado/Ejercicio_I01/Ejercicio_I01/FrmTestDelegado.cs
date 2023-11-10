using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_I01
{
    public delegate void ActualizarNombreDelegate(string nombre);

    public partial class FrmTestDelegado : Form
    {
        private ActualizarNombreDelegate actualizarNombre;

        public FrmTestDelegado(ActualizarNombreDelegate actualizarNombre)
        {
            InitializeComponent();
            this.actualizarNombre = actualizarNombre;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            actualizarNombre.Invoke(this.txtNombre.Text);
        }
    }
}
