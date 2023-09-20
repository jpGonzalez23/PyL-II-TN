using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PuestoAtencion
    {
        public enum EPuesto
        {
            Caja1,
            Caja2
        };

        public static int numeroActual;
        public EPuesto puesto;

        /// <summary>
        /// Constructor statico para inicializar el puesto en 0
        /// </summary>
        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="puesto">Recibe como parametro el puesto de atención</param>
        public PuestoAtencion(EPuesto puesto)
        {
            this.puesto = puesto;
        }
        
        /// <summary>
        /// Propiedad de lectura del atributo numeroActual
        /// </summary>
        public static int NumeroActual
        {
            get
            {
                return ++PuestoAtencion.numeroActual;
            }
        }

        /// <summary>
        /// Metodo para simular la atención del cliente 
        /// </summary>
        /// <param name="cli">Recibe un cliente a hacer atendido</param>
        /// <returns>
        /// Retorna true si fue atendido
        /// Retorna false si no fue atendido
        /// </returns>
        public bool Atender(Cliente cli)
        {
            if (cli is not null)
            {
                Thread.Sleep(3000);
                return true;
            }
            return false;
        }
    }
}
