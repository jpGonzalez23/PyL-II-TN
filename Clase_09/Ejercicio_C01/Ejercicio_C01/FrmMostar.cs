using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_C01
{
    public partial class FrmMostar : Form
    {
        public FrmMostar(Centralita c)
        {
            InitializeComponent();
            this.rchtTextInformer.Text = c.ToString();
        }

        private void FrmMostar_Load(object sender, EventArgs e)
        {

        }
    }
}
