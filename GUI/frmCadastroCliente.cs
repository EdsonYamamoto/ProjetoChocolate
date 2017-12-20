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
    public partial class frmCadastroCliente : Form
    {
        public String operacao;

        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            cbCidade.ResetText();
            cbBairro.ResetText();
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

        private void pnDados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCidade bllcidade = new BLLCidade(cx);
            cbCidade.DataSource = bllcidade.Localizar("");
            cbCidade.DisplayMember = "Nome";
            cbCidade.ValueMember = "ID_Cidade";
            cbCidade.ResetText();

            BLLBairro bllbairro = new BLLBairro(cx);
            cbBairro.DataSource = bllbairro.Localizar("");
            cbBairro.DisplayMember = "Nome";
            cbBairro.ValueMember = "ID_Bairro";
            cbBairro.ResetText();
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.alteraBotoes(2);
            this.operacao = "inserir";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.LimpaTela();
            this.alteraBotoes(1);
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloCliente modelo = new ModeloCliente();
                
                //leitura dos dados
                modelo.NomeCliente = txtNome.Text;
                //modelo.TelefoneCliente = Convert.ToInt64(txtTelefone.Text);
                //modelo.CelularCliente = Convert.ToInt64(txtCelular.Text);
                long tel, cel;
                if (long.TryParse(txtTelefone.Text, out tel))
                    modelo.TelefoneCliente = tel;
                else
                    modelo.TelefoneCliente = 0;

                if (long.TryParse(txtCelular.Text, out cel))
                    modelo.CelularCliente = cel;
                else
                    modelo.CelularCliente = 0;

                modelo.IDBairro = Convert.ToInt32(cbBairro.SelectedValue);
                modelo.IDCidade = Convert.ToInt32(cbCidade.SelectedValue);
                
                //obj para gravar dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);

                if (this.operacao == "inserir")
                {
                    //cadastra cidade
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Codigo " + modelo.IDCliente.ToString());
                }

                else
                {
                    //altera cidade
                    modelo.IDCliente = Convert.ToInt32(txtCodigo.Text);
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
                    BLLCliente bll = new BLLCliente(cx);
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

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            if(f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                ModeloCliente modelo = bll.CarregaModeloCliente(f.codigo);
                txtCodigo.Text = modelo.IDCliente.ToString();
                txtNome.Text = modelo.NomeCliente;
                txtTelefone.Text = Convert.ToString(modelo.TelefoneCliente);
                txtCelular.Text = Convert.ToString(modelo.CelularCliente);

                BLLCidade bllCidade = new BLLCidade(cx);
                ModeloCidade modeloCidade = bllCidade.CarregaModeloCidade(modelo.IDCidade);
                cbCidade.Text = Convert.ToString(modeloCidade.NomeCidade);

                BLLBairro bllBairro = new BLLBairro(cx);
                ModeloBairro modeloBairro = bllBairro.CarregaModeloBairro(modelo.IDBairro);
                cbBairro.Text = Convert.ToString(modeloBairro.NomeBairro);

                alteraBotoes(3);
            }
            else
            {
                this.LimpaTela();
                this.alteraBotoes(1);
            }
            f.Dispose();
        }

        private void cbCidade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
