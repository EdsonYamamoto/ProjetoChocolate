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
    public partial class frmCadastroCaracteristicaManufaturado1 : Form
    {
        public frmCadastroCaracteristicaManufaturado1()
        {
            InitializeComponent();
        }

        public String operacao;
        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtDescricao.Clear();
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
            frmConsultaCaracteristicaManufaturado1 f = new frmConsultaCaracteristicaManufaturado1();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCaracteristicaManufaturado1 bll = new BLLCaracteristicaManufaturado1(cx);
                ModeloCaracteristicaManufaturado1 modelo = bll.CarregaModeloCaracteristicaManufaturado1(f.codigo);
                txtCodigo.Text = modelo.IDCaracteristicaManufaturado1.ToString();
                txtNome.Text = modelo.NomeCaracteristicaManufaturado1;
                txtDescricao.Text = modelo.DescricaoCaracteristicaManufaturado1;
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
                    BLLCaracteristicaManufaturado1 bll = new BLLCaracteristicaManufaturado1(cx);
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
                ModeloCaracteristicaManufaturado1 modelo = new ModeloCaracteristicaManufaturado1();

                modelo.NomeCaracteristicaManufaturado1 = txtNome.Text;
                modelo.DescricaoCaracteristicaManufaturado1 = txtDescricao.Text;

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCaracteristicaManufaturado1 bll = new BLLCaracteristicaManufaturado1(cx);

                if (this.operacao == "inserir")
                {
                    //cadastra cidade
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Codigo " + modelo.IDCaracteristicaManufaturado1.ToString());
                }

                else
                {
                    //altera cidade
                    modelo.IDCaracteristicaManufaturado1 = Convert.ToInt32(txtCodigo.Text);
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

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void frmCadastroCaracteristicaManufaturado1_Load(object sender, EventArgs e)
        {

            this.alteraBotoes(1);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if (this.operacao == "inserir")
            {
                int r = 0;

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCaracteristicaManufaturado1 bll = new BLLCaracteristicaManufaturado1(cx);
                r = bll.VerificaExistente(txtNome.Text);
                if (r > 0)
                {
                    DialogResult d = MessageBox.Show("Já existe um registro . Deseja alterar o registro?", "Aviso", MessageBoxButtons.YesNo);
                    if (d.ToString() == "Yes")
                    {
                        this.operacao = "alterar";
                        ModeloCaracteristicaManufaturado1 modelo = bll.CarregaModeloCaracteristicaManufaturado1(r);
                        txtCodigo.Text = modelo.IDCaracteristicaManufaturado1.ToString();
                        txtNome.Text = modelo.NomeCaracteristicaManufaturado1;
                    }
                    else
                    {
                        LimpaTela();
                        alteraBotoes(1);
                    }
                }
            }

        }
    }
}
