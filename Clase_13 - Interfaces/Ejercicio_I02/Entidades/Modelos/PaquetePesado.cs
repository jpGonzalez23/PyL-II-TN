﻿using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class PaquetePesado : Paquete, IAfip
    {
        public PaquetePesado(string codigoSeguimiento, decimal costoEnvio, string destino, string origen, double pesoKg) 
            : base(codigoSeguimiento, costoEnvio, destino, origen, pesoKg)
        {
        }

        public override bool TienePrioridad
        {
            get 
            { 
                return false; 
            }
        }

        decimal IAfip.Impuestos
        {
            get
            {
                return base.costoEnvio * 0.25M;
            }
        }

        decimal IAfip.AplicarImpuestos()
        {
            return base.costoEnvio + ((IAfip)this).Impuestos;
        }
    }
}
