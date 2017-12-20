using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCidade
    {
        public ModeloCidade()
        {
            this.IDCidade = 0;
            this.NomeCidade = "";
            this.DescricaoCidade = "";
        }
        public ModeloCidade(int idcidade,String nome, String descricao)
        {
            this.IDCidade = idcidade;
            this.NomeCidade = nome;
            this.DescricaoCidade = descricao;
        }

        private int idcidade;
        public int IDCidade
        {
            get { return this.idcidade; }
            set { this.idcidade = value; }
        }

        private String nome;
        public String NomeCidade
        {
            get { return this.nome; }
            set { this.nome = value; }
        }
        private String descricao;
        public String DescricaoCidade
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }
    }
}
