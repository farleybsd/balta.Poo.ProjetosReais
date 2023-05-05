using System.Data;
using UtmBuiolder.Core.ValueObjects;
using UtmBuiolder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects
{
    [TestClass]
    public class UrlTests
    {
        private const string InvalidUrl = "banana";
        private const string validUrl = "https://balta.io";

        [TestMethod("Deve Retornar uma execacao quando uma Url for invalida")]
        [TestCategory("Testè Da Url")]
        public void Dado_uma_url_invalida_deve_retornar_uma_excecao()
        {
            try
            {
                var url = new Url(InvalidUrl);
                Assert.Fail();
            }
            catch (InvalidUrlException e)
            {

                Assert.IsTrue(true);
            }
        }

        [TestMethod("Nao Deve Retornar uma execacao quando uma Url for invalida")]
        [TestCategory("Testè Da Url")]
        public void Nao_Dado_uma_url_invalida_deve_retornar_uma_excecao()
        {
            new Url(validUrl);
            Assert.IsTrue(true);
        }

        [TestMethod("Teste URL")]
        [TestCategory("Testè Da Url")]
        [DataRow(" ", true)]
        [DataRow("http", true)]
        [DataRow("banana", true)]
        [DataRow("https://balta.io", false)]
        public void TesteUrl(string link, bool expectException)
        {
            if (expectException)
            {
                try
                {
                    new Url(link);
                    Assert.Fail();
                }
                catch (InvalidUrlException e)
                {

                    Assert.IsTrue(true);
                }
            }

            Assert.IsTrue(expectException);
        }
    }
}
