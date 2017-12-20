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
    public class BLLUnidadeMedida
    {
        private DALConexao conexao;

        public BLLUnidadeMedida(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloUnidadeMedida modelo)
        {
            if (modelo.NomeUnidadeMedida.Trim().Length == 0)
            {
                throw new Exception("Nome da unidade é obrigatório");
            }

            modelo.NomeUnidadeMedida = modelo.NomeUnidadeMedida.ToUpper();

            DALUnidadeMedida DALobj = new DALUnidadeMedida(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloUnidadeMedida modelo)
        {
            if (modelo.IDUnidadeMedida < 0)
            {
                throw new Exception("ID da UnidadeMedida é obrigatório");
            }
            if (modelo.NomeUnidadeMedida.Trim().Length == 0)
            {
                throw new Exception("Nome da UnidadeMedida é obrigatório");
            }

            modelo.NomeUnidadeMedida = modelo.NomeUnidadeMedida.ToUpper();

            DALUnidadeMedida DALobj = new DALUnidadeMedida(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALUnidadeMedida DALobj = new DALUnidadeMedida(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALUnidadeMedida DALobj = new DALUnidadeMedida(conexao);
            return DALobj.Localizar(valor);
        }

        public int VerificaExistente(String valor)
        {
            DALUnidadeMedida DALobj = new DALUnidadeMedida(conexao);
            return DALobj.VerificaExistente(valor);
        }

        public ModeloUnidadeMedida CarregaModeloUnidadeMedida(int codigo)
        {
            DALUnidadeMedida DALobj = new DALUnidadeMedida(conexao);
            return DALobj.CarregaModeloUnidadeMedida(codigo);
        }
    }
}
