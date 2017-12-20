using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloTipoManufaturado
    {
        public ModeloTipoManufaturado()
        {
            this.IDTipoManufaturado = 0;
            this.NomeTipoManufaturado = "";
            this.DescricaoTipoManufaturado = "";
        }

        public ModeloTipoManufaturado(int idtipomanufaturado, String nometipomanufaturado,String descricaotipomanufaturado)
        {
            this.IDTipoManufaturado = idtipomanufaturado;
            this.NomeTipoManufaturado = nometipomanufaturado;
            this.DescricaoTipoManufaturado = descricaotipomanufaturado;
        }
        
        private int idtipomanufaturado;
        public int IDTipoManufaturado
        {
            get { return this.idtipomanufaturado; }
            set { this.idtipomanufaturado = value; }
        }
        private String nometipomanufaturado;
        public String NomeTipoManufaturado
        {
            get { return this.nometipomanufaturado; }
            set { this.nometipomanufaturado = value; }
        }
        private String descricaotipomanufaturado;
        public String DescricaoTipoManufaturado
        {
            get { return this.descricaotipomanufaturado; }
            set { this.descricaotipomanufaturado = value; }
        }
    }
}