using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_ADONet
{
    internal class Banco
    {
        //private string stringConexao = "Data Source=localhost;" + "Initial Catalog=adonet; User ID=user;" +
        //    "password=senha;language=Portuguese";

        private string stringConexao = "Data Source=localhost\\SQLEXPRESS2022;" + // adicionar "\\SQLEXPRESS" ao nome do servidor para indicar que está se conectando à instância do SQL Server Express
                                "Initial Catalog=adonet;" +
                                "User ID=atos;" +
                                "Password=Senh@_12331-05;" +
                                "Language=Portuguese;" +
                                "TrustServerCertificate=True;"; // não é recomendável usar em ambiente de produção para evitar compromerimento da segurança de comunicação

        private SqlConnection cn; // indicando que existe um SqlConnection

        private void conexao() //fará a instância do SqlConnection
        {
            cn = new SqlConnection(stringConexao);
        }

        public SqlConnection abrirConexao() // método para abrir a conexão
        {
            try
            {
                conexao();
                cn.Open();

                return cn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void fecharConexao()
        {
            try
            {
                cn.Close();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public DataTable executarConsultaGenerica(string sql)
        {
            try
            {
                abrirConexao();

                SqlCommand command = new SqlCommand(sql, cn); //instância da classe  SqlCommand que CRIA o comando SQL
                command.ExecuteNonQuery(); // executa o comando

                SqlDataAdapter adapter = new SqlDataAdapter(command); //adapter, que manuseia os dados do comando
                DataTable dt = new DataTable();//Tabela em memória
                adapter.Fill(dt);//preenche o datatable
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally // é facultativo no try catch e ele é sempre executado quando é utilizado
            {
                fecharConexao();
            }
        }
    }
}
