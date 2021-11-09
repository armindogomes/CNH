using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace ValidaCNH.Teste {

    public class CNHTeste {

        private readonly List<string> _listaCNHOk, _listaCNHErro;

        public CNHTeste() {
            _listaCNHOk = new (File.ReadAllLines("ListaCNHOk.txt")?.Select(f => f.Trim()));
            _listaCNHErro = new (File.ReadAllLines("ListaCNHErro.txt")?.Select(f => f.Trim()));
        }

        [Fact]
        public void ValidarCNHErroTeste() => _listaCNHErro.ForEach(cnh => Assert.False(CNH.Validar(cnh)));

        [Fact]
        public void ValidarCNHOkTeste() => _listaCNHOk.ForEach(cnh => Assert.True(CNH.Validar(cnh)));

        [Theory]
        [InlineData("1234567891234")]
        [InlineData("123456789123")]
        [InlineData("123456789")]
        [InlineData("12345678")]
        [InlineData("1234567")]
        public void ValidarCNHFormatoErradoTeste(string cnh) => Assert.False(CNH.Validar(cnh));

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        public void ValidarCNHNuloOuVazioErradoTeste(string cnh) => Assert.Throws<ArgumentException>(() => CNH.Validar(cnh));
    }
}
