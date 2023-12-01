using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    internal class Cliente
    {
        private int _id;
        private string _nome;
        private string _dataNascimento;
        private string _telefone;
        private string _sexo;

        public int Id { get; set; }

        public string Nome { get; set; }
        public string DataNascimento { get; set; }

        public string Telefone { get; set; }
        public string Sexo { get; set; }


        public Cliente() { }

        public bool gravar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();

            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into cliente values" +
                "(@nome, @dataNascimento, @telefone, @sexo);";

            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@dataNascimento", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@telefone", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@sexo", System.Data.SqlDbType.VarChar);
            command.Parameters[0].Value = Nome;
            command.Parameters[1].Value = DataNascimento;
            command.Parameters[2].Value = Telefone;
            command.Parameters[3].Value = Sexo;

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

        public bool atualizar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();

            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand command = new SqlCommand();

            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "update cliente set nome = @nome, dataNascimento = @dataNascimento, " +
                "telefone = @telefone, sexo = @sexo " +
                "where id = @id;";
            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@dataNascimento", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@telefone", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@sexo", System.Data.SqlDbType.VarChar);
            command.Parameters[0].Value = Nome;
            command.Parameters[1].Value = DataNascimento;
            command.Parameters[2].Value = Telefone;
            command.Parameters[3].Value = Sexo;


            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                tran.Rollback();
                bd.fecharConexao();
            }
        }

        public DataTable buscarPessoas()
        {
            Banco bd = new Banco();
            try
            {
                SqlConnection cn = bd.abrirConexao();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = cn;
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = "select * from cliente";

                sqlCommand.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                adapter.Fill(dt);

                return dt;

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

        public DataTable buscarClientesByNome()
        {
            Banco bd = new Banco();

            try
            {
                SqlConnection cn = bd.abrirConexao();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = cn;
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = "select * from cliente where nome = @nome";
                sqlCommand.Parameters.Add("@nome", SqlDbType.VarChar);
                sqlCommand.Parameters[0].Value = Nome;

                sqlCommand.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                adapter.Fill(dt);

                return dt;

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


        public DataTable buscarClientesById()
        {
            Banco bd = new Banco();

            try
            {
                SqlConnection cn = bd.abrirConexao();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = cn;
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = "select * from cliente where id = @id";
                sqlCommand.Parameters.Add("@id", SqlDbType.Int);
                sqlCommand.Parameters[0].Value = Id;

                sqlCommand.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

                adapter.Fill(dt);

                return dt;

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
    }
}
