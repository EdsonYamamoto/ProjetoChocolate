using BBL;
using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCadastroSaidaPedido : Form
    {
        public frmCadastroSaidaPedido()
        {
            InitializeComponent();
        }

        public String operacao;

        public void LimpaTela()
        {
            txtCaracMan1.ResetText();
            txtCaracMan2.ResetText();
            txtCliente.ResetText();
            txtCodigo.ResetText();
            txtDescricao.ResetText();
            txtMan.ResetText();
            txtPago.ResetText();
            txtQuantidadeEntregue.ResetText();
            txtTipoMan.ResetText();
            cbPedido.ResetText();
            txtQuantidadePedido.ResetText();
            txtDesconto.ResetText();
            txtOrcamento.ResetText();
        }

        public void alteraBotoes(int op)
        {
            pnDados.Enabled = false;
            btInserir.Enabled = false;
            btAlterar.Enabled = false;
            btLocalizar.Enabled = false;
            btCancelar.Enabled = false;
            btExcluir.Enabled = false;
            btSalvar.Enabled = false;

            if (op == 1)
            {
                btInserir.Enabled = true;
                btLocalizar.Enabled = true;
            }
            if (op == 2)
            {
                pnDados.Enabled = true;
                btSalvar.Enabled = true;
                btCancelar.Enabled = true;
            }
            if (op == 3)
            {
                btAlterar.Enabled = true;
                btExcluir.Enabled = true;
                btCancelar.Enabled = true;
            }
        }


        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaSaidaPedido f = new frmConsultaSaidaPedido();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSaidaPedido bll = new BLLSaidaPedido(cx);
                ModeloSaidaPedido modelo = bll.CarregaModeloSaidaPedido(f.codigo);
                txtCodigo.Text = modelo.IDSaidaPedido.ToString();
                txtQuantidadeEntregue.Text = modelo.QuantidadeEntregue.ToString();
                txtPago.Text = modelo.Pago.ToString();
                txtDescricao.Text = modelo.Descricao.ToString();
                cbPedido.Text = modelo.IDPedido.ToString();
                
                BLLPedido bllPedido = new BLLPedido(cx);
                ModeloPedido modeloPedido = bllPedido.CarregaModeloPedido(Convert.ToInt32(cbPedido.SelectedValue));
                txtDesconto.Text = modeloPedido.DescontoPedido.ToString();
                txtQuantidadePedido.Text = modeloPedido.QuantidadePedido.ToString();
                cbPedido.Text = Convert.ToString(modeloPedido.IDPedido);

                BLLManufaturado bllMan = new BLLManufaturado(cx);
                ModeloManufaturado modeloMan = bllMan.CarregaModeloManufaturado(Convert.ToInt32(modeloPedido.IDManufaturado));
                txtMan.Text = modeloMan.NomeManufaturado.ToString();

                BLLTipoManufaturado bllTipoMan = new BLLTipoManufaturado(cx);
                ModeloTipoManufaturado modeloTipoMan = bllTipoMan.CarregaModeloTipoManufaturado(Convert.ToInt32(modeloMan.IDTipoManufaturado.ToString()));
                txtTipoMan.Text = modeloTipoMan.NomeTipoManufaturado.ToString();

                BLLCaracteristicaManufaturado1 bllCaract1 = new BLLCaracteristicaManufaturado1(cx);
                ModeloCaracteristicaManufaturado1 modeloCaract1 = bllCaract1.CarregaModeloCaracteristicaManufaturado1(Convert.ToInt32(modeloMan.IDCaracteristicaManufaturado1.ToString()));
                txtCaracMan1.Text = modeloCaract1.NomeCaracteristicaManufaturado1.ToString();

                BLLCaracteristicaManufaturado2 bllCaract2 = new BLLCaracteristicaManufaturado2(cx);
                ModeloCaracteristicaManufaturado2 modeloCaract2 = bllCaract2.CarregaModeloCaracteristicaManufaturado2(Convert.ToInt32(modeloMan.IDCaracteristicaManufaturado2.ToString()));
                txtCaracMan2.Text = modeloCaract2.NomeCaracteristicaManufaturado2.ToString();

                BLLCliente bllCliente = new BLLCliente(cx);
                ModeloCliente modeloCliente = bllCliente.CarregaModeloCliente(modeloPedido.IDCliente);
                txtCliente.Text = modeloCliente.NomeCliente.ToString();

                BLLOrcamento bllorca = new BLLOrcamento(cx);
                ModeloOrcamento modeloOrca = bllorca.CarregaModeloOrcamento(modeloPedido.IDOrcamento);
                txtOrcamento.Text = modeloOrca.NomeOrcamento.ToString();

                alteraBotoes(3);
                
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.alteraBotoes(2);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLSaidaPedido bll = new BLLSaidaPedido(cx);
                    bll.Excluir(Convert.ToInt32(txtCodigo.Text));
                    this.LimpaTela();
                    this.alteraBotoes(1);
                }
            }
            catch
            {
                MessageBox.Show("Impossivel excluir o registro.\n\nO Registro esta sendo usado em outro local.");
                alteraBotoes(3);
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloSaidaPedido modelo = new ModeloSaidaPedido();

                modelo.IDPedido = Convert.ToInt32(cbPedido.SelectedValue);
                modelo.Pago = Convert.ToSingle(txtPago.Text);
                modelo.QuantidadeEntregue = Convert.ToInt32(txtQuantidadeEntregue.Text);
                modelo.Descricao = Convert.ToString(txtDescricao.Text);

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLSaidaPedido bll = new BLLSaidaPedido(cx);

                if (this.operacao == "inserir")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Codigo " + modelo.IDSaidaPedido.ToString());
                }

                else
                {
                    modelo.IDSaidaPedido = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }
        
        private void frmCadastroSaidaPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void frmCadastroSaidaPedido_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPedido bll = new BLLPedido(cx);
            cbPedido.DataSource = bll.Localizar("");
            cbPedido.DisplayMember = "ID_Pedido";
            cbPedido.ValueMember = "ID_Pedido";
            cbPedido.ResetText();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pnDados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCaracMan2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbPedido_TextUpdate(object sender, EventArgs e)
        {
           
        }

        private void cbPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbPedido_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cbPedido_Leave(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPedido bll = new BLLPedido(cx);
            ModeloPedido modelo = bll.CarregaModeloPedido(Convert.ToInt32(cbPedido.SelectedValue));
            txtDesconto.Text = modelo.DescontoPedido.ToString();
            txtQuantidadePedido.Text = modelo.QuantidadePedido.ToString();

            BLLManufaturado bllMan = new BLLManufaturado(cx);
            ModeloManufaturado modeloMan = bllMan.CarregaModeloManufaturado(Convert.ToInt32(modelo.IDManufaturado));
            txtMan.Text = modeloMan.NomeManufaturado.ToString();

            BLLTipoManufaturado bllTipoMan = new BLLTipoManufaturado(cx);
            ModeloTipoManufaturado modeloTipoMan = bllTipoMan.CarregaModeloTipoManufaturado(Convert.ToInt32(modeloMan.IDTipoManufaturado.ToString()));
            txtTipoMan.Text = modeloTipoMan.NomeTipoManufaturado.ToString();

            BLLCaracteristicaManufaturado1 bllCaract1 = new BLLCaracteristicaManufaturado1(cx);
            ModeloCaracteristicaManufaturado1 modeloCaract1 = bllCaract1.CarregaModeloCaracteristicaManufaturado1(Convert.ToInt32(modeloMan.IDCaracteristicaManufaturado1.ToString()));
            txtCaracMan1.Text = modeloCaract1.NomeCaracteristicaManufaturado1.ToString();

            BLLCaracteristicaManufaturado2 bllCaract2 = new BLLCaracteristicaManufaturado2(cx);
            ModeloCaracteristicaManufaturado2 modeloCaract2 = bllCaract2.CarregaModeloCaracteristicaManufaturado2(Convert.ToInt32(modeloMan.IDCaracteristicaManufaturado2.ToString()));
            txtCaracMan2.Text = modeloCaract2.NomeCaracteristicaManufaturado2.ToString();

            BLLCliente bllCliente = new BLLCliente(cx);
            ModeloCliente modeloCliente = bllCliente.CarregaModeloCliente(modelo.IDCliente);
            txtCliente.Text = modeloCliente.NomeCliente.ToString();

            BLLOrcamento bllorca = new BLLOrcamento(cx);
            ModeloOrcamento modeloOrca = bllorca.CarregaModeloOrcamento(modelo.IDOrcamento);
            txtOrcamento.Text = modeloOrca.NomeOrcamento.ToString();
            
        }

        private void cbPedido_TextChanged(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLPedido bll = new BLLPedido(cx);
            Console.WriteLine(cbPedido.SelectedValue);
            /*
            ModeloPedido modelo = bll.CarregaModeloPedido(Convert.ToInt32(cbPedido.SelectedText));
            txtTipoMan.Text = modelo.IDTipoManufaturado.ToString();
            txtCaracMan1.Text = modelo.IDCaracteristicaManufaturado1.ToString();
            txtCaracMan2.Text = modelo.IDCaracteristicaManufaturado2.ToString();
            txtMan.Text = modelo.IDManufaturado.ToString();
            txtCliente.Text = modelo.IDCliente.ToString();
            */
        }
    }
}
