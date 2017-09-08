using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ValidarCNH;
using System.IO;

namespace ValidarCNHTeste {

    [TestClass]
    public class CNHTeste {

        private List<string> ListaCNH;

        public CNHTeste() {
            ListaCNH = new List<string>(File.ReadAllLines(@"C:\Temp\CNH\FonteCNHTeste.txt"));
        }

        [TestMethod]
        public void ValidarTeste() {
            var validarCNH = new CNH();
            foreach (var cnh in ListaCNH) {
                Assert.IsTrue(validarCNH.Validar(cnh));
            }
        }
    }
}