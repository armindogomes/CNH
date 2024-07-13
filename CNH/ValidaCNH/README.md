# ValidaCNH

## Sobre
Este package permite a valida&ccedil;&atilde;o num&eacute;rica da Carteira Nacional de Habilita&ccedil;&atilde;o - CNH. Este projeto teve como ponta p&eacute; inicial um t&oacute;pico de um f&oacute;rum de discuss&atilde;o que pode ser acessado [neste link](http://www.devmedia.com.br/forum/validacao-do-numero-de-registro-de-cnh/354889)

## Implementa&ccedil;&atilde;o
O uso do componente &eacute; bem simples. Use o snippet abaixo como segue:

    var numeroCNH = "01234567890";
    var valido = CNH.Validar(numeroCNH);

Os testes foram conclu&iacute;dos com sucesso. A massa de dados dos testes foi obtida [neste link](http://www.detran.rj.gov.br/_monta_aplicacoes.asp?doc=9073&cod=14&tipo=exibe_noticias&pag_noticias=true)

## O n&uacute;mero da CNH
O n&uacute;mero da CNH tem seu formato regulamentado pela resolu&ccedil;&atilde;o n&uacute;mero 598 do CONSELHO NACIONAL DE TR&Acirc;NSITO - CONTRAN. Este formato foi definido com base na necessidade de adequa&ccedil;&atilde;o do modelo &uacute;nico da CNH &agrave;s exig&ecirc;ncias das t&eacute;cnicas de seguran&ccedil;a documental.

Mais informa&ccedil;&otilde;es podem ser obtidas no documento da resolu&ccedil;&atilde;o [neste link](https://www.gov.br/infraestrutura/pt-br/assuntos/transito/conteudo-contran/resolucoes/resolucao5982016.pdf)
