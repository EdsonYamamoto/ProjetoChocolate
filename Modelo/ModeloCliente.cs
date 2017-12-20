using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModeloCliente
    {
        public ModeloCliente()
        {
            this.IDCliente = 0;
            this.NomeCliente = "";
            this.TelefoneCliente = 0;
            this.CelularCliente = 0;
            this.IDCidade = 0;
            this.IDBairro = 0;
        }
        public ModeloCliente(int idcliente, String nomecliente, long telefone, long celular, int idcidade, int idbairro)
        {
            this.IDCliente = idcliente;
            this.NomeCliente = nomecliente;
            this.TelefoneCliente = telefone;
            this.CelularCliente = celular;
            this.IDCidade = idcidade;
            this.IDBairro = idbairro;
        }

        private int idcliente;
        public int IDCliente
        {
            get { return this.idcliente; }
            set { this.idcliente = value; }
        }

        private String nomecliente;
        public String NomeCliente
        {
            get { return this.nomecliente; }
            set { this.nomecliente = value; }
        }
        private long telefone;
        public long TelefoneCliente
        {
            get { return this.telefone; }
            set { this.telefone = value; }
        }
        private long celular;
        public long CelularCliente
        {
            get { return this.celular; }
            set { this.celular = value; }
        }

        private int idcidade;
        public int IDCidade
        {
            get { return this.idcidade; }
            set { this.idcidade = value; }
        }

        private int idbairro;
        public int IDBairro
        {
            get { return this.idbairro; }
            set { this.idbairro = value; }
        }
    }
}
