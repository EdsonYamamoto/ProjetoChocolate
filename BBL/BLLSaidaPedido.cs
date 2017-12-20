using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL
{
    public class BLLSaidaPedido
    {
        private DALConexao conexao;

        public BLLSaidaPedido(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloSaidaPedido modelo)
        {
            if (modelo.IDPedido < 0)
            {
                throw new Exception("Pedido é obrigatório.");
            }
            if (modelo.Pago < 0)
            {
                throw new Exception("Pagamento é obrigatório, necessário utilizar ','.");
            }
            if (modelo.QuantidadeEntregue < 0)
            {
                throw new Exception("A quantidade entregue é obrigatório.");
            }

            DALSaidaPedido DALobj = new DALSaidaPedido(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloSaidaPedido modelo)
        {
            if (modelo.IDPedido < 0)
            {
                throw new Exception("Pedido é obrigatório.");
            }
            if (modelo.Pago < 0)
            {
                throw new Exception("Pagamento é obrigatório, necessário utilizar ','.");
            }
            if (modelo.QuantidadeEntregue < 0)
            {
                throw new Exception("A quantidade entregue é obrigatório.");
            }

            DALSaidaPedido DALobj = new DALSaidaPedido(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALSaidaPedido DALobj = new DALSaidaPedido(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALSaidaPedido DALobj = new DALSaidaPedido(conexao);
            return DALobj.Localizar(valor);
        }
        public ModeloSaidaPedido CarregaModeloSaidaPedido(int codigo)
        {
            DALSaidaPedido DALobj = new DALSaidaPedido(conexao);
            return DALobj.CarregaModeloSaidaPedido(codigo);
        }
    }
}
