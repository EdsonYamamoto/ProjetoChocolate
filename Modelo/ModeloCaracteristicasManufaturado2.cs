using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCaracteristicaManufaturado2
    {
        public ModeloCaracteristicaManufaturado2()
        {
            this.IDCaracteristicaManufaturado2 = 0;
            this.NomeCaracteristicaManufaturado2 = "";
            this.DescricaoCaracteristicaManufaturado2 = "";
        }

        public ModeloCaracteristicaManufaturado2(int idCaracteristicamanufaturado2, String nomeCaracteristicamanufaturado2, String descricaoCaracteristicamanufaturado2)
        {
            this.IDCaracteristicaManufaturado2 = idCaracteristicamanufaturado2;
            this.NomeCaracteristicaManufaturado2 = nomeCaracteristicamanufaturado2;
            this.DescricaoCaracteristicaManufaturado2 = descricaoCaracteristicamanufaturado2;
        }

        private int idCaracteristicamanufaturado2;
        public int IDCaracteristicaManufaturado2
        {
            get { return this.idCaracteristicamanufaturado2; }
            set { this.idCaracteristicamanufaturado2 = value; }
        }
        private String nomeCaracteristicamanufaturado2;
        public String NomeCaracteristicaManufaturado2
        {
            get { return this.nomeCaracteristicamanufaturado2; }
            set { this.nomeCaracteristicamanufaturado2 = value; }
        }
        private String descricaoCaracteristicamanufaturado2;
        public String DescricaoCaracteristicaManufaturado2
        {
            get { return this.descricaoCaracteristicamanufaturado2; }
            set { this.descricaoCaracteristicamanufaturado2 = value; }
        }
    }
}