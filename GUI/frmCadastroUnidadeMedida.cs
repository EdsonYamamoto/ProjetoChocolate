using Modelo;
using BBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace GUI
{
    public partial class frmCadastroUnidadeMedida : Form
    {
        public frmCadastroUnidadeMedida()
        {
            InitializeComponent();
        }
        public String operacao;

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtNome.Clear();
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

        private void btInserir_Click(object sender, EventArgs e)
        {

            this.alteraBotoes(2);
            this.operacao = "inserir";
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            frmConsultaUnidadeMedida f = new frmConsultaUnidadeMedida();
            f.ShowDialog();
            if (f.codigo != 0)
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeMedida bll = new BLLUnidadeMedida(cx);
                ModeloUnidadeMedida modelo = bll.CarregaModeloUnidadeMedida(f.codigo);
                txtCodigo.Text = modelo.IDUnidadeMedida.ToString();
                txtNome.Text = modelo.NomeUnidadeMedida;

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
                    BLLUnidadeMedida bll = new BLLUnidadeMedida(cx);
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
                ModeloUnidadeMedida modelo = new ModeloUnidadeMedida();

                //leitura dos dados
                modelo.NomeUnidadeMedida = txtNome.Text;

                //obj para gravar dados no banco
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeMedida bll = new BLLUnidadeMedida(cx);

                if (this.operacao == "inserir")
                {
                    //cadastra cidade
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Codigo " + modelo.IDUnidadeMedida.ToString());
                }

                else
                {
                    //altera cidade
                    modelo.IDUnidadeMedida = Convert.ToInt32(txtCodigo.Text);
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

        private void frmCadastroUnidadeMedida_Load(object sender, EventArgs e)
        {
            this.alteraBotoes(1);
        }

        private void frmCadastroUnidadeMedida_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            if(this.operacao == "inserir")
            {
                int r = 0;
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUnidadeMedida bll = new BLLUnidadeMedida(cx);
                r = bll.VerificaExistente(txtNome.Text);

                if(r>0)
                {
                    DialogResult d = MessageBox.Show("Já existe um registro . Deseja alterar o registro?","Aviso", MessageBoxButtons.YesNo);
                    if(d.ToString() == "Yes")
                    {
                        this.operacao = "alterar";
                        ModeloUnidadeMedida modelo = bll.CarregaModeloUnidadeMedida(r);
                        txtCodigo.Text = modelo.IDUnidadeMedida.ToString();
                        txtNome.Text = modelo.NomeUnidadeMedida;
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
