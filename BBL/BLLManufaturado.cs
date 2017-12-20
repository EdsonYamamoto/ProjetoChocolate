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
    public class BLLManufaturado
    {
        private DALConexao conexao;

        public BLLManufaturado(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloManufaturado modelo)
        {
            if (modelo.NomeManufaturado.Trim().Length == 0)
            {
                throw new Exception("Nome do Manufaturado é obrigatório");
            }
            if (modelo.IDManufaturado < 0)
            {
                throw new Exception("Codigo do Manufaturado é obrigatório");
            }

            modelo.NomeManufaturado = modelo.NomeManufaturado.ToUpper();
            DALManufaturado DALobj = new DALManufaturado(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloManufaturado modelo)
        {
            if (modelo.NomeManufaturado.Trim().Length == 0)
            {
                throw new Exception("Nome do Manufaturado é obrigatório");
            }
            if (modelo.IDManufaturado <= 0)
            {
                throw new Exception("Codigo do Manufaturado é obrigatório");
            }

            modelo.NomeManufaturado = modelo.NomeManufaturado.ToUpper();

            DALManufaturado DALobj = new DALManufaturado(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALManufaturado DALobj = new DALManufaturado(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALManufaturado DALobj = new DALManufaturado(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloManufaturado CarregaModeloManufaturado(int codigo)
        {
            DALManufaturado DALobj = new DALManufaturado(conexao);
            return DALobj.CarregaModeloManufaturado(codigo);
        }

        public DataTable LocalizarModelo(ModeloManufaturado modelo)
        {
            DALManufaturado DALobj = new DALManufaturado(conexao);
            return DALobj.LocalizarModelo(modelo);
        }
    }
}

