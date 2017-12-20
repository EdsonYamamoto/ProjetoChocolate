using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloManufaturado
    {
        public ModeloManufaturado()
        {
            this.IDManufaturado = 0;
            this.IDTipoManufaturado = 0;
            this.NomeManufaturado = "";
            this.IDUnidadeMedida = 0;
            this.QuantidadeManufaturado = 0;
            this.IDCaracteristicaManufaturado1 = 0;
            this.IDCaracteristicaManufaturado2 = 0;
            this.PrecoManufaturado = 0;
            this.DescricaoManufaturado = "";
        }
        public ModeloManufaturado(int idmanufaturado, int idtipomanufaturado, String nomemanufaturado, int idunidademedida, float quantidademanufaturado, int idcaracteristicamanufaturado1, int idcaracteristicamanufaturado2 , float precomanufaturado, String descricaomanufaturado)
        {
            this.IDManufaturado = idmanufaturado;
            this.IDTipoManufaturado = idtipomanufaturado;
            this.NomeManufaturado = nomemanufaturado;
            this.IDUnidadeMedida = idunidademedida;
            this.QuantidadeManufaturado = quantidademanufaturado;
            this.IDCaracteristicaManufaturado1 = idcaracteristicamanufaturado1;
            this.IDCaracteristicaManufaturado2 = idcaracteristicamanufaturado2;
            this.PrecoManufaturado = precomanufaturado;
            this.DescricaoManufaturado = descricaomanufaturado;
        }
        
        private int idmanufaturado;
        public int IDManufaturado
        {
            get { return this.idmanufaturado; }
            set { this.idmanufaturado = value; }
        }

        private int idtipomanufaturado;
        public int IDTipoManufaturado
        {
            get { return this.idtipomanufaturado; }
            set { this.idtipomanufaturado = value; }
        }

        private String nomemanufaturado;
        public String NomeManufaturado
        {
            get { return this.nomemanufaturado; }
            set { this.nomemanufaturado = value; }
        }

        private int idunidademedida;
        public int IDUnidadeMedida
        {
            get { return this.idunidademedida; }
            set { this.idunidademedida = value; }
        }

        private float pesomanufaturado;
        public float QuantidadeManufaturado
        {
            get { return this.pesomanufaturado; }
            set { this.pesomanufaturado = value; }
        }
        private int idcaracteristicamanufaturado1;
        public int IDCaracteristicaManufaturado1
        {
            get { return this.idcaracteristicamanufaturado1; }
            set { this.idcaracteristicamanufaturado1 = value; }
        }
        private int idcaracteristicamanufaturado2;
        public int IDCaracteristicaManufaturado2
        {
            get { return this.idcaracteristicamanufaturado2; }
            set { this.idcaracteristicamanufaturado2 = value; }
        }

        private float precomanufaturado;
        public float PrecoManufaturado
        {
            get { return this.precomanufaturado; }
            set { this.precomanufaturado = value; }
        }

        private String descricaomanufaturado;
        public String DescricaoManufaturado
        {
            get { return this.descricaomanufaturado; }
            set { this.descricaomanufaturado = value; }
        }
    }
}

