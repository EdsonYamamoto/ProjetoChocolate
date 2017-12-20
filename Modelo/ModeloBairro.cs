using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloBairro
    {

        public ModeloBairro()
        {
            this.IDBairro = 0;
            this.NomeBairro = "";
            this.DescricaoBairro = "";
        }
        public ModeloBairro(int idbairro, String nome, String descricao)
        {
            this.IDBairro = idbairro;
            this.NomeBairro = nome;
            this.DescricaoBairro = descricao;

        }
        private int idbairro;
        public int IDBairro
        {
            get { return this.idbairro; }
            set { this.idbairro = value; }
        }

        private String nome;
        public String NomeBairro
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        private String descricao;
        public String DescricaoBairro
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }
    }
}
