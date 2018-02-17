using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALRelatorioVenda
    {
        private DALConexao conexao;
        public DALRelatorioVenda(DALConexao cx)
        {
            this.conexao = cx;
        }

        public DataTable LocalizarVenda()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXEC spRelatorioVenda", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarVendaManufaturado()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXEC spRelatorioVendaFaturado", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarVendaFabricar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXEC spRelatorioVendaFabricar", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

    }
}
