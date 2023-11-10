namespace Entidades
{
    public class Caja
    {
        public delegate void DelegadoClienteAtendido(Caja caja, string cliente);

        private string nombreCaja;
        private static Random random;
        private Queue<string> clienteALaEspera;
        private DelegadoClienteAtendido delegadoClienteAtendido;

        static Caja()
        {
            Caja.random = new Random();
        }

        public Caja(string nombreCaja, DelegadoClienteAtendido delegadoClienteAtendido)
        {
            this.clienteALaEspera = new Queue<string>();
            this.nombreCaja = nombreCaja;
            this.delegadoClienteAtendido = delegadoClienteAtendido;
        }

        public int CantidadDeClientesALaEspera
        {
            get { return this.clienteALaEspera.Count; }
        }

        public string NombreCaja
        {
            get { return this.nombreCaja; }
        }

        internal void AgregarCliente(string cliente)
        {
            this.clienteALaEspera.Enqueue(cliente);
        }

        internal Task IniciarAtencion()
        {
            return Task.Run(AtenderCliente);
        }

        private void AtenderCliente()
        {
            do
            {
                if (this.clienteALaEspera.Any())
                {
                    string cliente = clienteALaEspera.Dequeue();
                    delegadoClienteAtendido.Invoke(this,cliente);
                    Thread.Sleep(random.Next(1000, 5000));
                }
            }while (true);
        }
    }
}