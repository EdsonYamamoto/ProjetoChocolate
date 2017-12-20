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
    public class BLLCusto
    {
        private DALConexao conexao;

        public BLLCusto(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCusto modelo)
        {
            if (modelo.NomeCusto.Trim().Length == 0)
            {
                throw new Exception("Nome do orçamento é obrigatório");
            }
            if (modelo.IDFabricante <= 0)
            {
                throw new Exception("Nome do Fabricante é obrigatório");
            }
            if (modelo.IDUnidadeMedida <= 0)
            {
                throw new Exception("Nome da unidade de medida é obrigatório");
            }
            modelo.NomeCusto = modelo.NomeCusto.ToUpper();

            DALCusto DALobj = new DALCusto(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloCusto modelo)
        {
            if (modelo.IDCusto < 0)
            {
                throw new Exception("ID da Custo é obrigatório");
            }
            if (modelo.NomeCusto.Trim().Length == 0)
            {
                throw new Exception("Nome da Custo é obrigatório");
            }
            if (modelo.IDFabricante <= 0)
            {
                throw new Exception("Nome do Fabricante é obrigatório");
            }
            modelo.NomeCusto = modelo.NomeCusto.ToUpper();

            DALCusto DALobj = new DALCusto(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCusto DALobj = new DALCusto(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALCusto DALobj = new DALCusto(conexao);
            return DALobj.Localizar(valor);
        }

        public ModeloCusto CarregaModeloCusto(int codigo)
        {
            DALCusto DALobj = new DALCusto(conexao);
            return DALobj.CarregaModeloCusto(codigo);
        }
    }
}

