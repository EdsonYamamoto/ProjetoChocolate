﻿namespace GUI
{
    partial class frmCadastroCliente
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
            this.pnBotoes = new System.Windows.Forms.Panel();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btLocalizar = new System.Windows.Forms.Button();
            this.btInserir = new System.Windows.Forms.Button();
            this.pnDados = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.cbBairro = new System.Windows.Forms.ComboBox();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbltexto = new System.Windows.Forms.Label();
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
            this.pnBotoes.TabIndex = 3;
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
            // pnDados
            // 
            this.pnDados.Controls.Add(this.label5);
            this.pnDados.Controls.Add(this.label4);
            this.pnDados.Controls.Add(this.txtCelular);
            this.pnDados.Controls.Add(this.txtTelefone);
            this.pnDados.Controls.Add(this.txtNome);
            this.pnDados.Controls.Add(this.label3);
            this.pnDados.Controls.Add(this.label1);
            this.pnDados.Controls.Add(this.txtCodigo);
            this.pnDados.Controls.Add(this.cbBairro);
            this.pnDados.Controls.Add(this.cbCidade);
            this.pnDados.Controls.Add(this.label2);
            this.pnDados.Controls.Add(this.lbltexto);
            this.pnDados.Location = new System.Drawing.Point(12, 12);
            this.pnDados.Name = "pnDados";
            this.pnDados.Size = new System.Drawing.Size(760, 431);
            this.pnDados.TabIndex = 2;
            this.pnDados.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDados_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Bairro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cidade";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(29, 125);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(174, 20);
            this.txtCelular.TabIndex = 9;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(29, 173);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(174, 20);
            this.txtTelefone.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(29, 80);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(174, 20);
            this.txtNome.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefone 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Telefone 2";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(29, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(174, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // cbBairro
            // 
            this.cbBairro.FormattingEnabled = true;
            this.cbBairro.Location = new System.Drawing.Point(290, 80);
            this.cbBairro.Name = "cbBairro";
            this.cbBairro.Size = new System.Drawing.Size(121, 21);
            this.cbBairro.TabIndex = 3;
            // 
            // cbCidade
            // 
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(290, 41);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(121, 21);
            this.cbCidade.TabIndex = 2;
            this.cbCidade.SelectedIndexChanged += new System.EventHandler(this.cbCidade_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
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
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnBotoes);
            this.Controls.Add(this.pnDados);
            this.KeyPreview = true;
            this.Name = "frmCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this.frmCadastroCliente_Load);
            this.pnBotoes.ResumeLayout(false);
            this.pnDados.ResumeLayout(false);
            this.pnDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Panel pnBotoes;
        protected System.Windows.Forms.Button btSalvar;
        protected System.Windows.Forms.Button btExcluir;
        protected System.Windows.Forms.Button btAlterar;
        protected System.Windows.Forms.Button btLocalizar;
        protected System.Windows.Forms.Button btInserir;
        protected System.Windows.Forms.Panel pnDados;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.ComboBox cbBairro;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltexto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}