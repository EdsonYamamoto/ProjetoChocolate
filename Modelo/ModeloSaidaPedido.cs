using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloSaidaPedido
    {
        public ModeloSaidaPedido()
        {
            this.IDSaidaPedido = 0;
            this.IDPedido = 0;
            this.QuantidadeEntregue = 0;
            this.Pago = 0;
            this.Descricao= "";
            this.IDCliente = 0;
            this.IDManufaturado = 0;
            this.IDTipoManufaturado = 0;
            this.IDCaracteristicaManufaturado1 = 0;
            this.IDCaracteristicaManufaturado2 = 0;
        }
        public ModeloSaidaPedido(int idsaidapedido, int idcliente, int idmanufaturado, int idtipomanufaturado, int idcaracteristicamanufaturado1, int idcaracteristicamanufaturado2, int idpedido, int quantidadeentregue, float pago, String descricao)
        {
            this.IDSaidaPedido = idsaidapedido;
            this.IDPedido = idpedido;
            this.QuantidadeEntregue =quantidadeentregue;
            this.Pago = pago;
            this.Descricao = descricao;
            this.IDCliente = idcliente;
            this.IDManufaturado = idmanufaturado;
            this.IDTipoManufaturado = idtipomanufaturado;
            this.IDCaracteristicaManufaturado1 = idcaracteristicamanufaturado1;
            this.IDCaracteristicaManufaturado2 = idcaracteristicamanufaturado2;
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

        private int idsaidapedido;
        public int IDSaidaPedido
        {
            get { return this.idsaidapedido; }
            set { this.idsaidapedido = value; }
        }

        private int quantidadeentregue;
        public int QuantidadeEntregue
        {
            get { return this.quantidadeentregue; }
            set { this.quantidadeentregue = value; }
        }
        
        private float pago;
        public float Pago
        {
            get { return this.pago; }
            set { this.pago = value; }
        }
        private String descricao;
        public String Descricao
        {
            get { return this.descricao; }
            set { this.descricao = value; }
        }
    }
}
