using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidarCNH {

    public class CNH {

        private const int TAMANHO_CNH = 11;
        private const int TAMANHO_DIGITO = 2;
        private readonly int TAMANHO_NUMERACAO;

        public CNH() {
            TAMANHO_NUMERACAO = TAMANHO_CNH - TAMANHO_DIGITO;
        }

        public bool Validar(string cnhFornecida) {
            if (cnhFornecida.Length != TAMANHO_CNH) {
                return false;
            }

            var numeracaoFornecida = cnhFornecida.Substring(0, TAMANHO_NUMERACAO);
            var digitoFornecido = cnhFornecida.Substring(TAMANHO_NUMERACAO, TAMANHO_DIGITO);

            var incremento = 0;

            // Calcular o decimo caracter - digito 1
            var soma = 0;
            var multiplicador = 9;

            for (int i = 0; i < TAMANHO_NUMERACAO; i++) {
                soma = soma + int.Parse(numeracaoFornecida.ToCharArray()[i].ToString()) * multiplicador;
                multiplicador--;
            }

            var digito1 = soma % TAMANHO_CNH;
            if (digito1 == 10) {
                incremento = -2;
            }

            digito1 = CorrigirDigito(digito1);

            // Calcular o decimo primeiro caracter - digito 2
            soma = 0;
            multiplicador = 1;

            for (int j = 0; j < TAMANHO_NUMERACAO; j++) {
                soma = soma + int.Parse(numeracaoFornecida.ToCharArray()[j].ToString()) * multiplicador;
                multiplicador++;
            }

            int digito2;
            if ((soma % TAMANHO_CNH) + incremento < 0) {
                digito2 = TAMANHO_CNH + (soma % TAMANHO_CNH) + incremento;
            }
            else {
                digito2 = (soma % TAMANHO_CNH) + incremento;
            }

            digito2 = CorrigirDigito(digito2);

            var digitoEncontrado = $"{digito1}{digito2}";
            return digitoFornecido == digitoEncontrado;

            int CorrigirDigito(int digito) => digito > 9 ? 0 : digito;
        }
    }
}