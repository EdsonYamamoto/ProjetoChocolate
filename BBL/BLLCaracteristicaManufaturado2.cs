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
    public class BLLCaracteristicaManufaturado2
    {
        private DALConexao conexao;

        public BLLCaracteristicaManufaturado2(DALConexao cx)
        {
            this.conexao = cx;
        }

        public void Incluir(ModeloCaracteristicaManufaturado2 modelo)
        {
            if (modelo.NomeCaracteristicaManufaturado2.Trim().Length == 0)
            {
                throw new Exception("Nome do CaracteristicaManufaturado2 é obrigatório");
            }
            modelo.NomeCaracteristicaManufaturado2 = modelo.NomeCaracteristicaManufaturado2.ToUpper();
            DALCaracteristicaManufaturado2 DALobj = new DALCaracteristicaManufaturado2(conexao);
            DALobj.Incluir(modelo);
        }

        public void Alterar(ModeloCaracteristicaManufaturado2 modelo)
        {
            if (modelo.NomeCaracteristicaManufaturado2.Trim().Length == 0)
            {
                throw new Exception("Nome do CaracteristicaManufaturado2 é obrigatório");
            }
            if (modelo.IDCaracteristicaManufaturado2 <= 0)
            {
                throw new Exception("Codigo do CaracteristicaManufaturado2 é obrigatório");
            }

            modelo.NomeCaracteristicaManufaturado2 = modelo.NomeCaracteristicaManufaturado2.ToUpper();
            DALCaracteristicaManufaturado2 DALobj = new DALCaracteristicaManufaturado2(conexao);
            DALobj.Alterar(modelo);
        }

        public void Excluir(int codigo)
        {
            DALCaracteristicaManufaturado2 DALobj = new DALCaracteristicaManufaturado2(conexao);
            DALobj.Excluir(codigo);
        }

        public DataTable Localizar(String valor)
        {
            DALCaracteristicaManufaturado2 DALobj = new DALCaracteristicaManufaturado2(conexao);
            return DALobj.Localizar(valor);
        }

        public int VerificaExistente(String valor)
        {
            DALCaracteristicaManufaturado2 DALobj = new DALCaracteristicaManufaturado2(conexao);
            return DALobj.VerificaExistente(valor);
        }

        public ModeloCaracteristicaManufaturado2 CarregaModeloCaracteristicaManufaturado2(int codigo)
        {
            DALCaracteristicaManufaturado2 DALobj = new DALCaracteristicaManufaturado2(conexao);
            return DALobj.CarregaModeloCaracteristicaManufaturado2(codigo);
        }
    }
}
