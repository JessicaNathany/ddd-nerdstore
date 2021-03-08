 ### Projeto para estudos do DDD
 
:blue_book: Domain Driven Design

##### Este repositório é foi criado com o intuito de estudar afundo e criar cenários para a prática e fixação do DDD. Aqui, irei descresver todos os conceitos do DDD e colocar alguns pontos no código, abaixo todas as referências consultada, pesquisada e estudada sobre DDD..
 
 Fontes
 * :bookmark_tabs: AgileAndArt -  (http://www.agileandart.com/2010/07/16/ddd-introducao-a-domain-driven-design/)
 * :bookmark_tabs: Eduardo Pires -  (https://www.eduardopires.net.br/2016/08/ddd-nao-e-arquitetura-em-camadas/)
 * :bookmark_tabs: DDD Community.org - (https://www.dddcommunity.org/) 
 * :bookmark_tabs: Awesome Domain-Driven Design (https://github.com/heynickc/awesome-ddd)
 * :bookmark_tabs: DomainDrivenDesign Martin Fowler (https://martinfowler.com/bliki/DomainDrivenDesign.html)
 * :bookmark_tabs: Summary of the Domain Driven Design concepts (https://medium.com/@ruxijitianu/summary-of-the-domain-driven-design-concepts-9dd1a6f90091)



## Entidades
##### As Entidades são classes de objetos que necessitam de uma entidade. Normalmente são elementos de domínio que possuem ciclo de vida dedntro da nossa aplicação: um Cliente, por exemplo, se cadastra no sistema, faz compras, se torna inativo, é excluído, etc.

## Objetos de Valores
##### São objetos que só carregam valores, mas que não possuem distinção de entidade. Bons exemplos de objetos de valores seriam: strings, números ou cores. Por exemplo, se o o lápis de cor da criança acabar e você der um novo lápis a ela, da mesma cor, só que de uma outra caixa, ela não vai se importar. Para a criança, o lápis vermelho de uma caixa é igual ao lápis vermelho de outra caixa. As instâncias de Objetos de Valores são imutáveis, isto é, uam vez criados, seus atributos internos não poderão ser mais modificados. Em Jav, temos, por exemplo a classe BigDecimal, muito utilizada para fazer cálculos com valores grandes. 

## Agregados
##### São compostos de Entidades ou Objetos de Valores, que são encapsulados numa única classe. O Agregado serve para manter a integridade do modelo. Elegemos uma classe para servir de **raíz** do Agregado. Quando algum cliente quiser manipular dados de uma das clases que compõem o Agregado, essa manipulação só poderá ser feita através da **raíz**.

## Fábricas
##### São classes responsáveis pelo processo de criação dos Agregados ou dos Objetos de Valores. Algumas vezes, Agregados são relativamente complexos e não queremos manter a lógica de criação desses Agregados nas classes que compõmes. Extraímos então as regras de criação para uma classe externa: a fábrica.

## Serviços
##### São classes ersponsáveis por administrar o ciclo de vida de outros objetos, normalmente Entidades, Objetos de Valor e Agregados. Os repositórios são classes que centralizam operações de criação, alteração e remoção de objetos. Em linguagens como Java e .NET, repositórios são comumente implementados usando-se frameworks como Hibernate, ou Nhibernate. Já em RubyOnRails, o ActiveRecord faz o papel de repositório.

## Módulos
##### São abstrações que tem por objetivo agrupar classes por um conceito de domínio. A maioria das linguagens de programação oferecem suporte a módulos (pacotes em Java, namespaces em .NET ou módulos em Ruby). Um anti-padrão comum é a criação de módulos que agrupam as classes segundo conceitos de ingra-estrutura. Um exemplo seria, ao se trabalhar com Strutus, em Java, criar um pacote que conterá toas as Actions do sistema. Ao usar o DDD devemos agrupar classes se esse agrupamento faz sentido no ponto de vista do domínio, ou seja, do negócio. Se tivermos, por exemplo, várias classes que compõem informações de Paciente num sistema médico, podemos criar um módulo chamado **paciente** e colocar classes como Ficha, PrescricaoMedica, RegistroDeConsulta e HistoricoDeCirurgias num mesmo pacote.




