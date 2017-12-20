
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;

namespace BBL
{
    public class BLLCliente
    {

        private DALConexao conexao;

        public BLLCliente(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCliente modelo)
        {
            if (modelo.NomeCliente.Trim().Length == 0)
            {
                throw new Exception("Nome do cliente é obrigatório");
            }
            if (modelo.CelularCliente <= 0)
            {
                throw new Exception("Número do telefone1 do cliente é obrigatório");
            }
            modelo.NomeCliente = modelo.NomeCliente.ToUpper();

            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloCliente modelo)
        {
            if (modelo.NomeCliente.Trim().Length == 0)
            {
                throw new Exception("Nome do cliente é obrigatório");
            }
            if (modelo.CelularCliente == 0)
            {
                throw new Exception("Número do telefone1 do cliente é obrigatório");
            }
            if (modelo.IDCliente <= 0)
            {
                throw new Exception("Codigo do cliente é obrigatório");
            }

            modelo.NomeCliente = modelo.NomeCliente.ToUpper();

            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCliente DALobj = new DALCliente(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.Localizar(valor);
        }
        
        public ModeloCliente CarregaModeloCliente(int codigo)
        {
            DALCliente DALobj = new DALCliente(conexao);
            return DALobj.CarregaModeloCliente(codigo);
        }
    }
}
