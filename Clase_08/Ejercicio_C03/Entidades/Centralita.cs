using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamada;
        protected string razonSocial;

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamada;
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

        public Centralita()
        {
            this.listaDeLlamada = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa) 
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancias(ETipoLlamda tipo)
        {
            float ganancia = 0;

            foreach (Llamada item in listaDeLlamada)
            {
                if (tipo == ETipoLlamda.Local)
                {
                    ganancia += item.Duracion;
                }
                else if (tipo == ETipoLlamda.Provincia)
                {
                    ganancia += item.Duracion;
                }
                else
                {
                    ganancia += item.Duracion;
                }
            }

            return ganancia;
        }

        public void OrdenarLlamadas()
        {

        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Razon social: {this.razonSocial}");
            sb.AppendLine($"Ganancia Local: {this.GananciasPorLocal}");
            sb.AppendLine($"Ganancia Provincial: {this.GananciasPorProvincias}");
            sb.AppendLine($"Ganancia: {this.GananciasTotal}");

            return sb.ToString();
        }
    }
}
