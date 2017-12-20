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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void fabricantaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFabricante f = new frmCadastroFabricante();
            f.ShowDialog();
            f.Dispose();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroPedido f = new frmCadastroPedido();
            f.ShowDialog();
            f.Dispose();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCidade f = new frmCadastroCidade();
            f.ShowDialog();
            f.Dispose();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cidadeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCidade f = new frmConsultaCidade();
            f.ShowDialog();
            f.Dispose();
        }

        private void bairroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroBairro f = new frmCadastroBairro();
            f.ShowDialog();
            f.Dispose();
        }

        private void bairroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaBairro f = new frmConsultaBairro();
            f.ShowDialog();
            f.Dispose();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCliente f = new frmCadastroCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroTipoManufaturado f = new frmCadastroTipoManufaturado();
            f.ShowDialog();
            f.Dispose();
        }

        private void tipoManufaturadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaTipoManufaturado f = new frmConsultaTipoManufaturado();
            f.ShowDialog();
            f.Dispose();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroManufaturado f = new frmCadastroManufaturado();
            f.ShowDialog();
            f.Dispose();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaManufaturado f = new frmConsultaManufaturado();
            f.ShowDialog();
            f.Dispose();
        }

        private void orçamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroOrcamento f = new frmCadastroOrcamento();
            f.ShowDialog();
            f.Dispose();
        }

        private void orçamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaOrcamento f = new frmConsultaOrcamento();
            f.ShowDialog();
            f.Dispose();
        }

        private void pedidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaPedido f = new frmConsultaPedido();
            f.ShowDialog();
            f.Dispose();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaFabricante f = new frmConsultaFabricante();
            f.ShowDialog();
            f.Dispose();
        }

        private void unidadeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroUnidadeMedida f = new frmCadastroUnidadeMedida();
            f.ShowDialog();
            f.Dispose();
        }

        private void unidadeMedidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaUnidadeMedida f = new frmConsultaUnidadeMedida();
            f.ShowDialog();
            f.Dispose();
        }

        private void custoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCusto f = new frmCadastroCusto();
            f.ShowDialog();
            f.Dispose();
        }

        private void custoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCusto f = new frmConsultaCusto();
            f.ShowDialog();
            f.Dispose();
        }

        private void caracteristicaMaufaturadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCaracteristicaManufaturado1 f = new frmCadastroCaracteristicaManufaturado1();
            f.ShowDialog();
            f.Dispose();
        }

        private void caracteristicaManufaturado2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroCaracteristicaManufaturado2 f = new frmCadastroCaracteristicaManufaturado2();
            f.ShowDialog();
            f.Dispose();
        }

        private void caracteristicaManufaturado1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCaracteristicaManufaturado1 f = new frmConsultaCaracteristicaManufaturado1();
            f.ShowDialog();
            f.Dispose();
        }

        private void caracteristicaManufaturado2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaCaracteristicaManufaturado2 f = new frmConsultaCaracteristicaManufaturado2();
            f.ShowDialog();
            f.Dispose();
        }

        private void ganhosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioGanho f = new frmRelatorioGanho();
            f.ShowDialog();
            f.Dispose();
        }

        private void gastorTotaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioGasto f = new frmRelatorioGasto();
            f.ShowDialog();
            f.Dispose();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre f = new frmSobre();
            f.ShowDialog();
            f.Dispose();
        }

        private void saidaPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroSaidaPedido f = new frmCadastroSaidaPedido();
            f.ShowDialog();
            f.Dispose();
        }

        private void saidaPedidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaSaidaPedido f = new frmConsultaSaidaPedido();
            f.ShowDialog();
            f.Dispose();
        }

        private void ganhosTotaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatorioSaidaPedido f = new frmRelatorioSaidaPedido();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
