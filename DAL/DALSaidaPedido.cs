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
    public class DALSaidaPedido
    {
        private DALConexao conexao;
        public DALSaidaPedido(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloSaidaPedido modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXEC spInserirSaidaPedido @idpedido, @qtdentregue, @pago, @descricao;";
            cmd.Parameters.AddWithValue("@idpedido", modelo.IDPedido);
            cmd.Parameters.AddWithValue("@pago", modelo.Pago);
            cmd.Parameters.AddWithValue("@qtdentregue", modelo.QuantidadeEntregue);
            cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);
            conexao.Conectar();
            modelo.IDSaidaPedido = Convert.ToInt32(cmd.ExecuteScalar());
            conexao.Desconectar();
        }

        public void Alterar(ModeloSaidaPedido modelo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXEC spAlteraSaidaPedido @idpedido , @qtdentregue , @pago , @descricao, @codigo;";
            cmd.Parameters.AddWithValue("@codigo", modelo.IDSaidaPedido);
            cmd.Parameters.AddWithValue("@idpedido", modelo.IDPedido);
            cmd.Parameters.AddWithValue("@pago", modelo.Pago);
            cmd.Parameters.AddWithValue("@qtdentregue", modelo.QuantidadeEntregue);
            cmd.Parameters.AddWithValue("@descricao", modelo.Descricao);

            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }
        public void Excluir(int codigo)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXEC spExcluiSaidaPedido @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("EXEC spProcuraSaidaPedido '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloSaidaPedido CarregaModeloSaidaPedido(int codigo)
        {
            ModeloSaidaPedido modelo = new ModeloSaidaPedido();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "EXEC spProcuraIDSaidaPedido @codigo";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows)
            {
                registro.Read();
                modelo.IDSaidaPedido = Convert.ToInt32(registro["ID_SaidaManufaturado"]);
                modelo.IDPedido = Convert.ToInt32(registro["ID_Pedido"]);
                modelo.QuantidadeEntregue = Convert.ToInt32(registro["QuantidadeEntregue"]);
                modelo.Pago = Convert.ToSingle(registro["Pago"]);
                modelo.Descricao = Convert.ToString(registro["Descricao"]);
                modelo.IDCliente = Convert.ToInt32(registro["ID_Cliente"]);
                modelo.IDManufaturado = Convert.ToInt32(registro["ID_Manufaturado"]);
                modelo.IDTipoManufaturado = Convert.ToInt32(registro["ID_TipoManufaturado"]);
                modelo.IDCaracteristicaManufaturado1 = Convert.ToInt32(registro["ID_CaracteristicaManufaturado1"]);
                modelo.IDCaracteristicaManufaturado2 = Convert.ToInt32(registro["ID_CaracteristicaManufaturado2"]);
            }
            conexao.Desconectar();
            return modelo;
        }
    }
}
