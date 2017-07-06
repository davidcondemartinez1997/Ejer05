using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejer05;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Metodo metodo1 = new Metodo("Hola mundo", 1, 2);
            var res = metodo1.Concatenar();
        }
    }
}
