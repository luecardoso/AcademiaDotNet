using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    internal class Fornecedor
    {
        private int _id;
        private string _nome;

        public int Id { get { return _id; } }   
        public string Nome { get; set; }

        public Fornecedor() { }

        public bool gravar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();

            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into fornecedor values" +
                "(@nome);";

            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);

            command.Parameters[0].Value = Nome;

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

        public DataTable buscarFornecedores()
        {
            Banco bd = new Banco();
            try
            {
                SqlConnection cn = bd.abrirConexao();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = cn;
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = "select nome from fornecedor";

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

        public static ComboBox buscarFornecedoresCb(ComboBox cb)
        {
            Banco bd = new Banco();
            try
            {
                SqlConnection cn = bd.abrirConexao();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = cn;
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = "select nome from fornecedor";

                sqlCommand.ExecuteNonQuery();

                cb.Items.Add(sqlCommand.ExecuteNonQuery());

                return cb;

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

        public DataTable buscarFornecedoresByNome()
        {
            Banco bd = new Banco();

            try
            {
                SqlConnection cn = bd.abrirConexao();

                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = cn;
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = "select nome from fornecedor where nome like '%@nome%' ;";
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
    }
}
