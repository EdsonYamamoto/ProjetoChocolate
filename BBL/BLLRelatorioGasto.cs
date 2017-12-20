using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL
{
    public class BLLRelatorioGasto
    {
        private DALConexao conexao;

        public BLLRelatorioGasto(DALConexao cx)
        {
            this.conexao = cx;
        }

        public DataTable LocalizarGastos()
        {
            DALRelatorioGasto DALobj = new DALRelatorioGasto(conexao);
            return DALobj.LocalizarGastos();
        }
        public DataTable LocalizarGastosProduto()
        {
            DALRelatorioGasto DALobj = new DALRelatorioGasto(conexao);
            return DALobj.LocalizarGastosProduto();
        }
        public DataTable LocalizarGastoData()
        {
            DALRelatorioGasto DALobj = new DALRelatorioGasto(conexao);
            return DALobj.LocalizarGastoData();
        }
    }
}
