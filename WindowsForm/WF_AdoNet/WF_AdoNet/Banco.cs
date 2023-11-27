using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_AdoNet
{
    internal class Banco
    {
        public string conec = "Data Source=localhost;" +//onde o banco está
            "Initial Catalog=ado_net;" +//banco a ser usado
            "User ID=adonet;" +//usuario
            "password=senha1234;" +//senha
            "language=Portuguese;";//idioma

        private SqlConnection cn;

        private void conexao()
        {
            cn = new SqlConnection(conec);
        }

        public SqlConnection abrirConexao()
        {
            try
            {
                conexao();
                cn.Open();

                return cn;
            }
            catch (Exception ex)
            {
                return null;
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
                throw ex;
            }
        }

        /*
         public DataTable buscaDataTable()
        {
            Banco bd = new Banco();
            try
            {
                SqlConnection cn = bd.abrirConexao();
 
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = cn;
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.CommandText = "select * from pessoas";
 
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
         */
    }
}
