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
    public partial class frmCadastroCusto : Form
    {
        public frmCadastroCusto()
        {
            InitializeComponent();
        }
        public String operacao;

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtUnidade.Clear();
            txtPreco.Clear();
            txtDescricao.ResetText();
            txtQuantidade.ResetText();
            cbFabricante.ResetText();
            cbUnidadeMedida.ResetText();
            
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

        private void frmCadastroCusto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(2);
            this.operacao = "inserir";
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaCusto f = new frmConsultaCusto();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCusto bll = new BLLCusto(cx);
                ModeloCusto modelo = bll.CarregaModeloCusto(f.codigo);
                txtCodigo.Text = modelo.IDCusto.ToString();
                txtNome.Text = modelo.NomeCusto;
                txtUnidade.Text = Convert.ToString(modelo.UnidadeCusto);
                txtPreco.Text = Convert.ToString(modelo.PrecoCusto);
                txtDescricao.Text = modelo.DescricaoCusto;
                txtQuantidade.Text = Convert.ToString(modelo.QuantidadeCusto); ;

                BLLFabricante bllFabricante = new BLLFabricante(cx);
                ModeloFabricante modeloFabricante = bllFabricante.CarregaModeloFabricante(modelo.IDFabricante);
                cbFabricante.Text = Convert.ToString(modeloFabricante.NomeFabricante);

                BLLUnidadeMedida bllUnidadeMedida = new BLLUnidadeMedida(cx);
                ModeloUnidadeMedida modeloUnidadeMedida = bllUnidadeMedida.CarregaModeloUnidadeMedida(modelo.IDUnidadeMedida);
                cbUnidadeMedida.Text = Convert.ToString(modeloUnidadeMedida.NomeUnidadeMedida);

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
                    BLLCusto bll = new BLLCusto(cx);
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
                ModeloCusto modelo = new ModeloCusto();

                //leitura dos dados
                modelo.NomeCusto = txtNome.Text;
                modelo.PrecoCusto = Convert.ToSingle(txtPreco.Text);

                modelo.QuantidadeCusto = Convert.ToSingle(txtQuantidade.Text);

                modelo.UnidadeCusto = Convert.ToSingle(txtUnidade.Text);

                modelo.IDFabricante = Convert.ToInt32(cbFabricante.SelectedValue);
                modelo.IDUnidadeMedida = Convert.ToInt32(cbUnidadeMedida.SelectedValue);
                modelo.DescricaoCusto = txtDescricao.Text;
                
                //obj para gravar dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCusto bll = new BLLCusto(cx);

                if (this.operacao == "inserir")
                {
                    //cadastra cidade
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Codigo " + modelo.IDCusto.ToString());
                }

                else
                {
                    //altera cidade
                    modelo.IDCusto = Convert.ToInt32(txtCodigo.Text);
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

        private void frmCadastroCusto_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLFabricante bll = new BLLFabricante(cx);
            cbFabricante.DataSource = bll.Localizar("");
            cbFabricante.DisplayMember = "Nome";
            cbFabricante.ValueMember = "ID_Fabricante";
            cbFabricante.ResetText();

            BLLUnidadeMedida bllmedida = new BLLUnidadeMedida(cx);
            cbUnidadeMedida.DataSource = bllmedida.Localizar("");
            cbUnidadeMedida.DisplayMember = "Nome";
            cbUnidadeMedida.ValueMember = "ID_UnidadeMedida";
            cbUnidadeMedida.ResetText();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
