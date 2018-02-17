
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALRelatorioGanho
    {
        private DALConexao conexao;
        public DALRelatorioGanho(DALConexao cx)
        {
            this.conexao = cx;
        }
        
        public DataTable LocalizarGanhos()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXEC spRelatorioGanhos", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarGanhosCliente()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXEC spRelatorioGanhosCliente", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPedidoData()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("spRelatorioPedidoData", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
    }
}
