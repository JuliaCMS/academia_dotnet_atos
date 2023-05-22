# Anotações Aula 21

ENCAPSULAMENTO

O encapsulamento é um princípio fundamental da programação orientada a objetos que permite proteger informações de um objeto e controlar o acesso a elas. Isso significa que os detalhes internos de um objeto são ocultados do mundo externo e só podem ser acessados através de métodos e propriedades definidos na classe.

public: É um modificador de acesso que indica que o membro (atributo, método, etc.) é acessível a todos os componentes do programa, ou seja, pode ser acessado de qualquer classe ou objeto, mesmo fora do escopo da classe em que foi definido.

private: É um modificador de acesso que indica que o membro é acessível somente dentro da própria classe em que foi definido. Isso significa que outros objetos ou classes não têm acesso direto a esse membro.

protected: É um modificador de acesso semelhante ao private, pois o membro só é acessível dentro da própria classe em que foi definido. No entanto, o protected também permite que as subclasses (classes derivadas ou herdeiras) acessem esse membro. Ou seja, os membros protected são visíveis tanto na classe em que foram definidos quanto nas subclasses (herança).

internal: Semelhante ao public, é um modificador de acesso que indica que o membro é acessível dentro do mesmo assembly. Um assembly é um conjunto de arquivos de código-fonte que são compilados juntos. Isso significa que os membros internal podem ser acessados por outras classes dentro do mesmo assembly, mas não por classes fora do assembly.

Esses modificadores de acesso são importantes para controlar a visibilidade e o acesso aos membros de uma classe, permitindo um encapsulamento adequado e restringindo o acesso a informações sensíveis.

---

Em C#, uma propriedade é uma forma de encapsular os campos (fields) de uma classe e fornecer métodos de acesso a eles (get, set). Elas permitem que você controle como os valores são definidos e obtidos, aplicando lógica adicional se necessário.

- A sintaxe dos atributos, por padrão, são iniciadas com underline, exemplo: private string \_nome;
- A sintaxe das propriedades e construtores, são iniciadas com letra maiuscula

A sintaxe padrão para a definição de uma propriedade em C# é usar um campo privado (private) para armazenar o valor da propriedade e, em seguida, definir os métodos de acesso para obter (get) e definir (set) esse valor. Normalmente, os atributos são nomeados com um prefixo de sublinhado (\_nome) para diferenciá-los dos parâmetros e variáveis locais.

Aqui está um exemplo de declaração de uma propriedade com um campo privado:

public class Exemplo {
private string \_nome;

    public string Nome {
        get { return _nome; }
        set { _nome = value; }
    }

}

Neste exemplo, a propriedade Nome (por padrão escrita com a letra inicial maiuscula)tem um método get que retorna o valor armazenado no campo privado \_nome e um método set que atribui um novo valor ao campo privado.

No entanto, com o C# 3.0 e versões posteriores, você pode usar a sintaxe simplificada das propriedades automáticas (auto-implemented properties) para reduzir o código necessário. Com as propriedades automáticas, o compilador gera automaticamente o campo privado correspondente, eliminando a necessidade de declarar explicitamente o campo privado. O exemplo acima pode ser simplificado da seguinte forma:

public class Exemplo {
public string Nome { get; set; }
}

Neste caso, o compilador cria um campo privado anônimo para armazenar o valor da propriedade e gera automaticamente os métodos get e set.

As propriedades em C# oferecem uma maneira conveniente de controlar o acesso a campos privados e adicionar lógica adicional, como validações, cálculos ou notificações, conforme necessário.

---

O relacionamento entre classes em programação orientada a objetos refere-se à forma como as classes interagem e se conectam umas com as outras para cumprir determinadas funcionalidades. Existem diferentes tipos de relacionamentos entre classes, sendo os mais comuns:

Associação: É um relacionamento em que uma classe é associada a outra classe, indicando que elas têm alguma forma de conexão ou dependência. Essa associação pode ser de diferentes tipos, como associação simples, associação bidirecional, associação unidirecional e associação com multiplicidade.

Herança: É um relacionamento em que uma classe herda características (atributos e métodos) de outra classe, chamada de classe base ou superclasse. A classe que herda é chamada de classe derivada ou subclasse. A herança permite que a classe derivada reutilize e estenda o comportamento da classe base.

Composição e Agregação: São relacionamentos de dependência em que uma classe é composta por outras classes ou tem uma agregação de outras classes. Na composição, a classe principal é responsável pela criação e destruição das classes que ela contém. Na agregação, as classes relacionadas existem independentemente uma da outra, e uma classe pode ter uma ou mais instâncias da outra classe.

Implementação de Interfaces: É um relacionamento em que uma classe implementa uma interface, definindo os métodos e propriedades exigidos pela interface. Isso permite que a classe forneça a implementação para as operações definidas na interface.

Esses relacionamentos entre classes permitem modelar estruturas mais complexas, definir comportamentos especializados e promover a reutilização de código. A escolha do tipo de relacionamento depende da natureza da relação entre as classes e dos requisitos do sistema.

---
