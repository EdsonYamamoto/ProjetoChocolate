using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCusto
    {
        public ModeloCusto()
        {
            this.IDCusto = 0;
            this.IDFabricante = 0;
            this.NomeCusto = "";
            this.PrecoCusto = 0;
            this.QuantidadeCusto = 0;
            this.UnidadeCusto = 0;
            this.IDUnidadeMedida = 0;
            this.DescricaoCusto = "";

        }
        public ModeloCusto(int idcusto, int idfabricante, String nomecusto, float precocusto, int unidadecusto, float quantidadecusto, int unidademedida, String descricaocusto)
        {
            this.IDCusto = idcusto;
            this.IDFabricante = idfabricante;
            this.NomeCusto = nomecusto;
            this.PrecoCusto = precocusto;
            this.QuantidadeCusto = quantidadecusto;
            this.UnidadeCusto = unidadecusto;
            this.IDUnidadeMedida = unidademedida;
            this.DescricaoCusto = descricaocusto;
        }

        private int idcusto;
        public int IDCusto
        {
            get { return this.idcusto; }
            set { this.idcusto = value; }
        }

        private int idfabricante;
        public int IDFabricante
        {
            get { return this.idfabricante; }
            set { this.idfabricante = value; }
        }

        private String nomecusto;
        public String NomeCusto
        {
            get { return this.nomecusto; }
            set { this.nomecusto = value; }
        }
        private float precocusto;
        public float PrecoCusto
        {
            get { return this.precocusto; }
            set { this.precocusto = value; }
        }
        private float quantidadecusto;
        public float QuantidadeCusto
        {
            get { return this.quantidadecusto; }
            set { this.quantidadecusto = value; }
        }

        private float unidadecusto;
        public float UnidadeCusto
        {
            get { return this.unidadecusto; }
            set { this.unidadecusto = value; }
        }

        private int idunidademedida;
        public int IDUnidadeMedida
        {
            get { return this.idunidademedida; }
            set { this.idunidademedida = value; }
        }
        private String descricaocusto;
        public String DescricaoCusto
        {
            get { return this.descricaocusto; }
            set { this.descricaocusto = value; }
        }
    }
}
