using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, EColor color, short cantidadMarchas, int cantidadPasajeros) 
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public short CantidadMarchas { get => this.cantidadMarchas; set => this.cantidadMarchas = value; }
        public int CantidadPasajeros { get => this.cantidadPasajeros; set => this.cantidadPasajeros = value; }
    }
}
