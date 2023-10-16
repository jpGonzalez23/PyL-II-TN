using Entidades;
using Entidades.Execpciones;
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
    public partial class FrmLlamador : Form
    {
        protected Centralita centralita;
        Llamada llamada;

        public FrmLlamador(Centralita c)
        {
            InitializeComponent();
            this.centralita = c;
        }

        public Centralita Llamador
        {
            get { return this.centralita; }
        }

        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            this.cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.EFranja));
        }

        private void txtNumeroDestino_TextChanged(object sender, EventArgs e)
        {
            if (this.txtNumeroDestino.Text.IndexOf('#') == 0)
            {
                this.cmbFranja.Enabled = true;

            }
            else
            {
                this.cmbFranja.Enabled = false;
            }
        }

        private void btnNumero1_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNumero1.Text);
        }

        private void btnNumero2_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNumero2.Text);
        }

        private void btnNumero3_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNumero3.Text);
        }

        private void btnNumero4_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNumero4.Text);
        }

        private void btnNumero5_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNumero5.Text);
        }

        private void btnNumero6_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNumero6.Text);
        }

        private void btnNumero7_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNumero7.Text);
        }

        private void btnNumero8_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNumero8.Text);
        }

        private void btnNumero9_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNumero9.Text);
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNumeral.Text);
        }

        private void btnNumero0_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnNumero0.Text);
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            CargarNumero(this.btnAsterisco.Text);
        }

        private void CargarNumero(string digitoPresionado)
        {
            if (this.txtNumeroDestino.Text == "Nro Destino")
            {
                this.txtNumeroDestino.Text = string.Empty;
            }

            this.txtNumeroDestino.Text += digitoPresionado;

        }

        private void btnLlamador_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            float duracion = (float)random.Next(1, 3600);
            try
            {
                if (this.txtNumeroDestino.Text[0] == '#')
                {
                    llamada = new Provincial(this.txtNumeroOrigen.Text, this.txtNumeroDestino.Text, duracion, (Provincial.EFranja)this.cmbFranja.SelectedItem);
                }
                else
                {
                    Thread.Sleep(2000);
                    float costo = (float)random.Next(1, 100);
                    llamada = new Local(this.txtNumeroOrigen.Text, this.txtNumeroDestino.Text, duracion, costo);
                }
                centralita += llamada;
            }
            catch (CentralicaExcepciones ex)
            {
                MessageBox.Show($"Error: {ex.Message}, Producido en {ex.NombreClase} al momento de {ex.NombreMetodo}", "Error..!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNumeroDestino.Text = "Nro Destino";
            this.txtNumeroOrigen.Text = "Nro Origen";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumeroOrigen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
