# Apresentação e código sobre Design Patterns

Padrão Comportamental

01 - Strategy

"Defini uma famílias de algoritmos implementados por uma hierarquia de classes onde os objetos dessas classes são utilizados em objetos de classes clientes por meio de composição, permitindo assim a mudança de comportamento dos objetos clientes pela intercambiação de objetos de estratégia."

Pontos Positivos
- Como qualquer outro padrão, coloca uma linguagem universal ao menos em parte do projeto, com isso permitindo que a leitura do mesmo seja mais eficiente;
- A reutilização de código é evidente, sendo que as famílias de algoritmos podem ser utilizadas por classes clientes de diferentes contextos, por exemplo, classes de contexto "aves" poderiam utilizar as classes de estratégia "voar";
- Permite uma evolução de projeto mais eficiente, pois o foco é na composição, evitando que classes e subclasses clientes sejam alteradas caso novas funcionalidades sejam adicionadas ou atualizadas;
- A possibilidade de mudança de comportamento em tempo de execução da maior dinamismo ao projeto, permitindo assim mais opções de funcionalidades.
- Exemplo do "Princípio aberto/fechado" do SOLID. Você pode introduzir novas estratégias sem mudar o contexto.

Pontos Negativos
- O número de classes no projeto pode crescer consideravelmente se houverem muitas funcionalidades que não podem ser implementadas por classes de uma mesma família de classes Strategy;
- Pode complicar o projeto ainda mais caso uma solução com herança seja mais simples de implementar e manter.

02 - Observer

"O Observer é um padrão de projeto comportamental que permite que um objeto notifique outros objetos sobre alterações em seu estado."

Basicamente ele trabalha como um notificador sincrono, avisando todos os objetos que foram registrados como "ouvintes".

Pontos Positivos
- É um padrão simples de ser implementado e fácil de ser identificado (seja por código ou comportamento). Em geral bibliotecas/frameworks reativos utilizam esse padrão ou variações dele.
- O baixo acomplamente entre as classes (através das interfaces) traz uma enorme reusabilidade permitindo aumentar o número de "observadores" sem precisar modificar a classe "observada".

Pontos Negativos
- Deve ser utilizado com cuidado pois o uso de forma indiscriminada pode causar impacto na performance do sistema. 
Imagine um cenário onde "todos" notificam "todos" a cada mudança nos objetos. Isso pode aumentar exponencialmente o número de requisições trazendo problemas de desempenho.

O padrão "Publisher/Subscriber" ou "Pub/Sub" é quase que uma evolução do Observer, basicamente utilizando delegates, handlers, events, etc, ou seja assincrono.
https://dev.to/absjabed/publisher-subscriber-vs-observer-pattern-with-c-3gpc

Atenção: Neste exemplo, há uma implementação simplificada utilizando interfaces simples e outra utilizando o System.IObserver / System.IObservable.