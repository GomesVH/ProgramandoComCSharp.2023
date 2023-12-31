namespace CSharp.Capitulo10.DelegateLambda.Testes
{
    [TestClass]
    public class DelegateTestes
    {
        [TestMethod]
        [DataRow(TipoOperacao.Soma, 1,2,3)]
        [DataRow(TipoOperacao.Subtracao, 1,2,-1)]
        public void CalculadoraTeste(TipoOperacao tipoOperacao, int x, int y, int resultado)
        {
            //ObterOperacao();
            //var calculadora = new Calculadora();
            //calculadora.ObterOperacao();

            var operacao = Calculadora.ObterOperacao(tipoOperacao);

            Assert.IsTrue(operacao(x,y) == resultado);
        }

        [TestMethod]
        public void MetedoAnonimoTeste()
        {
            EfetuarOperacao divisao = delegate (int x, int y)
            {
                return x / y;
            };

            Assert.IsTrue(divisao(6, 3) == 2);
        }

        [TestMethod]
        public void ExpressaoLambdateste()
        {
            //EfetuarOperacao multiplicacao = (x,y) => 
            //{
            //    return x * y;
            //};

            EfetuarOperacao multiplicacao = (x, y) => x * y;
        }
    }
}