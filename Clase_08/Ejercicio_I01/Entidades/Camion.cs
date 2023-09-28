using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion : VehiculoTerrestre
    {
        private short cantidadMarcha;
        private int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, EColor color, short cantidadMarcha, int pesoCarga)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarcha = cantidadMarcha;
            this.pesoCarga = pesoCarga;
        }

        public short CantidadMarcha { get => this.cantidadMarcha; set => this.cantidadMarcha = value; }
        public int PesoCarga { get => this.pesoCarga; set => this.pesoCarga = value; }
    }
}
