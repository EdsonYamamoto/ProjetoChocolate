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
    public partial class frmCadastroManufaturado : Form
    {
        public frmCadastroManufaturado()
        {
            InitializeComponent();
        }
        public String operacao;
        
        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();
            txtDescricao.ResetText();
            cbTipoManufatura.ResetText();
            cbUnidadeMedida.ResetText();
            cbCaracteristicaManufaturado1.ResetText();
            cbCaracteristicaManufaturado2.ResetText();
            
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(2);
            this.operacao = "inserir";
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaManufaturado f = new frmConsultaManufaturado();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLManufaturado bll = new BLLManufaturado(cx);
                ModeloManufaturado modelo = bll.CarregaModeloManufaturado(f.codigo);
                txtCodigo.Text = modelo.IDManufaturado.ToString();
                txtNome.Text = modelo.NomeManufaturado;
                txtQuantidade.Text = Convert.ToString(modelo.QuantidadeManufaturado);
                txtPreco.Text = Convert.ToString(modelo.PrecoManufaturado);
                txtDescricao.Text = modelo.DescricaoManufaturado;
                
                BLLTipoManufaturado bllTipoManufaturado = new BLLTipoManufaturado(cx);
                ModeloTipoManufaturado modeloTipoManufaturado = bllTipoManufaturado.CarregaModeloTipoManufaturado(modelo.IDTipoManufaturado);
                cbTipoManufatura.Text = Convert.ToString(modeloTipoManufaturado.NomeTipoManufaturado);

                BLLUnidadeMedida bllUnidadeMedida = new BLLUnidadeMedida(cx);
                ModeloUnidadeMedida modeloUnidadeMedida = bllUnidadeMedida.CarregaModeloUnidadeMedida(modelo.IDUnidadeMedida);
                cbUnidadeMedida.Text = Convert.ToString(modeloUnidadeMedida.NomeUnidadeMedida);

                BLLCaracteristicaManufaturado1 bllCaracteristicaManufaturado1 = new BLLCaracteristicaManufaturado1(cx);
                ModeloCaracteristicaManufaturado1 modeloCaracteristicaManufaturado1 = bllCaracteristicaManufaturado1.CarregaModeloCaracteristicaManufaturado1(modelo.IDCaracteristicaManufaturado1);
                cbCaracteristicaManufaturado1.Text = Convert.ToString(modeloCaracteristicaManufaturado1.NomeCaracteristicaManufaturado1);

                BLLCaracteristicaManufaturado2 bllCaracteristicaManufaturado2 = new BLLCaracteristicaManufaturado2(cx);
                ModeloCaracteristicaManufaturado2 modeloCaracteristicaManufaturado2 = bllCaracteristicaManufaturado2.CarregaModeloCaracteristicaManufaturado2(modelo.IDCaracteristicaManufaturado2);
                cbCaracteristicaManufaturado2.Text = Convert.ToString(modeloCaracteristicaManufaturado2.NomeCaracteristicaManufaturado2);

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
            alteraBotoes(2);
            this.operacao = "alterar";
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
                if (d.ToString() == "Yes")
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLManufaturado bll = new BLLManufaturado(cx);
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
                ModeloManufaturado modelo = new ModeloManufaturado();

                //leitura dos dados
                modelo.NomeManufaturado = txtNome.Text;
                modelo.IDTipoManufaturado = Convert.ToInt32(cbTipoManufatura.SelectedValue);
                modelo.IDUnidadeMedida = Convert.ToInt32(cbUnidadeMedida.SelectedValue);
                modelo.QuantidadeManufaturado = Convert.ToSingle(txtQuantidade.Text);
                modelo.PrecoManufaturado = Convert.ToSingle(txtPreco.Text);
                modelo.DescricaoManufaturado = txtDescricao.Text;
                modelo.IDCaracteristicaManufaturado1 = Convert.ToInt32(cbCaracteristicaManufaturado1.SelectedValue);
                modelo.IDCaracteristicaManufaturado2 = Convert.ToInt32(cbCaracteristicaManufaturado2.SelectedValue);
                

                //obj para gravar dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLManufaturado bll = new BLLManufaturado(cx);

                if (this.operacao == "inserir")
                {
                    //cadastra cidade
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Codigo " + modelo.IDManufaturado.ToString());
                }

                else
                {
                    //altera cidade
                    modelo.IDManufaturado = Convert.ToInt32(txtCodigo.Text);
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

        private void frmCadastroManufaturado_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLTipoManufaturado bll = new BLLTipoManufaturado(cx);
            cbTipoManufatura.DataSource = bll.Localizar("");
            cbTipoManufatura.DisplayMember = "Nome";
            cbTipoManufatura.ValueMember = "ID_TipoManufaturado";
            cbTipoManufatura.ResetText();

            BLLUnidadeMedida bllmedida = new BLLUnidadeMedida(cx);
            cbUnidadeMedida.DataSource = bllmedida.Localizar("");
            cbUnidadeMedida.DisplayMember = "Nome";
            cbUnidadeMedida.ValueMember = "ID_UnidadeMedida";
            cbUnidadeMedida.ResetText();

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

        }

        private void cbTipoManufatura_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmCadastroManufaturado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        
        
    }
}
