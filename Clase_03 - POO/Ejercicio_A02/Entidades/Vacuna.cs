﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vacuna
    {
        private string nombre;

        public Vacuna(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre
        {
            get { return this.nombre; }
        }
    }
}
