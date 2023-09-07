using System.Text;

namespace Entidades
{
    public class Cuenta
    {
        private string titular;
        private double cantidad;

        public Cuenta(string titular, double cantidad)
        {
            this.cantidad = cantidad;
            this.titular = titular;
        }

        public string Titular
        {
            get
            {
                return this.titular;
            }
        }

        public double Cantitidad
        {
            get
            {
                return this.cantidad;
            }
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Razon social: {this.Titular}");
            sb.AppendLine($"Saldo actual: {this.Cantitidad}");

            return sb.ToString();
        }

        public double Ingresar(double cantidad)
        {
            if (cantidad > 0)
            {
                return this.cantidad += cantidad;
            }
            return this.cantidad;
        }

        public double Retirar(double cantidad)
        {
            return this.cantidad -= cantidad;
        }
    }
}