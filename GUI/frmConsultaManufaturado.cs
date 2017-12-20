using BBL;
using DAL;
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
    public partial class frmConsultaManufaturado : Form
    {
        public int codigo = 0;
        public frmConsultaManufaturado()
        {
            InitializeComponent();
        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLManufaturado bll = new BLLManufaturado(cx);
            dgvDados.DataSource = bll.Localizar(txtValor.Text);
        }

        private void dgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.codigo = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }

        private void frmConsultaManufaturado_Load(object sender, EventArgs e)
        {
            btLocalizar_Click(sender, e);
            dgvDados.Columns[0].HeaderText = "ID_Manufatura";
            dgvDados.Columns[0].Width = 60;
            dgvDados.Columns[1].HeaderText = "TipoManufatura";
            dgvDados.Columns[1].Width = 100;
            dgvDados.Columns[2].HeaderText = "Caracteristica1";
            dgvDados.Columns[2].Width = 100;
            dgvDados.Columns[3].HeaderText = "Caracteristica2";
            dgvDados.Columns[3].Width = 100;
            dgvDados.Columns[4].HeaderText = "Nome";
            dgvDados.Columns[4].Width = 80;
            dgvDados.Columns[5].HeaderText = "Quantidade";
            dgvDados.Columns[5].Width = 80;
            dgvDados.Columns[6].HeaderText = "Medida";
            dgvDados.Columns[6].Width = 90;
            dgvDados.Columns[7].HeaderText = "Preço";
            dgvDados.Columns[7].Width = 90;
            dgvDados.Columns[8].HeaderText = "Descrição";
            dgvDados.Columns[8].Width = 90;
        }
    }
}
