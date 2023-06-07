O Entity Framework é um framework de mapeamento objeto-relacional (ORM - Object Relational Mapper) desenvolvido pela Microsoft. Ele permite que os desenvolvedores trabalhem com bancos de dados relacionais usando objetos e classes em vez de escrever consultas SQL diretamente.

Migration monta o contexto - O Entity Framework oferece suporte a um recurso chamado migrações (migrations), que permite que você defina alterações no modelo de banco de dados usando classes e, em seguida, gere automaticamente os scripts SQL necessários para aplicar essas alterações ao banco de dados. Com as migrações, você pode manter o banco de dados sincronizado com o modelo de dados ao longo do tempo, facilitando a evolução do esquema do banco de dados.

Existem três abordagens principais para trabalhar com o Entity Framework: Code First, Database First e Model First.

    - Code First: Nessa abordagem, você primeiro define suas classes de entidade no código e, em seguida, o Entity Framework cria o banco de dados automaticamente com base nessas classes. É a abordagem mais comum e recomendada quando você tem controle total sobre o esquema do banco de dados.

    - Database First: Nessa abordagem, o Entity Framework cria as classes de entidade a partir de um banco de dados existente. Ele gera as classes automaticamente com base nas tabelas e relacionamentos encontrados no banco de dados.

    - Model First: Essa abordagem envolve a criação de um modelo de entidade visual usando o designer do Entity Framework. Com base nesse modelo, o Entity Framework gera o banco de dados e as classes de entidade correspondentes (menos utilizada).

pacotes instalados: Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.Proxies
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
System.Configuration.ConfigurationManager
São pacotes NuGet necessários para usar o Entity Framework em um projeto. Esses pacotes fornecem as funcionalidades básicas e as ferramentas para trabalhar com o Entity Framework.

No Entity Framework, cada DbSet definido na classe do contexto representa uma tabela no banco de dados (no caso do Code First). Você pode manipular essas entidades (objetos) e o Entity Framework se encarrega de traduzir essas operações em instruções SQL para interagir com o banco de dados.

modelBuilder.Entity<Animal>()
.HasOne(a => a.Dono)
.WithMany(a => a.Animais)
A construção modelBuilder.Entity<Animal>().HasOne(a => a.Dono).WithMany(a => a.Animais) define um relacionamento entre as entidades "Animal" e "Dono" no modelo de dados. No exemplo, está sendo configurado um relacionamento onde um "Animal" pertence a um único "Dono" e um "Dono" pode ter vários "Animais".

As etapas "Add-Migration Initial" e "Update-Database" são comandos usados no Entity Framework Core para criar e aplicar migrações. "Add-Migration Initial" cria uma nova migração com o nome "Initial" (pode ser outro nome também) com base nas alterações no modelo de dados. "Update-Database" aplica todas as migrações pendentes no banco de dados, garantindo que o esquema do banco de dados esteja sincronizado com o modelo de dados.
