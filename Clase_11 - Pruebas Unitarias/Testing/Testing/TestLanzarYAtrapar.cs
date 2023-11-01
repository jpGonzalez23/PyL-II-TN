using Entidades;

namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MetodoEstatico_DeberiaLanzarDivisionPorCero()
        {
            MiClase miClase = new MiClase();    

            Assert.ThrowsException<DivideByZeroException>(() => miClase.)
        }
    }
}