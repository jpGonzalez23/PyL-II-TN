using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class OtraClase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="MiExcepcion"></exception>
        public void Metodo()
        {
            try
            {
                var mc = new MiClase(200);
            }
            catch (UnaExcepcion ex)
            {
                throw new MiExcepcion("Error en OtraClase.Metodo() que lanza MiExcepcion.", ex);
            }
        }
    }
}
