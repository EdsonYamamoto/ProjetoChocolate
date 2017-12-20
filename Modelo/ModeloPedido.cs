using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloPedido
    {
        public ModeloPedido()
        {
            this.IDPedido = 0;
            this.IDCliente = 0;
            this.IDManufaturado = 0;
            this.IDTipoManufaturado = 0;
            this.IDCaracteristicaManufaturado1 = 0;
            this.IDCaracteristicaManufaturado2 = 0;
            this.IDOrcamento = 0;
            this.QuantidadePedido = 0;
            this.DescontoPedido = 0;
            this.DescricaoPedido = "";
        }
        public ModeloPedido(int idpedido, int idcliente, int idmanufaturado, int idtipomanufaturado, int idcaracteristicamanufaturado1, int idcaracteristicamanufaturado2, int idorcamento, int quantidadepedido, float descontopedido, DateTime dataenviopedido , String nomeorcamento)
        {
            this.IDPedido = idpedido;
            this.IDCliente = idcliente;
            this.IDManufaturado = idmanufaturado;
            this.IDTipoManufaturado = idtipomanufaturado;
            this.IDCaracteristicaManufaturado1 = idcaracteristicamanufaturado1;
            this.IDCaracteristicaManufaturado2 = idcaracteristicamanufaturado2;
            this.IDOrcamento = idorcamento;
            this.QuantidadePedido = quantidadepedido;
            this.DescontoPedido = descontopedido;
            this.DataEnvioPedido = dataenviopedido;
            this.DescricaoPedido = descricaopedido;
        }

        private int idpedido;
        public int IDPedido
        {
            get { return this.idpedido; }
            set { this.idpedido = value; }
        }

        private int idcliente;
        public int IDCliente
        {
            get { return this.idcliente; }
            set { this.idcliente = value; }
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

        private int idorcamento;
        public int IDOrcamento
        {
            get { return this.idorcamento; }
            set { this.idorcamento = value; }
        }

        private int quantidadepedido;
        public int QuantidadePedido
        {
            get { return this.quantidadepedido; }
            set { this.quantidadepedido = value; }
        }

        private float descontopedido;
        public float DescontoPedido
        {
            get { return this.descontopedido; }
            set { this.descontopedido = value; }
        }

        private DateTime dataenviopedido;
        public DateTime DataEnvioPedido
        {
            get { return this.dataenviopedido; }
            set { this.dataenviopedido = value; }
        }

        private String descricaopedido;
        public String DescricaoPedido
        {
            get { return this.descricaopedido; }
            set { this.descricaopedido = value; }
        }
    }
}
