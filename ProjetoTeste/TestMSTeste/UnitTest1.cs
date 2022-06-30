using ProjetoTeste;

namespace TestMSTeste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SomarDoisNumeros()
        {

            //PREPARACAO - Arrange
            double pNUM = 1;
            double sNUM = 1;
            double rNUM = 2;

            //ACAO - Act

            var resultado = operecoes.Somar(pNUM, sNUM);
            //VERICACAO - Assert

            Assert.AreEqual(rNUM, resultado);



        }
    }
}