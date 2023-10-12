using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Enumerado;

namespace Entidades.Modelos
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamada;
        protected string? razonSocial;

        public Centralita()
        {
            listaDeLlamada = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            razonSocial = nombreEmpresa;
        }

        
        public List<Llamada> Llamadas
        {
            get
            {
                return listaDeLlamada;
            }
        }

        public float GananciasPorLocal
        {
            get
            {
                return CalcularGanancias(ETipoLlamda.Local);
            }
        }

        public float GananciasPorProvincias
        {
            get
            {
                return CalcularGanancias(ETipoLlamda.Provincia);
            }
        }

        public float GananciasTotal
        {
            get
            {
                return CalcularGanancias(ETipoLlamda.Todas);
            }
        }

        private float CalcularGanancias(ETipoLlamda tipo)
        {
            float ganancia = 0;

            foreach (Llamada item in listaDeLlamada)
            {
                if (tipo == ETipoLlamda.Local)
                {
                    ganancia *= item.Duracion;
                }
                else if (tipo == ETipoLlamda.Provincia)
                {
                    ganancia *= item.Duracion;
                }
                else
                {
                    ganancia *= item.Duracion;
                }
            }

            return ganancia;
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamada.Sort();
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Razon social: {this.razonSocial}");
            sb.AppendLine($"Ganancia Local: {this.GananciasPorLocal}");
            sb.AppendLine($"Ganancia Provincial: {this.GananciasPorProvincias}");
            sb.AppendLine($"Ganancia: {this.GananciasTotal}");

            return sb.ToString();
        }

        private void AgregarLlamada(Llamada llamadaNueva)
        {
            if (!this.listaDeLlamada.Contains(llamadaNueva))
            {
                this.listaDeLlamada.Add(llamadaNueva);
            }
        }

        public static bool operator ==(Centralita c, Llamada llamada)
        {
            return c.listaDeLlamada.Contains(llamada);
        }

        public static bool operator !=(Centralita c, Llamada llamada)
        {
            return !(c == llamada);
        }

        public static Centralita operator +(Centralita c, Llamada llamada)
        {
            if (c != llamada)
            {
                c.AgregarLlamada(llamada);
            }
            return c;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
