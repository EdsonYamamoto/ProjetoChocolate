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
            cmd.CommandText = "INSERT INTO SaidaPedido(ID_Pedido,QuantidadeEntregue ,Pago ,SYSDATETIME, Descricao) VALUES (@idpedido, @qtdentregue, @pago, GETDATE(), @descricao); SELECT @@IDENTITY;";
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
            cmd.CommandText = "UPDATE SaidaPedido SET ID_Pedido = @idpedido , QuantidadeEntregue = @qtdentregue , Pago = @pago , SYSDATETIME = GETDATE() , Descricao = @descricao WHERE ID_SaidaManufaturado = @codigo;";
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
            cmd.CommandText = "DELETE FROM SaidaPedido WHERE ID_SaidaPedido = @codigo;";
            cmd.Parameters.AddWithValue("@codigo", codigo);
            conexao.Conectar();
            cmd.ExecuteNonQuery();
            conexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT ID_SaidaManufaturado,SaidaPedido.ID_Pedido, Cliente.Nome, Cliente.Celular ,TipoManufaturado.Nome, CaracteristicaManufaturado1.Nome, CaracteristicaManufaturado2.Nome, Manufaturado.Nome, Pedido.Quantidade QuantidadePedida, SaidaPedido.QuantidadeEntregue, SaidaPedido.Pago, SaidaPedido.SYSDATETIME, SaidaPedido.Descricao FROM SaidaPedido" +
                " INNER JOIN Pedido ON Pedido.ID_Pedido = SaidaPedido.ID_Pedido" +
                " INNER JOIN Orcamento ON Orcamento.ID_Orcamento = Pedido.ID_Orcamento" +
                " INNER JOIN Manufaturado ON Manufaturado.ID_Manufaturado = Pedido.ID_Manufaturado" +
                " INNER JOIN TipoManufaturado ON TipoManufaturado.ID_TipoManufaturado = Manufaturado.ID_TipoManufaturado" +
                " INNER JOIN CaracteristicaManufaturado1 ON CaracteristicaManufaturado1.ID_CaracteristicaManufaturado1 = Manufaturado.ID_CaracteristicaManufaturado1" +
                " INNER JOIN CaracteristicaManufaturado2 ON CaracteristicaManufaturado2.ID_CaracteristicaManufaturado2 = Manufaturado.ID_CaracteristicaManufaturado2" +
                " INNER JOIN Cliente ON Cliente.ID_Cliente = Pedido.ID_Cliente" +
                " WHERE Cliente.Nome LIKE '%" + valor + "%'", conexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }

        public ModeloSaidaPedido CarregaModeloSaidaPedido(int codigo)
        {
            ModeloSaidaPedido modelo = new ModeloSaidaPedido();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            cmd.CommandText = "SELECT * FROM SaidaPedido " +
           " INNER JOIN Pedido ON Pedido.ID_Pedido = SaidaPedido.ID_Pedido " +
           " INNER JOIN Manufaturado ON Manufaturado.ID_Manufaturado = Pedido.ID_Manufaturado " +
           " INNER JOIN TipoManufaturado ON TipoManufaturado.ID_TipoManufaturado = Manufaturado.ID_TipoManufaturado " +
           " INNER JOIN CaracteristicaManufaturado1 ON CaracteristicaManufaturado1.ID_CaracteristicaManufaturado1 = Manufaturado.ID_CaracteristicaManufaturado1 " +
           " INNER JOIN CaracteristicaManufaturado2 ON CaracteristicaManufaturado2.ID_CaracteristicaManufaturado2 = Manufaturado.ID_CaracteristicaManufaturado2 " +
           " INNER JOIN Cliente ON Cliente.ID_Cliente = Pedido.ID_Cliente " +
           " WHERE ID_SaidaManufaturado = @codigo";
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
