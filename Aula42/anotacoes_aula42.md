# Anotações Aula 42

Linguagem Linq -> consulta integrada a linguagem, mecanismo do .net framework pra criar consultas em diferentes contextos (bd, json, xml...)

code first -> primeiro cria as datamodels, a contexto, em cima disso é gerado a migration e é gerado o banco de dados

databsefirst -> criar o banco, instalar os pacotes nugget clicando com o botão direito em dependencias, ir em tools (nugget package manager -> package manager console), PM: Scaffold-DbContext "colar a string de conexão"
"Data Source=localhost\SQLEXPRESS2022;Initial Catalog=DBFirst;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
Provider: Microsoft.EntityFrameworkCore.SqlServer

