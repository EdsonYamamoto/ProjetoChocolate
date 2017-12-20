using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCaracteristicaManufaturado1
    {
        public ModeloCaracteristicaManufaturado1()
        {
            this.IDCaracteristicaManufaturado1 = 0;
            this.NomeCaracteristicaManufaturado1 = "";
            this.DescricaoCaracteristicaManufaturado1 = "";
        }

        public ModeloCaracteristicaManufaturado1(int idCaracteristicamanufaturado1, String nomeCaracteristicamanufaturado1, String descricaoCaracteristicamanufaturado1)
        {
            this.IDCaracteristicaManufaturado1 = idCaracteristicamanufaturado1;
            this.NomeCaracteristicaManufaturado1 = nomeCaracteristicamanufaturado1;
            this.DescricaoCaracteristicaManufaturado1 = descricaoCaracteristicamanufaturado1;
        }

        private int idCaracteristicamanufaturado1;
        public int IDCaracteristicaManufaturado1
        {
            get { return this.idCaracteristicamanufaturado1; }
            set { this.idCaracteristicamanufaturado1 = value; }
        }
        private String nomeCaracteristicamanufaturado1;
        public String NomeCaracteristicaManufaturado1
        {
            get { return this.nomeCaracteristicamanufaturado1; }
            set { this.nomeCaracteristicamanufaturado1 = value; }
        }
        private String descricaoCaracteristicamanufaturado1;
        public String DescricaoCaracteristicaManufaturado1
        {
            get { return this.descricaoCaracteristicamanufaturado1; }
            set { this.descricaoCaracteristicamanufaturado1 = value; }
        }
    }
}