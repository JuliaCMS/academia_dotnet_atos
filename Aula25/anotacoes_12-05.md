# Anotações da aula 25 12/05

- Orientação a Objetos
    - Herança: sobreescrita (outras formas de realiazar coisas já existentes)
    - Listas e coleções (Listas, Filas, Pilhas, Arvores, Grafos, Hash....)
    - métodos e atributos (instância/objeto ou classe)
        Console.WriteLine() (serviço associado a uma classe)
        String frase = "alexandre zamberlan;08/08/1974;masculino";
        String[] vetor = frase.Split(";"); (serviço associado a um objeto)
- Manipulação de arquivo texto
    - plain text (texto puro)
        - JSON ->  REST
        - XML -> SOAP
        - CSV (arquivos separados por ;) -> cada linha é uma linha da tabela, e as colunas são separadas por ponto e virgula
Sistema 
    - Backend ------> Frontend
    BD ==== Regras Negocio ====> Nível do usuário (front-end)

-------------------------------------

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

-------------------------------------

criar classe Persistência -> é a classe que vai conversar com o arquivo. tem gente que gosta de chamá-la de "Arquivo" mesmo

ver melhor sobre classes estaticas

método estatico não precisa ser instanciado e não irá consumir memória
-> quando deixa estatico não dá para instanciar, ou seja, não dá para criar um objeto mas dá para usar serviços(métodos) da classe (acho que é isso)
-> já a instância do objeto permite manipular coisas dentro desse objeto

na classe Persistência é interessante que todos os métodos sejam estáticos

