using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniERP
{
    internal class Banco
    {
        public string conec = "Data Source=localhost;" +//onde o banco está
            "Initial Catalog=mini_erp;" +//banco a ser usado
            "User ID=usuario3;" +//usuario
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

    }
}
