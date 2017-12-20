using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL
{
    public class BLLRelatorioVendas
    {
        private DALConexao conexao;
        public BLLRelatorioVendas(DALConexao cx)
        {
            this.conexao = cx;
        }

        public DataTable LocalizarVenda()
        {
            DALRelatorioVenda DALobj = new DALRelatorioVenda(conexao);
            return DALobj.LocalizarVenda();
        }
        public DataTable LocalizarVendaManufaturado()
        {
            DALRelatorioVenda DALobj = new DALRelatorioVenda(conexao);
            return DALobj.LocalizarVendaManufaturado();
        }

        public DataTable LocalizarVendaFabricar()
        {
            DALRelatorioVenda DALobj = new DALRelatorioVenda(conexao);
            return DALobj.LocalizarVendaFabricar();
        }
    }
}
