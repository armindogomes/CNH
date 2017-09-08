# CNH
## Sobre
Projeto cujo objetivo é permitir que se valide numericamente a CNH brasileira. Ainda em estado experimental.

Para usar o componente é bem simples. Use o snippet abaixo como segue:

    var numeroCNH = "01234567890";
    var validarCNH = new CNH();
    var resultado = validarCNH.validar(numeroCNH);
    
Os testes falharam para uma quantidade pequena de entradas, o que nos leva a crer que não deve ser usado em produção de forma alguma.

Contribuições são bem vindas.

O código deste projeto teve como base um tópico de um forum de discussão que pode ser acessado [aqui](http://www.devmedia.com.br/forum/validacao-do-numero-de-registro-de-cnh/354889)

## Testes

Números válidos de CNH podem ser obtidos aqui:

[DETRAN SUSPENDE CARTEIRAS DE MAIS DE 900 MOTORISTAS](http://www.detran.rj.gov.br/_monta_aplicacoes.asp?doc=9073&cod=14&tipo=exibe_noticias&pag_noticias=true)

[EDITAL DE NOTIFICAÇÃO N° 001/2015](http://www2.detran.ba.gov.br/EditalNotificacao_N%C2%BA001-2015.pdf)

## Licença

MIT License

Copyright (c) 2017 CNH

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
