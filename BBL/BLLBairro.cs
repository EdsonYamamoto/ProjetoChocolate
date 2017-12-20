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
    public class BLLBairro
    {
        private DALConexao conexao;

        public BLLBairro(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloBairro modelo)
        {
            if (modelo.NomeBairro.Trim().Length==0)
            {
                throw new Exception("Nome do Bairro é obrigatório");
            }

            modelo.NomeBairro = modelo.NomeBairro.ToUpper();

            DALBairro DALobj = new DALBairro(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloBairro modelo)
        {
            if(modelo.IDBairro <= 0)
            {
                throw new Exception("ID do Bairro é obrigatório");
            }
            if (modelo.NomeBairro.Trim().Length == 0)
            {
                throw new Exception("Nome do Bairro é obrigatório");
            }

            modelo.NomeBairro = modelo.NomeBairro.ToUpper();

            DALBairro DALobj = new DALBairro(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALBairro DALobj = new DALBairro(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALBairro DALobj = new DALBairro(conexao);
            return DALobj.Localizar(valor);
        }

        public int VerificaExistente(String valor)
        {
            DALBairro DALobj = new DALBairro(conexao);
            return DALobj.VerificaExistente(valor);
        }

        public ModeloBairro CarregaModeloBairro(int codigo)
        {
            DALBairro DALobj = new DALBairro(conexao);
            return DALobj.CarregaModeloBairro(codigo);
        }
    }
}
