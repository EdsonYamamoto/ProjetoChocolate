using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBL
{
    public class BLLRelatorioPedido
    {
        private DALConexao conexao;

        public BLLRelatorioPedido(DALConexao cx)
        {
            this.conexao = cx;
        }
        
        public DataTable LocalizarGanhos()
        {
            DALRelatorioGanho DALobj = new DALRelatorioGanho(conexao);
            return DALobj.LocalizarGanhos();
        }
        public DataTable LocalizarPedidoData()
        {
            DALRelatorioGanho DALobj = new DALRelatorioGanho(conexao);
            return DALobj.LocalizarPedidoData();
        }
        public DataTable LocalizarPedidoCliente()
        {
            DALRelatorioGanho DALobj = new DALRelatorioGanho(conexao);
            return DALobj.LocalizarGanhosCliente();
        }
    }
}
