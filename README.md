# ValidaCNH

## Sobre
Projeto que tem como objetivo permitir que se valide numericamente a Carteira Nacional de Habilitação - CNH. Este projeto teve como ponta pé inicial um tópico de um fórum de discussão que pode ser acessado [neste link](http://www.devmedia.com.br/forum/validacao-do-numero-de-registro-de-cnh/354889)

## Implementação
O uso do componente é bem simples. Use o snippet abaixo como segue:

    var numeroCNH = "01234567890";
    var valido = CNH.Validar(numeroCNH);

Os testes foram concluídos com sucesso. A massa de dados dos testes foi obtida [neste link](http://www.detran.rj.gov.br/_monta_aplicacoes.asp?doc=9073&cod=14&tipo=exibe_noticias&pag_noticias=true)

## O número da CNH
O número da CNH tem seu formato regulamentado pela resolução número 598 do CONSELHO NACIONAL DE TRÂNSITO - CONTRAN. Este formato foi definido com base na necessidade de adequação do modelo único da CNH às exigências das técnicas de segurança documental.

Mais informações podem ser obtidas no documento da resolução [neste link](https://www.gov.br/infraestrutura/pt-br/assuntos/transito/conteudo-contran/resolucoes/resolucao5982016.pdf)
