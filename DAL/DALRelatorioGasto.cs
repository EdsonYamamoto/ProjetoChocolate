
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALRelatorioGasto
    {
        private DALConexao conexao;
        public DALRelatorioGasto(DALConexao cx)
        {
            this.conexao = cx;
        }

        public DataTable LocalizarGastos()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXEC spRelatorioGasto", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarGastosProduto()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXEC spRelatorioGastoProdutos", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarGastoData()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXEC spRelatorioGastoData", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
    }
}
