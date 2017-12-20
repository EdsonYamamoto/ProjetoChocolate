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
    public class BLLPedido
    {
        private DALConexao conexao;

        public BLLPedido(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloPedido modelo)
        {
            if (modelo.IDCliente < 0)
            {
                throw new Exception("Cliente do Pedido é obrigatório");
            }
            if (modelo.IDOrcamento < 0)
            {
                throw new Exception("Orcamento do Pedido é obrigatório");
            }
            if (modelo.IDPedido < 0)
            {
                throw new Exception("Codigo do Pedido é obrigatório");
            }
            
            DALPedido DALobj = new DALPedido(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloPedido modelo)
        {
            if (modelo.IDCliente < 0)
            {
                throw new Exception("Cliente do Pedido é obrigatório");
            }

            if (modelo.IDOrcamento < 0)
            {
                throw new Exception("Orcamento do Pedido é obrigatório");
            }

            if (modelo.IDPedido < 0)
            {
                throw new Exception("Codigo do Pedido é obrigatório");
            }
            
            DALPedido DALobj = new DALPedido(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALPedido DALobj = new DALPedido(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALPedido DALobj = new DALPedido(conexao);
            return DALobj.Localizar(valor);
        }

        public DataTable LocalizarOrcamento(int valor)
        {
            DALPedido DALobj = new DALPedido(conexao);
            return DALobj.LocalizarOrcamento(valor);
        }

        public ModeloPedido CarregaModeloPedido(int codigo)
        {
            DALPedido DALobj = new DALPedido(conexao);
            return DALobj.CarregaModeloPedido(codigo);
        }
        
    }
}
