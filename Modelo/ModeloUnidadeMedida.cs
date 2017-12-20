using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloUnidadeMedida
    {
        public ModeloUnidadeMedida()
        {
            this.IDUnidadeMedida = 0;
            this.NomeUnidadeMedida = "";
        }
        public ModeloUnidadeMedida(int idunidademedida, String nomeunidademedida)
        {
            this.IDUnidadeMedida = idunidademedida;
            this.NomeUnidadeMedida = nomeunidademedida;
        }

        private int idunidademedida;
        public int IDUnidadeMedida
        {
            get { return this.idunidademedida; }
            set { this.idunidademedida = value; }
        }

        private String nomeunidademedida;
        public String NomeUnidadeMedida
        {
            get { return this.nomeunidademedida; }
            set { this.nomeunidademedida = value; }
        }
    }
}
