# ValidaCNH

## Sobre
Este package permite a valida��o num�rica da Carteira Nacional de Habilita��o - CNH. Este projeto teve como ponta p� inicial um t�pico de um f�rum de discuss�o que pode ser acessado [neste link](http://www.devmedia.com.br/forum/validacao-do-numero-de-registro-de-cnh/354889)

## Implementa��o
O uso do componente � bem simples. Use o snippet abaixo como segue:

    var numeroCNH = "01234567890";
    var valido = CNH.Validar(numeroCNH);

Os testes foram conclu�dos com sucesso. A massa de dados dos testes foi obtida [neste link](http://www.detran.rj.gov.br/_monta_aplicacoes.asp?doc=9073&cod=14&tipo=exibe_noticias&pag_noticias=true)

## O n�mero da CNH
O n�mero da CNH tem seu formato regulamentado pela resolu��o n�mero 598 do CONSELHO NACIONAL DE TR�NSITO - CONTRAN. Este formato foi definido com base na necessidade de adequa��o do modelo �nico da CNH �s exig�ncias das t�cnicas de seguran�a documental.

Mais informa��es podem ser obtidas no documento da resolu��o [neste link](https://www.gov.br/infraestrutura/pt-br/assuntos/transito/conteudo-contran/resolucoes/resolucao5982016.pdf)
