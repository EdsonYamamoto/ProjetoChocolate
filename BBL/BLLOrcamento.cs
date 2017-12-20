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
    public class BLLOrcamento
    {
        private DALConexao conexao;

        public BLLOrcamento(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloOrcamento modelo)
        {
            if (modelo.NomeOrcamento.Trim().Length == 0)
            {
                throw new Exception("Nome do orçamento é obrigatório");
            }

            modelo.NomeOrcamento = modelo.NomeOrcamento.ToUpper();

            DALOrcamento DALobj = new DALOrcamento(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloOrcamento modelo)
        {
            if (modelo.IDOrcamento < 0)
            {
                throw new Exception("ID da Orcamento é obrigatório");
            }
            if (modelo.NomeOrcamento.Trim().Length == 0)
            {
                throw new Exception("Nome da Orcamento é obrigatório");
            }

            modelo.NomeOrcamento = modelo.NomeOrcamento.ToUpper();

            DALOrcamento DALobj = new DALOrcamento(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALOrcamento DALobj = new DALOrcamento(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALOrcamento DALobj = new DALOrcamento(conexao);
            return DALobj.Localizar(valor);
        }

        public DataTable LocalizarOrcamento(int valor)
        {
            DALPedido DALobj = new DALPedido(conexao);
            return DALobj.LocalizarOrcamento(valor);
        }


        public ModeloOrcamento CarregaModeloOrcamento(int codigo)
        {
            DALOrcamento DALobj = new DALOrcamento(conexao);
            return DALobj.CarregaModeloOrcamento(codigo);
        }
    }
}
