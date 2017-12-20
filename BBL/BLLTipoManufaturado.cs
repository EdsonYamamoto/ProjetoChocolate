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
    public class BLLTipoManufaturado
    {
        private DALConexao conexao;

        public BLLTipoManufaturado(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloTipoManufaturado modelo)
        {
            if (modelo.NomeTipoManufaturado.Trim().Length == 0)
            {
                throw new Exception("Nome do TipoManufaturado é obrigatório");
            }
            if (modelo.IDTipoManufaturado < 0)
            {
                throw new Exception("Codigo do TipoManufaturado é obrigatório");
            }

            modelo.NomeTipoManufaturado = modelo.NomeTipoManufaturado.ToUpper();
            DALTipoManufaturado DALobj = new DALTipoManufaturado(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloTipoManufaturado modelo)
        {
            if (modelo.NomeTipoManufaturado.Trim().Length == 0)
            {
                throw new Exception("Nome do TipoManufaturado é obrigatório");
            }
            if (modelo.IDTipoManufaturado <= 0)
            {
                throw new Exception("Codigo do TipoManufaturado é obrigatório");
            }

            modelo.NomeTipoManufaturado = modelo.NomeTipoManufaturado.ToUpper();
            DALTipoManufaturado DALobj = new DALTipoManufaturado(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALTipoManufaturado DALobj = new DALTipoManufaturado(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALTipoManufaturado DALobj = new DALTipoManufaturado(conexao);
            return DALobj.Localizar(valor);
        }

        public int VerificaExistente(String valor)
        {
            DALTipoManufaturado DALobj = new DALTipoManufaturado(conexao);
            return DALobj.VerificaExistente(valor);
        }

        public ModeloTipoManufaturado CarregaModeloTipoManufaturado(int codigo)
        {
            DALTipoManufaturado DALobj = new DALTipoManufaturado(conexao);
            return DALobj.CarregaModeloTipoManufaturado(codigo);
        }
    }
}
