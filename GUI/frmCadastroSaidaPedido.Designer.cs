namespace GUI
{
    partial class frmCadastroSaidaPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.btInserir = new System.Windows.Forms.Button();
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.lbltexto = new System.Windows.Forms.Label();
            this.cbPedido = new System.Windows.Forms.ComboBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQuantidadeEntregue = new System.Windows.Forms.TextBox();
            this.pnDados = new System.Windows.Forms.Panel();
            this.txtMan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCaracMan2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCaracMan1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTipoMan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOrcamento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantidadePedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnBotoes.SuspendLayout();
            this.pnDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btCancelar.Image = global::GUI.Properties.Resources.Cancelar;
            this.btCancelar.Location = new System.Drawing.Point(660, 0);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(100, 100);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btAlterar.Image = global::GUI.Properties.Resources.Alterar;
            this.btAlterar.Location = new System.Drawing.Point(342, 0);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(100, 100);
            this.btAlterar.TabIndex = 2;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAlterar.UseVisualStyleBackColor = true;
            this.btAlterar.Click += new System.EventHandler(this.btAlterar_Click);
            // 
            // btLocalizar
            // 
            this.btLocalizar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btLocalizar.Image = global::GUI.Properties.Resources.localizar_fw;
            this.btLocalizar.Location = new System.Drawing.Point(236, 0);
            this.btLocalizar.Name = "btLocalizar";
            this.btLocalizar.Size = new System.Drawing.Size(100, 100);
            this.btLocalizar.TabIndex = 1;
            this.btLocalizar.Text = "Localizar";
            this.btLocalizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btLocalizar.UseVisualStyleBackColor = true;
            this.btLocalizar.Click += new System.EventHandler(this.btLocalizar_Click);
            // 
            // btInserir
            // 
            this.btInserir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btInserir.Image = global::GUI.Properties.Resources.Novo;
            this.btInserir.Location = new System.Drawing.Point(130, 0);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(100, 100);
            this.btInserir.TabIndex = 0;
            this.btInserir.Text = "Inserir";
            this.btInserir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btInserir.UseVisualStyleBackColor = true;
            this.btInserir.Click += new System.EventHandler(this.btInserir_Click);
            // 
            // pnBotoes
            // 
            this.pnBotoes.Controls.Add(this.btCancelar);
            this.pnBotoes.Controls.Add(this.btSalvar);
            this.pnBotoes.Controls.Add(this.btExcluir);
            this.pnBotoes.Controls.Add(this.btAlterar);
            this.pnBotoes.Controls.Add(this.btLocalizar);
            this.pnBotoes.Controls.Add(this.btInserir);
            this.pnBotoes.Location = new System.Drawing.Point(12, 449);
            this.pnBotoes.Name = "pnBotoes";
            this.pnBotoes.Size = new System.Drawing.Size(760, 100);
            this.pnBotoes.TabIndex = 9;
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btSalvar.Image = global::GUI.Properties.Resources.Salvar1_fw;
            this.btSalvar.Location = new System.Drawing.Point(554, 0);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(100, 100);
            this.btSalvar.TabIndex = 4;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btExcluir.Image = global::GUI.Properties.Resources.Excluir;
            this.btExcluir.Location = new System.Drawing.Point(448, 0);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(100, 100);
            this.btExcluir.TabIndex = 3;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // lbltexto
            // 
            this.lbltexto.AutoSize = true;
            this.lbltexto.Location = new System.Drawing.Point(26, 25);
            this.lbltexto.Name = "lbltexto";
            this.lbltexto.Size = new System.Drawing.Size(40, 13);
            this.lbltexto.TabIndex = 0;
            this.lbltexto.Text = "Código";
            // 
            // cbPedido
            // 
            this.cbPedido.FormattingEnabled = true;
            this.cbPedido.Location = new System.Drawing.Point(27, 85);
            this.cbPedido.Name = "cbPedido";
            this.cbPedido.Size = new System.Drawing.Size(174, 21);
            this.cbPedido.TabIndex = 2;
            this.cbPedido.SelectedIndexChanged += new System.EventHandler(this.cbPedido_SelectedIndexChanged);
            this.cbPedido.TextUpdate += new System.EventHandler(this.cbPedido_TextUpdate);
            this.cbPedido.SelectedValueChanged += new System.EventHandler(this.cbPedido_SelectedValueChanged);
            this.cbPedido.TextChanged += new System.EventHandler(this.cbPedido_TextChanged);
            this.cbPedido.Leave += new System.EventHandler(this.cbPedido_Leave);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(27, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(174, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pago";
            // 
            // txtPago
            // 
            this.txtPago.Location = new System.Drawing.Point(27, 164);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(174, 20);
            this.txtPago.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "IDPedido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Descrição";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(27, 203);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(730, 225);
            this.txtDescricao.TabIndex = 13;
            this.txtDescricao.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Quantidade Entregue";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtQuantidadeEntregue
            // 
            this.txtQuantidadeEntregue.Location = new System.Drawing.Point(27, 125);
            this.txtQuantidadeEntregue.Name = "txtQuantidadeEntregue";
            this.txtQuantidadeEntregue.Size = new System.Drawing.Size(174, 20);
            this.txtQuantidadeEntregue.TabIndex = 17;
            // 
            // pnDados
            // 
            this.pnDados.Controls.Add(this.txtMan);
            this.pnDados.Controls.Add(this.label12);
            this.pnDados.Controls.Add(this.txtCaracMan2);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.txtCaracMan1);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.txtTipoMan);
            this.pnDados.Controls.Add(this.label11);
            this.pnDados.Controls.Add(this.txtOrcamento);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.txtDesconto);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.txtCliente);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.txtQuantidadePedido);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.txtQuantidadeEntregue);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.txtDescricao);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.txtPago);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.cbPedido);
            this.pnDados.Controls.Add(this.lbltexto);
            this.pnDados.Location = new System.Drawing.Point(12, 12);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(760, 431);
            this.pnDados.TabIndex = 10;
            this.pnDados.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDados_Paint);
            // 
            // txtMan
            // 
            this.txtMan.Enabled = false;
            this.txtMan.Location = new System.Drawing.Point(450, 164);
            this.txtMan.Name = "txtMan";
            this.txtMan.Size = new System.Drawing.Size(174, 20);
            this.txtMan.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(445, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 32;
            this.label12.Text = "Manufaturado";
            // 
            // txtCaracMan2
            // 
            this.txtCaracMan2.Enabled = false;
            this.txtCaracMan2.Location = new System.Drawing.Point(450, 125);
            this.txtCaracMan2.Name = "txtCaracMan2";
            this.txtCaracMan2.Size = new System.Drawing.Size(174, 20);
            this.txtCaracMan2.TabIndex = 31;
            this.txtCaracMan2.TextChanged += new System.EventHandler(this.txtCaracMan2_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(447, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Caracteristica Manufaturado 2";
            // 
            // txtCaracMan1
            // 
            this.txtCaracMan1.Enabled = false;
            this.txtCaracMan1.Location = new System.Drawing.Point(450, 86);
            this.txtCaracMan1.Name = "txtCaracMan1";
            this.txtCaracMan1.Size = new System.Drawing.Size(174, 20);
            this.txtCaracMan1.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(447, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Caracteristica manufaturado 1";
            // 
            // txtTipoMan
            // 
            this.txtTipoMan.Enabled = false;
            this.txtTipoMan.Location = new System.Drawing.Point(450, 41);
            this.txtTipoMan.Name = "txtTipoMan";
            this.txtTipoMan.Size = new System.Drawing.Size(174, 20);
            this.txtTipoMan.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(445, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "TipoManufaturado";
            // 
            // txtOrcamento
            // 
            this.txtOrcamento.Enabled = false;
            this.txtOrcamento.Location = new System.Drawing.Point(270, 164);
            this.txtOrcamento.Name = "txtOrcamento";
            this.txtOrcamento.Size = new System.Drawing.Size(178, 20);
            this.txtOrcamento.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Orcamento";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Enabled = false;
            this.txtDesconto.Location = new System.Drawing.Point(270, 125);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(178, 20);
            this.txtDesconto.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Desconto";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(270, 41);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(178, 20);
            this.txtCliente.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome Cliente";
            // 
            // txtQuantidadePedido
            // 
            this.txtQuantidadePedido.Enabled = false;
            this.txtQuantidadePedido.Location = new System.Drawing.Point(270, 85);
            this.txtQuantidadePedido.Name = "txtQuantidadePedido";
            this.txtQuantidadePedido.Size = new System.Drawing.Size(178, 20);
            this.txtQuantidadePedido.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Quantidade Pedido";
            // 
            // frmCadastroSaidaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnBotoes);
            this.Controls.Add(this.pnDados);
            this.Name = "frmCadastroSaidaPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Saida Pedido";
            this.Load += new System.EventHandler(this.frmCadastroSaidaPedido_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroSaidaPedido_KeyDown);
            this.pnBotoes.ResumeLayout(false);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btCancelar;
        protected System.Windows.Forms.Button btAlterar;
        protected System.Windows.Forms.Button btLocalizar;
        protected System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Panel pnBotoes;
        protected System.Windows.Forms.Button btSalvar;
        protected System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Label lbltexto;
        private System.Windows.Forms.ComboBox cbPedido;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQuantidadeEntregue;
        protected System.Windows.Forms.Panel pnDados;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantidadePedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCaracMan2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCaracMan1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTipoMan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOrcamento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label5;
    }
}