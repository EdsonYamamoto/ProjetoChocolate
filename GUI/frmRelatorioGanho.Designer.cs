namespace GUI
{
    partial class frmRelatorioGanho
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
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDados1 = new System.Windows.Forms.DataGridView();
            this.dgvDados2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(15, 200);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(757, 140);
            this.dgvDados.TabIndex = 15;
            this.dgvDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Todas os pedidos agendados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvDados1
            // 
            this.dgvDados1.AllowUserToAddRows = false;
            this.dgvDados1.AllowUserToDeleteRows = false;
            this.dgvDados1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados1.Location = new System.Drawing.Point(15, 31);
            this.dgvDados1.Name = "dgvDados1";
            this.dgvDados1.ReadOnly = true;
            this.dgvDados1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados1.Size = new System.Drawing.Size(757, 137);
            this.dgvDados1.TabIndex = 16;
            this.dgvDados1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados1_CellContentClick);
            // 
            // dgvDados2
            // 
            this.dgvDados2.AllowUserToAddRows = false;
            this.dgvDados2.AllowUserToDeleteRows = false;
            this.dgvDados2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados2.Location = new System.Drawing.Point(15, 377);
            this.dgvDados2.Name = "dgvDados2";
            this.dgvDados2.ReadOnly = true;
            this.dgvDados2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados2.Size = new System.Drawing.Size(757, 172);
            this.dgvDados2.TabIndex = 17;
            this.dgvDados2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDados2_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Quantidade de manufaturado pedidos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pedido registrado por data";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmRelatorioGanho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDados2);
            this.Controls.Add(this.dgvDados1);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.label1);
            this.Name = "frmRelatorioGanho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio de Pedidos Gerais";
            this.Load += new System.EventHandler(this.frmRelatorioGanho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDados1;
        private System.Windows.Forms.DataGridView dgvDados2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}