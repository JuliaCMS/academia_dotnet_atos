# Anotações aula 37 - 31/05

- string de conexão -> especificam informações necessárias para se conectar à um banco de dados. Elas podem conter informações de autenticação, direcionamento e especificações de segurança.
private string stringConexao = "Data Source=localhost" -> data source é um atributo e vai receber um valor
existem vários tipos de string de conexão

- com um login vc pode acesar o sql server, mas para acessar o banco de dados o login deve estar associado a um user

- exec chama funções ex: 
exec sp_addrolemember 'DB_DATAREADER', 'usuario';
exec sp_addrolemember 'DB_DATAWRITER', 'usuario';

- biblioteca Microsoft.Data.SqlClient possui varios métodos pra SQL Server especificamente
        private SqlConnection cn; // indicando que existe um SqlConnection

        private void conexao() //fará a instância do SqlConnection
        {
            cn = new SqlConnection(stringConexao);
        }


    - SqlCommand -> comando sql 
    SqlCommand command = new SqlCommand(sql, cn); //instância da classe  SqlCommand que cria o comando SQL
        sendo o argumento sql o script que deseja executar e cn o objeto da classe client que gerencia a conexão com o banco de dados
    - SqlDataAdapter ??? não entendi direito o que faz
    - DataTable -> Tabela em memória
    - adapter.Fill(dt);//preenche o datatable atraves do command


site com strings de conexão: https://www.connectionstrings.com/sql-server/

estou tendo esse problema algumas vezes: Microsoft.Data.SqlClient.SqlException: 'Connection Timeout Expired.  The timeout period elapsed during the post-login phase.  The connection could have timed out while waiting for server to complete the login process and respond; Or it could have timed out while attempting to create multiple active connections.  The duration spent while attempting to connect to this server was - [Pre-Login] initialization=47; handshake=37; 