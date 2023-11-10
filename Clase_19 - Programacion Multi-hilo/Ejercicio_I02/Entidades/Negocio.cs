using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NameGenerator.Generators;

namespace Entidades
{
    public class Negocio
    {
        private static RealNameGenerator realNameGenerator;
        private ConcurrentQueue<string> clientes;
        private List<Caja> cajas;

        static Negocio()
        {
            Negocio.realNameGenerator = new RealNameGenerator();
        }

        public Negocio(List<Caja> cajas)
        {
            this.cajas = cajas;
            this.clientes = new ConcurrentQueue<string>();
        }

        public List<Task> ComenzarAtencion()
        {
            List<Task> tasks = new List<Task>();
            tasks.AddRange(AbrirCajas());

            tasks.Add(Task.Run(GenerarCliente));
            tasks.Add(Task.Run(AsignarCajas));

            return tasks;
        }

        private List<Task> AbrirCajas()
        {
            List<Task> tasks = new List<Task>();

            foreach (Caja item in this.cajas)
            {
                tasks.Add(item.IniciarAtencion());
            }
            return tasks;
        }

        private void AsignarCajas()
        {
            do
            {
                Caja caja = cajas.OrderBy(c => c.CantidadDeClientesALaEspera).First();
                
                clientes.TryDequeue(out string cliente);
               
                if (!string.IsNullOrWhiteSpace(cliente))
                {
                    caja.AgregarCliente(cliente);
                }

            } while (true);
        }

        private void GenerarCliente()
        {
            do
            {
                this.clientes.Enqueue(realNameGenerator.Generate());
                Thread.Sleep(1000);
            } while (true);
        }

    }
}
