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
    public class BLLCaracteristicaManufaturado1
    {
        private DALConexao conexao;

        public BLLCaracteristicaManufaturado1(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCaracteristicaManufaturado1 modelo)
        {
            if (modelo.NomeCaracteristicaManufaturado1.Trim().Length == 0)
            {
                throw new Exception("Nome do CaracteristicaManufaturado1 é obrigatório");
            }

            modelo.NomeCaracteristicaManufaturado1 = modelo.NomeCaracteristicaManufaturado1.ToUpper();
            DALCaracteristicaManufaturado1 DALobj = new DALCaracteristicaManufaturado1(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloCaracteristicaManufaturado1 modelo)
        {
            if (modelo.NomeCaracteristicaManufaturado1.Trim().Length == 0)
            {
                throw new Exception("Nome do CaracteristicaManufaturado1 é obrigatório");
            }
            if (modelo.IDCaracteristicaManufaturado1 <= 0)
            {
                throw new Exception("Codigo do CaracteristicaManufaturado1 é obrigatório");
            }

            modelo.NomeCaracteristicaManufaturado1 = modelo.NomeCaracteristicaManufaturado1.ToUpper();
            DALCaracteristicaManufaturado1 DALobj = new DALCaracteristicaManufaturado1(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCaracteristicaManufaturado1 DALobj = new DALCaracteristicaManufaturado1(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALCaracteristicaManufaturado1 DALobj = new DALCaracteristicaManufaturado1(conexao);
            return DALobj.Localizar(valor);
        }

        public int VerificaExistente(String valor)
        {
            DALCaracteristicaManufaturado1 DALobj = new DALCaracteristicaManufaturado1(conexao);
            return DALobj.VerificaExistente(valor);
        }

        public ModeloCaracteristicaManufaturado1 CarregaModeloCaracteristicaManufaturado1(int codigo)
        {
            DALCaracteristicaManufaturado1 DALobj = new DALCaracteristicaManufaturado1(conexao);
            return DALobj.CarregaModeloCaracteristicaManufaturado1(codigo);
        }
    }
}
