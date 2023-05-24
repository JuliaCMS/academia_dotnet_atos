# Anotações da aula 25 12/05

- Orientação a Objetos
  - Herança: sobreescrita (outras formas de realiazar coisas já existentes)
    (É um mecanismo que permite criar uma nova classe a partir de uma classe existente, aproveitando seus atributos e métodos. A classe nova, chamada de classe derivada ou subclasse, pode adicionar ou sobrescrever comportamentos da classe base.)
  - Listas e coleções (Listas, Filas, Pilhas, Arvores, Grafos, Hash....)
  - Métodos e atributos (instância/objeto ou classe)
    Console.WriteLine() (serviço associado a uma classe)
    String frase = "alexandre zamberlan;08/08/1974;masculino";
    String[] vetor = frase.Split(";"); (serviço associado a um objeto)
- Manipulação de arquivo texto
  - plain text (texto puro, sem formatação especial)
  - JSON -> REST
  - XML -> SOAP
  - CSV (arquivos separados por ;) -> cada linha é uma linha da tabela, e as colunas são separadas por ponto e virgula
    Sistema - Backend ------> Frontend
    BD ==== Regras Negocio ====> Nível do usuário (front-end)

JSON (JavaScript Object Notation): É um formato de arquivo leve e legível por humanos para troca de dados. É amplamente utilizado em aplicações web e oferece uma estrutura de dados baseada em pares chave-valor.

XML (Extensible Markup Language): É uma linguagem de marcação que permite definir conjuntos de regras para a codificação de documentos. É utilizado para armazenar e transportar dados de forma estruturada.

CSV (Comma-Separated Values): É um formato de arquivo que armazena dados tabulares (como uma tabela). Cada linha do arquivo representa uma linha da tabela, e as colunas são separadas por ponto e vírgula.

---

Tarefa -> manipular arquivo csv
tem que saber escrever o arquivo e saber ler o que sai do arquivo
tudo que sai do arquivo e vai para o programa tem que parar dentro de um objeto(pessoa, aluno...) e cada objeto desses tem que estar em uma posição dentro da lista

Desafio: Programa em C# no modo terminal, tendo como base o seguinte MENU.

    Menu
    1 - Cadastrar pessoa (controle de duplicidade: email)
    2 - Listar pessoa
    3 - Pesquisar pessoa (atributo nome)
    4 - Excluir pessoa
    5 - Sair
    Opção:


    Elementos necessários:
        Classe Pessoa(nome, email, dataNascimento(string))
            - método para gerar o email da pessoa automaticamente: sobrenome_nome@ufn.edu.br
        Lista de Pessoas
            - ordenação (Sort)
        Arquivo
            - texto puro -> csv ou seja, separado por ;
            - StreamReader (classe leitora)
            - StreamWriter (classe escritora)


        Cadastrar -> nome e dataNascimento -> constroi objeto com email gerado -> joga na lista -> atualizar arquivo
        Listar -> mostrar a lista
        Pesquisar -> percorrer a lista a procura de alguma pessoa
        Excluir -> pesquisar -> retirar da lista -> atualizar arquivo

---

Criar classe Persistência -> é a classe que vai conversar com o arquivo, que vai ser responsável por lidar com a interação entre o programa e o arquivo. Tem gente que gosta de chamá-la de "Arquivo" mesmo. Ela será utilizada para realizar operações de leitura, escrita e manipulação dos dados armazenados no arquivo.

### Classes estáticas:

Uma classe estática é aquela em que todos os membros (métodos, atributos) são declarados como estáticos. Isso significa que não é necessário criar uma instância da classe para acessar seus membros. Os métodos estáticos podem ser chamados diretamente pela classe, sem a necessidade de instanciar um objeto. Eles são associados à própria classe, em vez de um objeto específico.

- Métodos estáticos não precisam ser instanciados: Diferentemente dos métodos não estáticos, os métodos estáticos não precisam de uma instância da classe para serem chamados. Eles podem ser acessados diretamente pela classe.

- Métodos estáticos não consomem memória com instâncias: Quando um método é declarado como estático, ele não está associado a uma instância específica da classe. Portanto, não é necessário alocar memória para criar objetos quando se usa métodos estáticos.

- Acessando serviços da classe estática: Embora não seja possível criar uma instância da classe estática, ainda é possível usar os serviços (métodos) fornecidos por ela. Isso significa que pode chamar os métodos estáticos diretamente, sem precisar criar objetos.

- Já a instância do objeto permite manipular coisas dentro desse objeto.

Na classe Persistência é interessante que todos os métodos sejam estáticos -> essa abordagem pode ser útil quando é preciso realizar operações de leitura/escrita de arquivos de forma isolada, sem precisar criar instâncias da classe. Dessa forma, poderão ser utilizados os métodos estáticos da classe de Persistência para manipular o arquivo sem a necessidade de instanciar a classe.
