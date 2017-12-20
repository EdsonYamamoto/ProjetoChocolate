using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloOrcamento
    {
        public ModeloOrcamento()
        {
            this.IDOrcamento = 0;
            this.NomeOrcamento = "";
        }
        public ModeloOrcamento(int idorcamento, String nomeorcamento)
        {
            this.IDOrcamento = idorcamento;
            this.NomeOrcamento = nomeorcamento;
        }

        private int idorcamento;
        public int IDOrcamento
        {
            get { return this.idorcamento; }
            set { this.idorcamento = value; }
        }

        private String nomeorcamento;
        public String NomeOrcamento
        {
            get { return this.nomeorcamento; }
            set { this.nomeorcamento = value; }
        }
    }
}
