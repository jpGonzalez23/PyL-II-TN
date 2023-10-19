namespace Entidades
{
    public class VehiculoTerrestre
    {
        public enum EColor
        {
            Rojo,
            Blanco,
            Azul,
            Gris,
            Negro
        };

        protected short cantidadRuedas;
        protected short cantidadPuertas;
        protected EColor color;

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, EColor color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }

        public short CantidadRuedas
        {
            get { return this.cantidadRuedas; }
            set { this.cantidadRuedas = value; }
        }

        public short CantidadPuertas 
        {
            get { return this.cantidadPuertas; }
            set { this.cantidadPuertas = value; }
        }

        public EColor Color
        {
            get { return this.color; }
            set { this.color = value; }
        }
    }
}