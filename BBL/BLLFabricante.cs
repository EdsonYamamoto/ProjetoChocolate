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
    public class BLLFabricante
    {
        private DALConexao conexao;

        public BLLFabricante(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloFabricante modelo)
        {
            if (modelo.NomeFabricante.Trim().Length == 0)
            {
                throw new Exception("Nome do fabricante é obrigatório");
            }

            modelo.NomeFabricante = modelo.NomeFabricante.ToUpper();

            DALFabricante DALobj = new DALFabricante(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloFabricante modelo)
        {
            if (modelo.IDFabricante < 0)
            {
                throw new Exception("ID da Fabricante é obrigatório");
            }
            if (modelo.NomeFabricante.Trim().Length == 0)
            {
                throw new Exception("Nome da Fabricante é obrigatório");
            }

            modelo.NomeFabricante = modelo.NomeFabricante.ToUpper();

            DALFabricante DALobj = new DALFabricante(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALFabricante DALobj = new DALFabricante(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALFabricante DALobj = new DALFabricante(conexao);
            return DALobj.Localizar(valor);
        }

        public int VerificaExistente(String valor)
        {
            DALFabricante DALobj = new DALFabricante(conexao);
            return DALobj.VerificaExistente(valor);
        }

        public ModeloFabricante CarregaModeloFabricante(int codigo)
        {
            DALFabricante DALobj = new DALFabricante(conexao);
            return DALobj.CarregaModeloFabricante(codigo);
        }
    }
}
