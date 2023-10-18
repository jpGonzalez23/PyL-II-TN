using Entidades;

namespace MiTestUnitario
{
    [TestClass]
    public class TestCantidadDeDigitos
    {
        [TestMethod]
        public void ContarCantidadDeDigitos_DebeContarDigitosEnNumeroPositivo()
        {
            long numero = 12345;
            int resultado = numero.ContarCantidadDigitos();
            Assert.AreEqual(5, resultado);
        }

        [TestMethod]
        public void ContarCantidadDeDigitos_DebeContarUnDigitoEnCero()
        {
            long numero = 0;
            int resultado = numero.ContarCantidadDigitos();
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void ContarCantidadDeDigitos_DebeContarDigitosEnNumeroNegativo()
        {
            long numero = -9876;
            int resultado = numero.ContarCantidadDigitos();
            Assert.AreEqual(4, resultado);
        }
    }
}