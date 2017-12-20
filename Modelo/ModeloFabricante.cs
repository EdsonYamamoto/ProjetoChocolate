using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloFabricante
    {
        public ModeloFabricante()
        {
            this.IDFabricante = 0;
            this.NomeFabricante = "";
            this.DescricaoFabricante = "";
        }
        public ModeloFabricante(int idfabricante, String nomefabricante, String descricaofabricante)
        {
            this.IDFabricante = idfabricante;
            this.NomeFabricante = nomefabricante;
            this.DescricaoFabricante = descricaofabricante;
        }

        private int idfabricante;
        public int IDFabricante
        {
            get { return this.idfabricante; }
            set { this.idfabricante = value; }
        }

        private String nomefabricante;
        public String NomeFabricante
        {
            get { return this.nomefabricante; }
            set { this.nomefabricante = value; }
        }

        private String descricaofabricante;
        public String DescricaoFabricante
        {
            get { return this.descricaofabricante; }
            set { this.descricaofabricante = value; }
        }
    }
}
