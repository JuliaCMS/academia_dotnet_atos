using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_ADONet
{
    internal class Pessoa
    {
        public int id;
        public string nome;
        public string profissao;

        //public bool gravarPessoa()
        //{
        //    Banco bd = new Banco();

        //    SqlConnection cn = bd.abrirConexao();
        //}

        public bool gravarPessoa()
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text;

            command.CommandText = "insert into pessoas " +
                " values (@nome, @profissao);";

            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@profissao", System.Data.SqlDbType.VarChar);

            command.Parameters[0].Value = nome;
            command.Parameters[1].Value = profissao;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public bool excluir(int id)
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirConexao(); // biblioteca que faz conexão entre o c# e sql server
            SqlTransaction trans = cn.BeginTransaction();
            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = trans;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "delete from pessoas where id = @id";
            command.Parameters.AddWithValue("@Id", id.ToString());

            try
            {
                command.ExecuteNonQuery();
                trans.Commit();
                return true;
            }
            catch (Exception ex)
            {
                trans.Rollback();
                return false;
            }
            finally
            {
                bd.fecharConexao();
            }
        }

        public bool atualizar(string nome, string profissao, int id)
        {
            Banco bd = new Banco();

            SqlConnection cn = bd.abrirConexao();
            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.Transaction = tran;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "update pessoas set nome = @nome, " +
                "  profissao = @profissao where id = @id";
            cmd.Parameters.AddWithValue("@Nome", nome);
            cmd.Parameters.AddWithValue("@Profissao", profissao);
            cmd.Parameters.AddWithValue("@Id", id.ToString());

            try
            {
                cmd.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;

            }
            finally
            {
                bd.fecharConexao();
            }
        }
    }
}
