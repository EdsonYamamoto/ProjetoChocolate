namespace GUI
{
    partial class frmCadastroPedido
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.pnDados = new System.Windows.Forms.Panel();
            this.btLocaliza = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btCliente = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCaracteristicaManufaturado2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbCaracteristicaManufaturado1 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTipoManufaturado = new System.Windows.Forms.ComboBox();
            this.dtEnvio = new System.Windows.Forms.DateTimePicker();
            this.txtDescricao = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbOrcamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cbManufaturado = new System.Windows.Forms.ComboBox();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltexto = new System.Windows.Forms.Label();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.btInserir = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.pnDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.pnBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Manufaturado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cliente";
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(29, 125);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(226, 20);
            this.txtDesconto.TabIndex = 8;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(29, 80);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(226, 20);
            this.txtQuantidade.TabIndex = 7;
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
            // pnDados
            // 
            this.pnDados.Controls.Add(this.btLocaliza);
            this.pnDados.Controls.Add(this.dgvDados);
            this.pnDados.Controls.Add(this.btCliente);
            this.pnDados.Controls.Add(this.label9);
            this.pnDados.Controls.Add(this.cbCaracteristicaManufaturado2);
            this.pnDados.Controls.Add(this.label10);
            this.pnDados.Controls.Add(this.cbCaracteristicaManufaturado1);
            this.pnDados.Controls.Add(this.label8);
            this.pnDados.Controls.Add(this.cbTipoManufaturado);
            this.pnDados.Controls.Add(this.dtEnvio);
            this.pnDados.Controls.Add(this.txtDescricao);
            this.pnDados.Controls.Add(this.label7);
            this.pnDados.Controls.Add(this.label6);
            this.pnDados.Controls.Add(this.cbOrcamento);
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.txtDesconto);
            this.pnDados.Controls.Add(this.txtQuantidade);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.cbManufaturado);
            this.pnDados.Controls.Add(this.cbCliente);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.lbltexto);
            this.pnDados.Location = new System.Drawing.Point(12, 12);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(760, 431);
            this.pnDados.TabIndex = 4;
            // 
            // btLocaliza
            // 
            this.btLocaliza.Location = new System.Drawing.Point(276, 164);
            this.btLocaliza.Name = "btLocaliza";
            this.btLocaliza.Size = new System.Drawing.Size(121, 23);
            this.btLocaliza.TabIndex = 26;
            this.btLocaliza.Text = "Adicionar";
            this.btLocaliza.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btLocaliza.UseVisualStyleBackColor = true;
            this.btLocaliza.Click += new System.EventHandler(this.btAdiciona_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(0, 190);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(757, 238);
            this.dgvDados.TabIndex = 25;
            // 
            // btCliente
            // 
            this.btCliente.Location = new System.Drawing.Point(403, 76);
            this.btCliente.Name = "btCliente";
            this.btCliente.Size = new System.Drawing.Size(22, 23);
            this.btCliente.TabIndex = 24;
            this.btCliente.Text = "+";
            this.btCliente.UseVisualStyleBackColor = true;
            this.btCliente.Click += new System.EventHandler(this.btCliente_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(445, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Caracteristica 2";
            // 
            // cbCaracteristicaManufaturado2
            // 
            this.cbCaracteristicaManufaturado2.FormattingEnabled = true;
            this.cbCaracteristicaManufaturado2.Location = new System.Drawing.Point(448, 124);
            this.cbCaracteristicaManufaturado2.Name = "cbCaracteristicaManufaturado2";
            this.cbCaracteristicaManufaturado2.Size = new System.Drawing.Size(121, 21);
            this.cbCaracteristicaManufaturado2.TabIndex = 22;
            this.cbCaracteristicaManufaturado2.SelectedIndexChanged += new System.EventHandler(this.cbCaracteristicaManufaturado2_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(445, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Caracteristica 1";
            // 
            // cbCaracteristicaManufaturado1
            // 
            this.cbCaracteristicaManufaturado1.FormattingEnabled = true;
            this.cbCaracteristicaManufaturado1.Location = new System.Drawing.Point(448, 80);
            this.cbCaracteristicaManufaturado1.Name = "cbCaracteristicaManufaturado1";
            this.cbCaracteristicaManufaturado1.Size = new System.Drawing.Size(121, 21);
            this.cbCaracteristicaManufaturado1.TabIndex = 20;
            this.cbCaracteristicaManufaturado1.SelectedIndexChanged += new System.EventHandler(this.cbCaracteristicaManufaturado1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Tipo Manufaturado";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cbTipoManufaturado
            // 
            this.cbTipoManufaturado.FormattingEnabled = true;
            this.cbTipoManufaturado.Location = new System.Drawing.Point(448, 39);
            this.cbTipoManufaturado.Name = "cbTipoManufaturado";
            this.cbTipoManufaturado.Size = new System.Drawing.Size(121, 21);
            this.cbTipoManufaturado.TabIndex = 17;
            this.cbTipoManufaturado.SelectedIndexChanged += new System.EventHandler(this.cbTipoManufaturado_SelectedIndexChanged);
            // 
            // dtEnvio
            // 
            this.dtEnvio.Location = new System.Drawing.Point(29, 164);
            this.dtEnvio.Name = "dtEnvio";
            this.dtEnvio.Size = new System.Drawing.Size(226, 20);
            this.dtEnvio.TabIndex = 16;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(575, 39);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(155, 145);
            this.txtDescricao.TabIndex = 15;
            this.txtDescricao.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(572, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Descrição";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(273, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Orçamento";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cbOrcamento
            // 
            this.cbOrcamento.FormattingEnabled = true;
            this.cbOrcamento.Location = new System.Drawing.Point(276, 125);
            this.cbOrcamento.Name = "cbOrcamento";
            this.cbOrcamento.Size = new System.Drawing.Size(121, 21);
            this.cbOrcamento.TabIndex = 12;
            this.cbOrcamento.SelectionChangeCommitted += new System.EventHandler(this.cbOrcamento_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "DataEnvio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Desconto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(29, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(226, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // cbManufaturado
            // 
            this.cbManufaturado.FormattingEnabled = true;
            this.cbManufaturado.Location = new System.Drawing.Point(448, 163);
            this.cbManufaturado.Name = "cbManufaturado";
            this.cbManufaturado.Size = new System.Drawing.Size(121, 21);
            this.cbManufaturado.TabIndex = 3;
            this.cbManufaturado.DropDown += new System.EventHandler(this.cbManufaturado_DropDown);
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(276, 78);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 21);
            this.cbCliente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.pnBotoes.TabIndex = 5;
            // 
            // frmCadastroPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnDados);
            this.Controls.Add(this.pnBotoes);
            this.KeyPreview = true;
            this.Name = "frmCadastroPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Pedido";
            this.Load += new System.EventHandler(this.frmCadastroPedido_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCadastroPedido_KeyDown);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.pnBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtQuantidade;
        protected System.Windows.Forms.Button btSalvar;
        protected System.Windows.Forms.Panel pnDados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cbManufaturado;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltexto;
        protected System.Windows.Forms.Button btAlterar;
        protected System.Windows.Forms.Button btLocalizar;
        protected System.Windows.Forms.Button btInserir;
        protected System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Panel pnBotoes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbOrcamento;
        private System.Windows.Forms.RichTextBox txtDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtEnvio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbTipoManufaturado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCaracteristicaManufaturado2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbCaracteristicaManufaturado1;
        private System.Windows.Forms.Button btCliente;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btLocaliza;
    }
}