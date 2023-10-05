using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private int dni;
        private List<Comida> menu;

        private Cliente(int dni)
        {
            this.menu = new List<Comida>();
            this.dni = dni;
        }

        private double TotalAPagar
        {
            get
            {
                return (double)this.menu.Count;
            }
        }

        public static implicit operator Cliente(int dni)
        {
            return new Cliente(dni);
        }

        public static Cliente GetCliente(int dni)
        {
            Cliente nuevoCliente = new Cliente(dni);

            return nuevoCliente;
        }
    }
}
