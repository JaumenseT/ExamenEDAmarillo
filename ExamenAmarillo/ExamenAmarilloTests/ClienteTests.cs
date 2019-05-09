using Microsoft.VisualStudio.TestTools.UnitTesting;
using ExamenAmarillo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenAmarillo.Tests
{
    [TestClass()]
    public class ClienteTests
    {
        [TestMethod()]
        public void SumaSaldoTest()
        {
            Cliente target = new Cliente();
            int a = 100;
            int b = 200;
            int expected = 300;
            int actual;
            //actual = target.Sumar(a + b);
            actual = Cliente.SumaSaldo(a + b);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RestaSaldoTest()
        {
            Cliente target = new Cliente();
            int a = 100;
            int b = 50;
            int expected = 50;
            int actual;
            actual = Cliente.RestaSaldo(a - b);
            Assert.AreEqual(expected, actual);
        }
    }
}