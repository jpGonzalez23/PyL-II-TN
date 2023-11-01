using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Lapiz : IAcciones
    {
        private float tamanioMina;

        ConsoleColor IAcciones.Color 
        {
            get
            {
                return ConsoleColor.Gray;
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        float IAcciones.UnidadDeEscritura 
        {
            get
            {
                return this.tamanioMina;
            }
            set
            {
                this.tamanioMina = value;
            } 
        }

        public Lapiz(float tanamnioMina)
        {
            this.tamanioMina = tanamnioMina;
        }

        EscrituraWrapper IAcciones.Escribir(string texto)
        {
            this.tamanioMina -=(float) texto.Length *1f;
            return new EscrituraWrapper(((IAcciones)this).Color, texto);
            
        }

        bool IAcciones.Recargar(int unidades) 
        { 
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Es Lapiz");
            sb.AppendLine($"Su color es: {((IAcciones)this).Color}");
            sb.AppendLine($"y su nivel es {((IAcciones)this).UnidadDeEscritura}");

            return sb.ToString();
        }
    }
}
