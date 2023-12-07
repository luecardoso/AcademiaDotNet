using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    internal class Produto
    {
        private int _id;
        private string _nome;
        private int _quantidade;
        private float _preco;

        private int _idCategoria;
        private int _idFornecedor;

        public int Id {  get { return _id; } }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public float Preco { get; set; }
        public int IdCategoria { get; set; }
        public int IdFornecedor { get; set; }

        public bool gravar()
        {
            Banco bd = new Banco();
            SqlConnection cn = bd.abrirConexao();

            SqlTransaction tran = cn.BeginTransaction();

            SqlCommand command = new SqlCommand();
            command.Connection = cn;
            command.Transaction = tran;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into produto values" +
                "(@nome, @quantidade, @preco, @fk_fornecedor);";//@idCategoria,

            command.Parameters.Add("@nome", System.Data.SqlDbType.VarChar);
            command.Parameters.Add("@quantidade", System.Data.SqlDbType.Int);
            command.Parameters.Add("@preco", System.Data.SqlDbType.Float);
            //command.Parameters.Add("@idCategoria", System.Data.SqlDbType.Int);
            command.Parameters.Add("@fk_fornecedor", System.Data.SqlDbType.Int);
            command.Parameters[0].Value = Nome;
            command.Parameters[1].Value = Quantidade;
            command.Parameters[2].Value = Preco;
            //command.Parameters[3].Value = IdCategoria;
            command.Parameters[3].Value = IdFornecedor;

            try
            {
                command.ExecuteNonQuery();
                tran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro = "+ex);
                tran.Rollback();
                return false;
            }
            finally
            {
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
                sqlCommand.CommandText = "select * from produto";

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
                sqlCommand.CommandText = "select * from produto where nome = @nome";
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
