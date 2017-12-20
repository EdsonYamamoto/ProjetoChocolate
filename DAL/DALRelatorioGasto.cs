
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT Custo.ID_Custo, Fabricante.Nome, Custo.Nome, Custo.Quantidade,Custo.Unidade,UnidadeMedida.Nome, Custo.Preco PrecoUnitario, (Custo.Preco*Custo.Quantidade) AS Total, CAST(Custo.DataCompra AS DATE) DataRegistro FROM Custo"+
            " INNER JOIN Fabricante ON Fabricante.ID_Fabricante = Custo.ID_Fabricante"+
            " INNER JOIN UnidadeMedida ON UnidadeMedida.ID_UnidadeMedida = Custo.ID_UnidadeMedida", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarGastosProduto()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Fabricante.Nome, Custo.Nome, SUM(Custo.Quantidade) QTD,Custo.Unidade, UnidadeMedida.Nome,(SUM(Custo.Preco)*SUM(Custo.Quantidade))AS total FROM Custo" +
            " INNER JOIN Fabricante ON Fabricante.ID_Fabricante = Custo.ID_Fabricante" +
            " INNER JOIN UnidadeMedida ON UnidadeMedida.ID_UnidadeMedida = Custo.ID_UnidadeMedida" +
            " GROUP BY Fabricante.Nome, Custo.Nome, Custo.Unidade, UnidadeMedida.Nome", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarGastoData()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Fabricante.Nome, Custo.Nome, SUM(Custo.Quantidade) QTD,Custo.Unidade, UnidadeMedida.Nome,CAST(Custo.DataCompra AS DATE) DataRegistro FROM Custo" +
            " INNER JOIN Fabricante ON Fabricante.ID_Fabricante = Custo.ID_Fabricante" +
            " INNER JOIN UnidadeMedida ON UnidadeMedida.ID_UnidadeMedida = Custo.ID_UnidadeMedida" +
            " GROUP BY Fabricante.Nome, Custo.Nome, Custo.Unidade, UnidadeMedida.Nome, DataCompra", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
    }
}
