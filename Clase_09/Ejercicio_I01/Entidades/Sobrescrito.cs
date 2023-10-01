namespace Entidades
{
    public class Sobrescrito
    {

        protected string miAtributo;

        public Sobrescrito()
        {
            this.miAtributo = "Este es mi atributo";
        }

        public string MiAtributo { get { return this.miAtributo; } }

        public override string ToString()
        {
            return "Este es mi metedo ToString Sobrecargado";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            // Verificar si el objeto es del mismo tipo (de la clase Sobrescrito)
            return obj.GetType() == this.GetType();
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }
    }
}