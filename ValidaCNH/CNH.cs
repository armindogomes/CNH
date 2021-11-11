using System;

namespace ValidaCNH {

    public class CNH {

        private const int TAM_CNH = 11;
        private const int TAM_DIGITO = 2;
        private static int _tamNumeracao = TAM_CNH - TAM_DIGITO;

        public static bool Validar(string cnhFornecida) {
            if (!long.TryParse(cnhFornecida, out long _)) throw new ArgumentException("O número informado não possui um formato válido. Apenas números devem ser informados.");
            if (cnhFornecida.Length != TAM_CNH) return false;

            var numeracaoFornecida = cnhFornecida.Substring(0, _tamNumeracao);
            var digitoFornecido = cnhFornecida.Substring(_tamNumeracao, TAM_DIGITO);
            var incremento = 0;

            // Calcular o decimo caracter - digito 1
            var soma = 0;
            var multiplicador = 9;
            for (int i = 0; i < _tamNumeracao; i++) {
                soma += int.Parse(numeracaoFornecida.ToCharArray()[i].ToString()) * multiplicador--;
            }

            var digito1 = soma % TAM_CNH;
            if (digito1 == 10) incremento = -2;

            digito1 = CorrigirDigito(digito1);

            // Calcular o decimo primeiro caracter - digito 2
            soma = 0;
            multiplicador = 1;
            for (int j = 0; j < _tamNumeracao; j++) {
                soma += int.Parse(numeracaoFornecida.ToCharArray()[j].ToString()) * multiplicador++;
            }

            var digito2 = CorrigirDigito((soma % TAM_CNH) + incremento < 0 ? TAM_CNH + (soma % TAM_CNH) + incremento : (soma % TAM_CNH) + incremento);
            var digitoEncontrado = $"{digito1}{digito2}";
            return digitoFornecido == digitoEncontrado;

            int CorrigirDigito(int digito) => digito > 9 ? 0 : digito;
        }
    }
}