using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApp1;

namespace UnitTestProject1
{
    [TestClass]
    public class TestProjekt
    {
        [TestMethod]
        public void Testmetody()
        {
            
            Form1 addw = new Form1();
            var koniec = addw.dystans;
            Assert.IsNotNull(koniec);
        }
    }
}
