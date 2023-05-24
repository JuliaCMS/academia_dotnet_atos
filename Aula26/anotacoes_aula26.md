# Anotações Aula 26 15/05

## Herança

A herança em programação orientada a objetos é um conceito que permite criar uma classe nova (classe derivada ou filha) com base em uma classe existente (classe base ou pai). A classe derivada herda todos os membros (campos, propriedades, métodos) da classe base e pode adicionar seus próprios membros ou substituir os membros herdados.

internal class VeiculoEletrico : Veiculo -> A classe VeiculoEletrico é declarada como internal class VeiculoEletrico : Veiculo. Isso significa que a classe VeiculoEletrico herda tudo o que está dentro da classe Veiculo. Isso inclui campos, propriedades, métodos e outros membros da classe Veiculo.

O uso do modificador virtual em um método permite que ele seja sobrescrito. Quando uma classe derivada (filha) herda um método virtual da classe base (pai), ela tem a opção de substituir (sobrescrever) a implementação desse método.

Quando um método é declarado como virtual na classe base, ele permite que as classes derivadas substituam sua implementação usando a palavra-chave override. Isso significa que, se uma classe filha tiver sua própria implementação do método com a mesma assinatura, a implementação da classe filha será executada em vez da implementação da classe base.

A substituição de um método virtual na classe filha é realizada usando a palavra-chave override, indicando explicitamente que a implementação do método está sendo substituída. Essa é a forma de indicar que a classe filha tem prioridade na execução do método em relação à classe base.

É importante mencionar que o uso do modificador virtual na classe base não é obrigatório. A classe base pode simplesmente ter um método normal (sem o modificador virtual), e as classes derivadas não poderão substituir a implementação desse método.

- uma classe que tem um método virtual pode nunca ter uma outra reimplementação, pode ser que não seja necessário, mas ele define que o método PODE ser reimplementado em outra classe

---

## Classes e métodos abstratos

exemplo: internal abstract class Animal

Uma classe ou método abstrato é uma declaração que indica que a classe ou método não está completo ou não possui uma implementação definida naquele momento. Uma classe abstrata é declarada usando a palavra-chave abstract, e um método abstrato é declarado usando a palavra-chave abstract e não possui implementação.

Uma classe abstrata serve como uma base para classes derivadas e não pode ser instanciada diretamente. Ela fornece um esqueleto básico para as classes derivadas implementarem. Uma classe abstrata pode conter métodos abstratos (sem implementação) e métodos concretos (com implementação). Métodos abstratos são aqueles que precisam ser implementados pelas classes derivadas.

No momento que se tem um método abstrato dentro da classe, a classe também se torna abstrata, ou seja, quando uma classe possui pelo menos um método abstrato, ela também deve ser declarada como abstrata.

- vai ter uma implementação e pelo menos um método abstrato

---

### Interface

Uma interface define um >>>contrato<<< que uma classe pode implementar. Ela especifica os membros (métodos, propriedades, eventos) que uma classe deve implementar. Uma interface fornece apenas as assinaturas dos membros, sem nenhuma implementação. Permite programar de forma mais organizada, pensando em equipes.

As interfaces são declaradas usando a palavra-chave interface. Uma classe pode implementar uma ou várias interfaces, fornecendo uma implementação para todos os membros definidos na interface.

Ao implementar uma interface, a classe deve fornecer uma implementação para todos os membros declarados na interface. Isso garante que a classe cumpra o contrato especificado pela interface. As interfaces permitem a implementação de polimorfismo, pois uma classe pode ser tratada como um tipo de interface, permitindo uma maior flexibilidade e reutilização do código.

- Muito usada em APIs

- Não tem implementação de nada

---

### Diferenças entre herança, classe abstrata e interface

- Herança:
  A herança permite que uma classe derive (herde) os membros de outra classe.
  Uma classe derivada herda os campos, propriedades e métodos da classe base.
  A herança estabelece uma relação "é-um" entre as classes, onde a classe derivada é um tipo mais específico da classe base.
  Permite a reutilização de código e a extensão de funcionalidades.
  Pode fornecer uma implementação padrão para os membros herdados.
  Pode ser usada para modelar hierarquias de classes.

- Classe abstrata:
  Uma classe abstrata é uma classe que não pode ser instanciada diretamente.
  Ela serve como uma base para classes derivadas, fornecendo um esqueleto para a implementação.
  Pode conter métodos abstratos (sem implementação) e métodos concretos (com implementação).
  Os métodos abstratos são declarados na classe abstrata, mas não possuem uma implementação definida.
  As classes derivadas devem fornecer uma implementação para os métodos abstratos.
  Pode ter campos, propriedades e outros membros além dos métodos.
  Pode ser usada para definir um contrato com as classes derivadas.

- Interface:
  Uma interface define um contrato que uma classe pode implementar.
  Ela especifica os membros (métodos, propriedades, eventos) que uma classe deve implementar.
  Uma classe pode implementar várias interfaces.
  As interfaces fornecem apenas as assinaturas dos membros, sem implementação.
  Uma classe que implementa uma interface deve fornecer uma implementação para todos os membros definidos na interface.
  Permite a implementação de polimorfismo, onde um objeto pode ser tratado como um tipo de interface.
  Pode ser usada para definir um conjunto comum de comportamentos para várias classes não relacionadas.


### Quando escolher entre herança, classe abstrata e interface depende do cenário e dos requisitos do projeto. Algumas orientações gerais são:

- Use a herança quando houver uma relação "é-um" clara entre as classes e você queira reutilizar a funcionalidade da classe base.
- Use uma classe abstrata quando você quiser fornecer um esqueleto para implementação nas classes derivadas e quando você quiser definir um contrato com métodos que as classes derivadas devem implementar.
- Use interfaces quando você quiser definir um conjunto comum de comportamentos para várias classes não relacionadas e quando você quiser alcançar a implementação de polimorfismo.
