# Anotações aula 44 - 12/06

API (Application Programming Interface) - Uma API, ou Interface de Programação de Aplicativos, é um conjunto de regras e protocolos que permitem que diferentes componentes de software interajam entre si. Ela é projetada para desmembrar um projeto em serviços menores, que podem ser consumidos por diferentes aplicações. As APIs também são conhecidas como web services, pois geralmente são disponibilizadas pela web para que outras aplicações possam acessá-las.
diferentes aplicações podem consumir a API e ter as mesmas respostas

Existem diferentes formas de representar os dados transmitidos por uma API. As três formas mais comuns são: - XML (Extensible Markup Language): Uma linguagem de marcação que utiliza tags para estruturar e representar os dados. - JSON (JavaScript Object Notation): Um formato leve e legível para intercâmbio de dados, amplamente utilizado em APIs web. - YAML (YAML Ain't Markup Language): Uma linguagem de serialização de dados que possui uma sintaxe mais simples e fácil de ler.
Essas representações são usadas para estruturar e transmitir os dados entre as aplicações que consomem a API.

API REST(Representational State Transfer - Transferência de Estado Representacional) - API REST é um estilo arquitetônico que define um conjunto de restrições e princípios para a criação de serviços web. Uma API RESTful segue TODAS essas restrições e permite que as aplicações interajam com os recursos de um sistema por meio de operações padrão do protocolo HTTP (Trabalha em cima de verbos HTTP), como GET, POST, PUT, PATCH e DELETE. Ela usa URLs para identificar e acessar recursos e utiliza os códigos de status HTTP para indicar o resultado das operações.

Requisições e Respostas: Em uma API REST, as requisições POST e GET são comumente utilizadas. Uma requisição POST envia dados para o servidor para criar um novo recurso, enquanto uma requisição GET solicita um recurso existente para leitura. Essas requisições são recebidas por uma "rest controller" que se comunica com o "entity framework" e o banco de dados correspondente. Em seguida, uma resposta(response) é enviada de volta ao cliente contendo os dados solicitados ou a confirmação do sucesso da operação.

Métodos HTTP e CRUD: Os métodos HTTP mais comuns e utilizados em uma API RESTful são:

- POST: Utilizado para criar um novo recurso.
- GET: Utilizado para obter um recurso existente.
- PUT: Utilizado para atualizar completamente um recurso.
- PATCH: Utilizado para atualizar parcialmente um recurso.
- DELETE: Utilizado para excluir um recurso.
  Esses métodos correspondem às operações básicas de criação, leitura, atualização e exclusão (CRUD - Create, Read, Update, Delete) realizadas em um sistema.

.NET RestAPI -> segue o padrão de arquitetura MVC
database <-> model <-> controller <-> client(view)
O modelo representa os dados do sistema, a controladora processa as requisições e se comunica com o banco de dados por meio do Entity Framework, e o cliente (view) é responsável pela interface com o usuário.

Rotas (routes) - Em uma RestAPI, é importante garantir que as rotas (routes) das controladoras não se repitam. Cada rota é mapeada para um método específico em uma controladora e, quando há repetição, pode ocorrer conflito na definição das rotas.

Endpoints - Os endpoints são os URLs específicos que representam cada recurso disponibilizado pela API. Cada endpoint é associado a um método HTTP e corresponde a uma ação específica a ser executada em um recurso.
endpoint são métodos associados a verbos http

Métodos Assíncronos (Async) - O uso de métodos assíncronos é comum em APIs para melhorar o desempenho e a escalabilidade. Esses métodos não esperam todas as operações serem concluídas para continuar a execução, permitindo que outras tarefas sejam processadas enquanto aguardam a conclusão das operações assíncronas. Eles retornam uma Task (tarefa) que representa a operação assíncrona em andamento.

Injeção de Dependência - A injeção de dependência é um padrão de projeto que permite fornecer dependências necessárias a um objeto em vez de criá-las dentro do objeto. No contexto de uma API, a injeção de dependência é configurada na classe "Program". Por exemplo, ao adicionar a classe "Contexto" como um serviço na configuração da API, é possível injetar uma instância desse contexto em outras partes do código, utilizando a anotação [FromServices].

na program tem a builder, a classe contexto sera adicionada nos serviços da builder: builder.Services.AddDbContext<Contexto>(); // libera a injeção de dependencia
-> poderia fazer com qualquer classe dentro do projeto

Swagger - O Swagger é uma ferramenta popular para documentação de APIs. Ele fornece uma interface gráfica que permite visualizar e testar os endpoints da API. Além disso, o Swagger gera automaticamente a documentação da API com base nos metadados fornecidos nos modelos, controladoras e atributos de rota.


criar projeto em asp.net core web api (configre for https, use controllers, enable OpenAPI, do not use top-level statements), criar uma nova controle e herdar ControllerBase,----primeiro exercicio----, importar bibliotecas do entity, criar pasta DataModels com as classes Email e Pessoa e criar a classe contexto no projeto (foram copiadas do ultimo projeto codefirst), criar uma controller para pessoa (API controller empty)