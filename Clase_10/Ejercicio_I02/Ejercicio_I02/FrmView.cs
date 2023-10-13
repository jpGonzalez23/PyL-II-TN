using Entidades;

namespace Ejercicio_I02
{
    public partial class FrmView : Form
    {
        public FrmView()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtKilometro.Text == "" || this.txtLitros.Text == "")
                {
                    throw new ParametroVacioException("Algun campo esta vacio");
                }

                this.rchtMostrar.Text = $"km/ litro: {Calculadora.Calcular(int.Parse(this.txtKilometro.Text), int.Parse(this.txtLitros.Text))}";
            }
            catch (ParametroVacioException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}