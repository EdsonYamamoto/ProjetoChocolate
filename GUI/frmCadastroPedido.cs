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
    public partial class frmCadastroPedido : Form
    {
        public String operacao;
        public frmCadastroPedido()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtDesconto.Clear();
            txtDescricao.Clear();
            txtQuantidade.Clear();

            cbCliente.ResetText();
            cbManufaturado.ResetText();
            cbTipoManufaturado.ResetText();
            cbOrcamento.ResetText();
            cbCaracteristicaManufaturado1.ResetText();
            cbCaracteristicaManufaturado2.ResetText();

            dgvDados.DataSource = null;
            dgvDados.Refresh();
            

            dtEnvio.ResetText();
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.alteraBotoes(2);
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaPedido f = new frmConsultaPedido();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLPedido bll = new BLLPedido(cx);
                ModeloPedido modelo = bll.CarregaModeloPedido(f.codigo);
                txtCodigo.Text = modelo.IDPedido.ToString();
                txtDesconto.Text = Convert.ToString(modelo.DescontoPedido);
                txtDescricao.Text = modelo.DescricaoPedido;
                txtQuantidade.Text = Convert.ToString(modelo.QuantidadePedido);

                BLLCliente bllCliente = new BLLCliente(cx);
                ModeloCliente modeloCliente = bllCliente.CarregaModeloCliente(modelo.IDCliente);
                cbCliente.Text = Convert.ToString(modeloCliente.NomeCliente);

                BLLManufaturado bllManufaturado = new BLLManufaturado(cx);
                ModeloManufaturado modeloManufaturado = bllManufaturado.CarregaModeloManufaturado(modelo.IDManufaturado);
                cbManufaturado.Text = Convert.ToString(modeloManufaturado.NomeManufaturado);

                BLLOrcamento bllOrcamento = new BLLOrcamento(cx);
                ModeloOrcamento modeloOrcamento = bllOrcamento.CarregaModeloOrcamento(modelo.IDOrcamento);
                cbOrcamento.Text = Convert.ToString(modeloOrcamento.NomeOrcamento);

                BLLTipoManufaturado bllTipo = new BLLTipoManufaturado(cx);
                ModeloTipoManufaturado modeloTipo = bllTipo.CarregaModeloTipoManufaturado(modelo.IDTipoManufaturado);
                cbTipoManufaturado.Text = Convert.ToString(modeloTipo.NomeTipoManufaturado);

                BLLCaracteristicaManufaturado1 bllCaracteristicaManufaturado1 = new BLLCaracteristicaManufaturado1(cx);
                ModeloCaracteristicaManufaturado1 modeloCaracteristicaManufaturado1 = bllCaracteristicaManufaturado1.CarregaModeloCaracteristicaManufaturado1(modelo.IDCaracteristicaManufaturado1);
                cbCaracteristicaManufaturado1.Text = Convert.ToString(modeloCaracteristicaManufaturado1.NomeCaracteristicaManufaturado1);

                BLLCaracteristicaManufaturado2 bllCaracteristicaManufaturado2 = new BLLCaracteristicaManufaturado2(cx);
                ModeloCaracteristicaManufaturado2 modeloCaracteristicaManufaturado2 = bllCaracteristicaManufaturado2.CarregaModeloCaracteristicaManufaturado2(modelo.IDCaracteristicaManufaturado2);
                cbCaracteristicaManufaturado2.Text = Convert.ToString(modeloCaracteristicaManufaturado2.NomeCaracteristicaManufaturado2);

                dtEnvio.Value = modelo.DataEnvioPedido;

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
                    BLLPedido bll = new BLLPedido(cx);
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
                ModeloPedido modelo = new ModeloPedido();

                modelo.IDCliente = Convert.ToInt32(cbCliente.SelectedValue);
                modelo.IDManufaturado = Convert.ToInt32(cbManufaturado.SelectedValue);
                modelo.IDOrcamento = Convert.ToInt32(cbOrcamento.SelectedValue);
                modelo.IDTipoManufaturado = Convert.ToInt32(cbTipoManufaturado.SelectedValue);
                modelo.QuantidadePedido = Convert.ToInt32(txtQuantidade.Text);
                modelo.DescontoPedido = Convert.ToInt32(txtDesconto.Text);
                modelo.DescricaoPedido = txtDescricao.Text;
                modelo.DataEnvioPedido = dtEnvio.Value.Date;
                modelo.IDCaracteristicaManufaturado1 = Convert.ToInt32(cbCaracteristicaManufaturado1.SelectedValue);
                modelo.IDCaracteristicaManufaturado2 = Convert.ToInt32(cbCaracteristicaManufaturado2.SelectedValue);

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLPedido bll = new BLLPedido(cx);

                if (this.operacao == "inserir")
                {
                    //cadastra cidade
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Codigo " + modelo.IDPedido.ToString());
                }

                else
                {
                    //altera cidade
                    modelo.IDPedido = Convert.ToInt32(txtCodigo.Text);
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

        private void frmCadastroPedido_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);

            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCliente bllCliente = new BLLCliente(cx);
            cbCliente.DataSource = bllCliente.Localizar("");
            cbCliente.DisplayMember = "Nome";
            cbCliente.ValueMember = "ID_Cliente";
            cbCliente.ResetText();

            BLLTipoManufaturado bllTipoManufaturado = new BLLTipoManufaturado(cx);
            cbTipoManufaturado.DataSource = bllTipoManufaturado.Localizar("");
            cbTipoManufaturado.DisplayMember = "Nome";
            cbTipoManufaturado.ValueMember = "ID_TipoManufaturado";
            cbTipoManufaturado.ResetText();

            BLLCaracteristicaManufaturado1 bllCaracteristica1 = new BLLCaracteristicaManufaturado1(cx);
            cbCaracteristicaManufaturado1.DataSource = bllCaracteristica1.Localizar("");
            cbCaracteristicaManufaturado1.DisplayMember = "Nome";
            cbCaracteristicaManufaturado1.ValueMember = "ID_CaracteristicaManufaturado1";
            cbCaracteristicaManufaturado1.ResetText();

            BLLCaracteristicaManufaturado2 bllCaracteristica2 = new BLLCaracteristicaManufaturado2(cx);
            cbCaracteristicaManufaturado2.DataSource = bllCaracteristica2.Localizar("");
            cbCaracteristicaManufaturado2.DisplayMember = "Nome";
            cbCaracteristicaManufaturado2.ValueMember = "ID_CaracteristicaManufaturado2";
            cbCaracteristicaManufaturado2.ResetText();
            
            BLLOrcamento bllOrcamento = new BLLOrcamento(cx);
            cbOrcamento.DataSource = bllOrcamento.Localizar("");
            cbOrcamento.DisplayMember = "Nome";
            cbOrcamento.ValueMember = "ID_Orcamento";
            cbOrcamento.ResetText();
        }

        private void frmCadastroPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pnDados_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btCliente_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);
                cbCliente.Text = Convert.ToString(modelo.NomeCliente);

            }
        }

        private void cbManufaturado_DropDown(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            try
            {
                ModeloManufaturado modelo = new ModeloManufaturado();
                BLLManufaturado bllManufaturado = new BLLManufaturado(cx);

                modelo.IDTipoManufaturado = Convert.ToInt32(cbTipoManufaturado.SelectedValue);
                modelo.IDCaracteristicaManufaturado1 = Convert.ToInt32(cbCaracteristicaManufaturado1.SelectedValue);
                modelo.IDCaracteristicaManufaturado2 = Convert.ToInt32(cbCaracteristicaManufaturado2.SelectedValue);

                cbManufaturado.DataSource = bllManufaturado.LocalizarModelo(modelo);
                cbManufaturado.DisplayMember = "Nome";
                cbManufaturado.ValueMember = "ID_Manufaturado";
                cbManufaturado.ResetText();
            }
            catch
            {

            }
        }


        private void cbOrcamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            ModeloPedido modelo = new ModeloPedido();
            BLLPedido bll = new BLLPedido(cx);
            //modelo. = Convert.ToInt32(cbOrcamento.SelectedIndex);
            modelo.IDOrcamento = Convert.ToInt32(cbOrcamento.SelectedValue);
            dgvDados.DataSource = bll.LocalizarOrcamento(modelo.IDOrcamento);
        }
        
        private void cbTipoManufaturado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbManufaturado.ResetText();
        }

        private void cbCaracteristicaManufaturado1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbManufaturado.ResetText();
        }

        private void cbCaracteristicaManufaturado2_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbManufaturado.ResetText();
        }

        private void btAdiciona_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloPedido modelo = new ModeloPedido();

                modelo.IDCliente = Convert.ToInt32(cbCliente.SelectedValue);
                modelo.IDManufaturado = Convert.ToInt32(cbManufaturado.SelectedValue);
                modelo.IDOrcamento = Convert.ToInt32(cbOrcamento.SelectedValue);
                modelo.IDTipoManufaturado = Convert.ToInt32(cbTipoManufaturado.SelectedValue);
                modelo.QuantidadePedido = Convert.ToInt32(txtQuantidade.Text);
                modelo.DescontoPedido = Convert.ToInt32(txtDesconto.Text);
                modelo.DescricaoPedido = txtDescricao.Text;
                modelo.DataEnvioPedido = dtEnvio.Value.Date;
                modelo.IDCaracteristicaManufaturado1 = Convert.ToInt32(cbCaracteristicaManufaturado1.SelectedValue);
                modelo.IDCaracteristicaManufaturado2 = Convert.ToInt32(cbCaracteristicaManufaturado2.SelectedValue);

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLPedido bll = new BLLPedido(cx);

                if (this.operacao == "inserir")
                {
                    //cadastra cidade
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Codigo " + modelo.IDPedido.ToString());
                }

                else
                {
                    //altera cidade
                    modelo.IDPedido = Convert.ToInt32(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado");
                }

                modelo.IDOrcamento = Convert.ToInt32(cbOrcamento.SelectedValue);
                dgvDados.DataSource = bll.LocalizarOrcamento(modelo.IDOrcamento);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            cbManufaturado.ResetText();
        }
    }
}

