# Anotações da aula 38 - 01/06

- continuação do projeto ADO.NET da aula 37
- explicação sobre SqlDataReader reader = command.ExecuteReader();

public Pessoa consultaPessoa(int id)
{
Banco bd = new Banco();

    try
    {
        SqlConnection cn = bd.abrirConexao();
        SqlCommand command = new SqlCommand("select * from pessoas", cn);

        SqlDataReader reader = command.ExecuteReader()

        while (reader.Read())
        {
            if(reader.GetInt32(0) == id)
            {
                this.id = reader.GetInt32(0);
                this.nome = reader.GetString(1);
                this.profissao = reader.GetString(2);

                return this;
            }
        }

        return null;

    }
    catch (Exception ex)
    {
        return null;
    }
    finally
    {
        bd.fecharConexao();
    }

}

O DataReader é uma classe no ADO.NET que permite a leitura de dados de um banco de dados de forma eficiente. Ao contrário do DataTable, que carrega todos os dados em memória, o DataReader permite ler os dados do banco de dados sob demanda, registro por registro. Isso significa que ele não consome muita memória do cliente, tornando-o adequado para lidar com grandes volumes de dados.

Aqui estão as principais partes do código e como elas funcionam:

Abertura da conexão com o banco de dados:
SqlConnection cn = bd.abrirConexao(); - Essa linha de código cria uma instância de SqlConnection e abre a conexão com o banco de dados. A classe Banco é responsável por fornecer os detalhes de conexão.

Criação do comando SQL:
SqlCommand command = new SqlCommand("select \* from pessoas", cn); - Essa linha de código cria uma instância de SqlCommand com a consulta SQL para selecionar todos os registros da tabela pessoas. A conexão cn é passada como parâmetro para vincular o comando à conexão aberta anteriormente.

Execução do DataReader:
SqlDataReader reader = command.ExecuteReader(); - Essa linha de código executa o comando SQL e retorna um objeto SqlDataReader que pode ser usado para ler os dados resultantes da consulta.

Leitura dos registros com o DataReader:
while (reader.Read())
{
if(reader.GetInt32(0) == id)
{
this.id = reader.GetInt32(0);
this.nome = reader.GetString(1);
this.profissao = reader.GetString(2);

        return this;
    }

}

    Esse trecho de código é onde ocorre a leitura dos registros retornados pela consulta. O laço while percorre cada registro, e o método Read() avança para o próximo registro disponível.

    Dentro do laço, há uma verificação para verificar se o valor da coluna 0 (primeira coluna) é igual ao ID fornecido. Se for igual, os valores das colunas 0, 1 e 2 são lidos usando métodos como GetInt32() e GetString() do DataReader e atribuídos às propriedades da instância atual da classe Pessoa.

    É importante observar que a ordem das colunas no DataReader deve corresponder à ordem na consulta SQL.

Fechamento da conexão:
bd.fecharConexao(); - Essa linha de código fecha a conexão com o banco de dados usando o método fecharConexao() da classe Banco. O bloco finally garante que a conexão seja sempre fechada, mesmo se ocorrerem exceções durante a leitura dos dados.

No geral, a função consultaPessoa(int id) é usada para consultar um registro específico na tabela pessoas com base no ID fornecido. Ela retorna uma instância da classe Pessoa preenchida com os valores encontrados na tabela. Se o registro não for encontrado ou ocorrer algum erro durante a consulta, a função retorna null.
