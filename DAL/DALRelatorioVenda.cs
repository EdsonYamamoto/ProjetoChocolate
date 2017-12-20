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
            SqlDataAdapter da = new SqlDataAdapter("SELECT pedido.ID_Orcamento, Orcamento.Nome,SUM(Pedido.Desconto) DescontoTotal, SUM( Manufaturado.Preco*Pedido.Quantidade)-SUM(Pedido.Desconto) TotalPedido, SUM(SaidaPedido.Pago) TotalPago, SUM( Manufaturado.Preco*Pedido.Quantidade)-SUM(Pedido.Desconto)-SUM(SaidaPedido.Pago) DiferencaTotal FROM pedido INNER JOIN Orcamento ON Orcamento.ID_Orcamento = Pedido.ID_Orcamento INNER JOIN Manufaturado ON Manufaturado.ID_Manufaturado = Pedido.ID_Manufaturado INNER JOIN SaidaPedido ON SaidaPedido.ID_Pedido = Pedido.ID_Pedido GROUP BY pedido.ID_Orcamento, Orcamento.Nome", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarVendaManufaturado()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT pedido.ID_Orcamento, Orcamento.Nome,TipoManufaturado.Nome, CaracteristicaManufaturado1.Nome,CaracteristicaManufaturado2.Nome,Manufaturado.Nome , Pedido.Quantidade qtdPedido, SUM(QuantidadeEntregue) qtdEntregue, SUM(Pedido.Quantidade - QuantidadeEntregue) faltaFabricar from saidapedido INNER JOIN Pedido ON Pedido.ID_Pedido = SaidaPedido.ID_Pedido INNER JOIN Orcamento ON Orcamento.ID_Orcamento = Pedido.ID_Orcamento INNER JOIN Manufaturado ON Manufaturado.ID_Manufaturado = Pedido.ID_Manufaturado INNER JOIN TipoManufaturado ON TipoManufaturado.ID_TipoManufaturado = Manufaturado.ID_TipoManufaturado INNER JOIN CaracteristicaManufaturado1 ON Manufaturado.ID_CaracteristicaManufaturado1 = CaracteristicaManufaturado1.ID_CaracteristicaManufaturado1 INNER JOIN CaracteristicaManufaturado2 ON Manufaturado.ID_CaracteristicaManufaturado2 = CaracteristicaManufaturado2.ID_CaracteristicaManufaturado2 GROUP BY pedido.ID_Orcamento, Orcamento.Nome,TipoManufaturado.Nome, CaracteristicaManufaturado1.Nome,CaracteristicaManufaturado2.Nome,Manufaturado.Nome, Pedido.Quantidade", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarVendaFabricar()
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TipoManufaturado.Nome, CaracteristicaManufaturado1.Nome,CaracteristicaManufaturado2.Nome,Manufaturado.Nome, SUM(Pedido.Quantidade - QuantidadeEntregue) Fabricar from saidapedido INNER JOIN Pedido ON Pedido.ID_Pedido = SaidaPedido.ID_Pedido INNER JOIN Orcamento ON Orcamento.ID_Orcamento = Pedido.ID_Orcamento INNER JOIN Manufaturado ON Manufaturado.ID_Manufaturado = Pedido.ID_Manufaturado INNER JOIN TipoManufaturado ON TipoManufaturado.ID_TipoManufaturado = Manufaturado.ID_TipoManufaturado INNER JOIN CaracteristicaManufaturado1 ON Manufaturado.ID_CaracteristicaManufaturado1 = CaracteristicaManufaturado1.ID_CaracteristicaManufaturado1 INNER JOIN CaracteristicaManufaturado2 ON Manufaturado.ID_CaracteristicaManufaturado2 = CaracteristicaManufaturado2.ID_CaracteristicaManufaturado2 GROUP BY TipoManufaturado.Nome, CaracteristicaManufaturado1.Nome,CaracteristicaManufaturado2.Nome,Manufaturado.Nome HAVING (SUM(Pedido.Quantidade - QuantidadeEntregue)>0) ", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

    }
}
