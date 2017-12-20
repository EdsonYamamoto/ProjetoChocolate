using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALPedido
    {
        private DALConexao conexao;

        public DALPedido(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloPedido modelo)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao.ObjetoConexao;

                cmd.CommandText = "EXECUTE spInserirPedido @cliente,@manufaturado,@orcamento,@quantidade,@desconto,@dataenvio,@descricao";
                cmd.Parameters.AddWithValue("@cliente", modelo.IDCliente);
                cmd.Parameters.AddWithValue("@manufaturado", modelo.IDManufaturado);
                cmd.Parameters.AddWithValue("@orcamento", modelo.IDOrcamento);
                cmd.Parameters.AddWithValue("@quantidade", modelo.QuantidadePedido);
                cmd.Parameters.AddWithValue("@desconto", modelo.DescontoPedido);
                cmd.Parameters.AddWithValue("@dataenvio", Convert.ToDateTime (modelo.DataEnvioPedido));
                cmd.Parameters.AddWithValue("@descricao", modelo.DescricaoPedido);
                
                conexao.Conectar();
                modelo.IDPedido = Convert.ToInt32(cmd.ExecuteScalar());
            }

            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }

            finally
            {
                conexao.Desconectar();
            }
        }

        public void Alterar(ModeloPedido modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spAlteraPedido @cliente,@manufaturado,@orcamento,@quantidade,@desconto,@dataenvio,@descricao,@codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.IDPedido);
            cmd.Parameters.AddWithValue("@cliente", modelo.IDCliente);
            cmd.Parameters.AddWithValue("@manufaturado", modelo.IDManufaturado);
            cmd.Parameters.AddWithValue("@orcamento", modelo.IDOrcamento);
            cmd.Parameters.AddWithValue("@quantidade", modelo.QuantidadePedido);
            cmd.Parameters.AddWithValue("@desconto", modelo.DescontoPedido);
            cmd.Parameters.AddWithValue("@dataenvio", modelo.DataEnvioPedido);
            cmd.Parameters.AddWithValue("@descricao", modelo.DescricaoPedido);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spExcluiPedido @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXECUTE spProcuraPedido '" + valor + "'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public DataTable LocalizarOrcamento(int valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXECUTE spProcuraPedidoOrcamento '" + valor + "'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloPedido CarregaModeloPedido(int codigo)
        {
            ModeloPedido modelo = new ModeloPedido();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXECUTE spProcuraIDPedido @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IDPedido = Convert.ToInt32(registro["ID_Pedido"]);
                modelo.IDCliente = Convert.ToInt32(registro["ID_Cliente"]);
                modelo.IDManufaturado = Convert.ToInt32(registro["ID_Manufaturado"]);
                modelo.IDTipoManufaturado = Convert.ToInt32(registro["ID_TipoManufaturado"]);
                modelo.IDCaracteristicaManufaturado1 = Convert.ToInt32(registro["ID_CaracteristicaManufaturado1"]);
                modelo.IDCaracteristicaManufaturado2 = Convert.ToInt32(registro["ID_CaracteristicaManufaturado2"]);
                modelo.IDOrcamento = Convert.ToInt32(registro["ID_Orcamento"]);
                modelo.QuantidadePedido = Convert.ToInt32(registro["Quantidade"]);
                modelo.DataEnvioPedido = Convert.ToDateTime(registro["DataEnvio"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
