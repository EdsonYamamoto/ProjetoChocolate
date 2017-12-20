
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
            SqlDataAdapter da = new SqlDataAdapter("SELECT TipoManufaturado.Nome Tipo, CaracteristicaManufaturado1.Nome, CaracteristicaManufaturado2.Nome, Manufaturado.Nome Manufaturado, SUM(Pedido.Quantidade) QTD, SUM(Pedido.Quantidade * Manufaturado.Preco) Ganho_total FROM Pedido " +
                 " INNER JOIN Manufaturado ON Manufaturado.ID_Manufaturado = Pedido.ID_Manufaturado" +
                 " INNER JOIN TipoManufaturado ON TipoManufaturado.ID_TipoManufaturado = Manufaturado.ID_TipoManufaturado" +
                 " INNER JOIN CaracteristicaManufaturado1 ON CaracteristicaManufaturado1.ID_CaracteristicaManufaturado1 = Manufaturado.ID_CaracteristicaManufaturado1" +
                 " INNER JOIN CaracteristicaManufaturado2 ON CaracteristicaManufaturado2.ID_CaracteristicaManufaturado2 = Manufaturado.ID_CaracteristicaManufaturado2" +
                 " GROUP BY TipoManufaturado.Nome, CaracteristicaManufaturado1.Nome, CaracteristicaManufaturado2.Nome, Manufaturado.Nome", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarGanhosCliente()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Cliente.ID_Cliente, Cliente.Nome, TipoManufaturado.Nome Tipo, CaracteristicaManufaturado1.Nome, CaracteristicaManufaturado2.Nome, Manufaturado.Nome Manufaturado, SUM( Pedido.Quantidade) QTD FROM Pedido  " +
                 " INNER JOIN Cliente cliente ON cliente.ID_Cliente = Pedido.ID_Cliente" +
                 " INNER JOIN Manufaturado ON Manufaturado.ID_Manufaturado = Pedido.ID_Manufaturado" +
                 " INNER JOIN TipoManufaturado ON TipoManufaturado.ID_TipoManufaturado = Manufaturado.ID_TipoManufaturado" +
                 " INNER JOIN CaracteristicaManufaturado1 ON CaracteristicaManufaturado1.ID_CaracteristicaManufaturado1 = Manufaturado.ID_CaracteristicaManufaturado1" +
                 " INNER JOIN CaracteristicaManufaturado2 ON CaracteristicaManufaturado2.ID_CaracteristicaManufaturado2 = Manufaturado.ID_CaracteristicaManufaturado2" +
                 " INNER JOIN UnidadeMedida ON UnidadeMedida.ID_UnidadeMedida = Manufaturado.ID_UnidadeMedida" +
                 " INNER JOIN Orcamento ON Orcamento.ID_Orcamento = Pedido.ID_Orcamento" +
                 " GROUP BY Cliente.ID_Cliente, Cliente.Nome, TipoManufaturado.Nome, CaracteristicaManufaturado1.Nome, CaracteristicaManufaturado2.Nome, Manufaturado.Nome", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarPedidoData()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT Cliente.Nome,CAST(Orcamento.DataReg as DATE) Data, COUNT(Orcamento.DataReg) QTD FROM Pedido   " +
                 " INNER JOIN Cliente cliente ON cliente.ID_Cliente = Pedido.ID_Cliente " +
                 " INNER JOIN Orcamento ON Orcamento.ID_Orcamento = Pedido.ID_Orcamento " +
                 " GROUP BY Cliente.Nome, Orcamento.DataReg", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
    }
}
