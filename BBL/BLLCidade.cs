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
    public class BLLCidade
    {
        private DALConexao conexao;

        public BLLCidade(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCidade modelo)
        {
            if (modelo.NomeCidade.Trim().Length==0)
            {
                throw new Exception("Nome da cidade é obrigatório");
            }

            modelo.NomeCidade = modelo.NomeCidade.ToUpper();

            DALCidade DALobj = new DALCidade(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloCidade modelo)
        {
            if(modelo.IDCidade <= 0)
            {
                throw new Exception("ID da cidade é obrigatório");
            }
            if (modelo.NomeCidade.Trim().Length == 0)
            {
                throw new Exception("Nome da Cidade é obrigatório");
            }

            modelo.NomeCidade = modelo.NomeCidade.ToUpper();

            DALCidade DALobj = new DALCidade(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCidade DALobj = new DALCidade(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALCidade DALobj = new DALCidade(conexao);
            return DALobj.Localizar(valor);
        }

        public int VerificaExistente(String valor)
        {
            DALCidade DALobj = new DALCidade(conexao);
            return DALobj.VerificaExistente(valor);
        }

        public ModeloCidade CarregaModeloCidade(int codigo)
        {
            DALCidade DALobj = new DALCidade(conexao);
            return DALobj.CarregaModeloCidade(codigo);
        }
    }
}
