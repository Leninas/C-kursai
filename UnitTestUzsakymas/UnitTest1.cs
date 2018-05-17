using System;
using _17_2_Interface_testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestUzsakymas
{
    [TestClass]
    public class UnitTestUzsakymas
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ProcessOrder_SiuntaJauIsiusta_ThrowExceptio()
        {
            Uzsakymas uzsakymas = new Uzsakymas(
                new Siuntimas(false)
                );
            uzsakymas.ProcessOrder();
        }

        [TestMethod]
        public void ProcessOrder_SiuntaDarNeissiusta_Gausim4()
        {
            Uzsakymas uzsakymas = new Uzsakymas(new FakeSiunta());
            uzsakymas.ProcessOrder();
            Assert.AreEqual(uzsakymas.Kaina, 24);
        }
    }

    class FakeSiunta: ISiuntimas
    {
        public bool IsShipped { get; }
        public int SiuntosSkaiciutuvas()
        {
            return 4;
        }

    }
}
