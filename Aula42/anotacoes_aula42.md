# Anotações Aula 42

O Entity Framework é um framework de mapeamento objeto-relacional (ORM) que permite aos desenvolvedores trabalhar com bancos de dados relacionais usando objetos e consultas orientadas a objetos. Ele é parte integrante do .NET Framework e fornece uma maneira eficiente de acessar, manipular e persistir dados em um banco de dados.

Linguagem Linq -> O Entity Framework utiliza a linguagem LINQ (Language Integrated Query) para criar consultas integradas à linguagem. O LINQ é uma extensão da linguagem C# (ou VB.NET) que permite escrever consultas de banco de dados usando uma sintaxe semelhante à linguagem de consulta SQL, mas de forma mais intuitiva e segura em tempo de compilação. Com o uso do LINQ, as consultas podem ser escritas diretamente no código C#, facilitando a leitura e manutenção.
cria consultas em diferentes contextos (bd, json, xml...)

code first -> primeiro cria as datamodels, a contexto, em cima disso é gerado a migration e é gerado o banco de dados
O Code First é uma abordagem do Entity Framework para criar e gerenciar o banco de dados a partir do código de domínio da aplicação. Com o Code First, você começa definindo as classes de entidades (data models) que representam as tabelas do banco de dados. Em seguida, você cria um contexto de banco de dados que herda da classe DbContext e mapeia as entidades para tabelas e propriedades para colunas. O Entity Framework, então, utiliza o contexto e as configurações definidas para gerar automaticamente as migrações do banco de dados e criar o banco de dados conforme necessário.

databsefirst -> criar o banco, instalar os pacotes nugget clicando com o botão direito em dependencias, ir em tools (nugget package manager -> package manager console),
PM: Scaffold-DbContext "colar a string de conexão"
Provider: Microsoft.EntityFrameworkCore.SqlServer

"Data Source=localhost\SQLEXPRESS2022;Initial Catalog=DBFirst;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

O Database First é outra abordagem do Entity Framework que permite criar classes de entidades e um contexto de banco de dados a partir de um banco de dados existente. Com o Database First, você começa criando o banco de dados e, em seguida, usa o Entity Framework para gerar classes de entidades com base nas tabelas e colunas existentes no banco de dados. Isso é feito por meio da ferramenta "Scaffold-DbContext" do Entity Framework, que lê o esquema do banco de dados e gera o código C# correspondente às classes de entidades.

Para usar o Scaffold-DbContext no Visual Studio, você precisa instalar o pacote do Entity Framework Core para o provedor de banco de dados desejado (como o pacote Microsoft.EntityFrameworkCore.SqlServer para o SQL Server) por meio do Gerenciador de Pacotes do NuGet. Em seguida, abra o Console do Gerenciador de Pacotes (Package Manager Console) e execute o comando Scaffold-DbContext, passando a string de conexão do banco de dados como parâmetro. O Entity Framework irá então gerar as classes de entidades e o contexto de banco de dados com base no esquema do banco de dados.

expressão lambda: é uma forma concisa de escrever funções anônimas. Essas expressões são úteis quando você precisa passar uma função como argumento para outra função ou quando precisa definir uma função rápida e simples em uma linha.

=> -> separa o parâmetro da execução, ela abstrai uma função que será executada apenas uma vez no código/ é uma função escrita em uma linha só
é um bool que retorna um inteiro, exemplo: var linhaFiltrada = lista.Where( x => x > 4) -> vai retornar os inteiros maiores que 4 contidos dentro da lista
a expressão lambda x => x > 4 define uma função que verifica se um valor x é maior que 4. Essa expressão pode ser usada como um predicado na função Where() para filtrar uma lista.
A expressão x => x > 4 pode ser lida como "para cada elemento x, retorna true se x for maior que 4". A função Where() aplicará essa expressão lambda a cada elemento da lista e retornará uma nova lista contendo apenas os elementos que atendem à condição especificada.
O resultado dessa expressão lambda é um valor booleano, que indica se um determinado elemento é maior que 4 ou não. Portanto, a variável linhaFiltrada receberá uma lista contendo apenas os inteiros maiores que 4 da lista original.
É importante ressaltar que expressões lambda podem ser usadas em várias situações além do método Where() de uma lista. Elas são comumente utilizadas em funções como Select(), OrderBy(), FirstOrDefault(), entre outras, para fornecer lógica personalizada para manipulação de coleções de dados.