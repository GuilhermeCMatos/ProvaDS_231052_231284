namespace ProvaDS_231052_231284
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.tbo_produto = new System.Windows.Forms.TextBox();
            this.tbo_quantidade = new System.Windows.Forms.TextBox();
            this.tbo_valor = new System.Windows.Forms.TextBox();
            this.tbo_alterar = new System.Windows.Forms.TextBox();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_venda = new System.Windows.Forms.Label();
            this.dgv_venda = new System.Windows.Forms.DataGridView();
            this.nome_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_u = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Venda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Valor Unitário:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Alterar quantidade do item Selecionado:";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(126, 390);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(19, 13);
            this.lbl_valor.TabIndex = 6;
            this.lbl_valor.Text = "10";
            // 
            // tbo_produto
            // 
            this.tbo_produto.Location = new System.Drawing.Point(113, 69);
            this.tbo_produto.Name = "tbo_produto";
            this.tbo_produto.Size = new System.Drawing.Size(452, 20);
            this.tbo_produto.TabIndex = 7;
            // 
            // tbo_quantidade
            // 
            this.tbo_quantidade.Location = new System.Drawing.Point(113, 102);
            this.tbo_quantidade.Name = "tbo_quantidade";
            this.tbo_quantidade.Size = new System.Drawing.Size(154, 20);
            this.tbo_quantidade.TabIndex = 8;
            // 
            // tbo_valor
            // 
            this.tbo_valor.Location = new System.Drawing.Point(113, 134);
            this.tbo_valor.Name = "tbo_valor";
            this.tbo_valor.Size = new System.Drawing.Size(154, 20);
            this.tbo_valor.TabIndex = 9;
            // 
            // tbo_alterar
            // 
            this.tbo_alterar.Location = new System.Drawing.Point(237, 340);
            this.tbo_alterar.Name = "tbo_alterar";
            this.tbo_alterar.Size = new System.Drawing.Size(154, 20);
            this.tbo_alterar.TabIndex = 10;
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(300, 100);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(99, 54);
            this.btn_inserir.TabIndex = 11;
            this.btn_inserir.Text = "Inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(437, 100);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(99, 54);
            this.btn_remover.TabIndex = 12;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.Location = new System.Drawing.Point(410, 339);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(99, 20);
            this.btn_alterar.TabIndex = 13;
            this.btn_alterar.Text = "Alterar Quantidade";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(137, 426);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(99, 54);
            this.btn_gravar.TabIndex = 14;
            this.btn_gravar.Text = "Gravar Venda";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(260, 426);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(99, 54);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "Cancelar Venda";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.Location = new System.Drawing.Point(380, 426);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(99, 54);
            this.btn_finalizar.TabIndex = 16;
            this.btn_finalizar.Text = "Finalizar Venda";
            this.btn_finalizar.UseVisualStyleBackColor = true;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Total da Venda:";
            // 
            // lbl_venda
            // 
            this.lbl_venda.AutoSize = true;
            this.lbl_venda.Location = new System.Drawing.Point(110, 34);
            this.lbl_venda.Name = "lbl_venda";
            this.lbl_venda.Size = new System.Drawing.Size(13, 13);
            this.lbl_venda.TabIndex = 18;
            this.lbl_venda.Text = "0";
            // 
            // dgv_venda
            // 
            this.dgv_venda.AllowUserToAddRows = false;
            this.dgv_venda.AllowUserToDeleteRows = false;
            this.dgv_venda.AllowUserToOrderColumns = true;
            this.dgv_venda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_venda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome_produto,
            this.quantidade,
            this.valor_u});
            this.dgv_venda.Location = new System.Drawing.Point(37, 164);
            this.dgv_venda.Name = "dgv_venda";
            this.dgv_venda.ReadOnly = true;
            this.dgv_venda.Size = new System.Drawing.Size(502, 156);
            this.dgv_venda.TabIndex = 19;
            // 
            // nome_produto
            // 
            this.nome_produto.HeaderText = "PRODUTO";
            this.nome_produto.Name = "nome_produto";
            this.nome_produto.ReadOnly = true;
            // 
            // quantidade
            // 
            this.quantidade.HeaderText = "QUANTIDADE";
            this.quantidade.Name = "quantidade";
            this.quantidade.ReadOnly = true;
            // 
            // valor_u
            // 
            this.valor_u.HeaderText = "V. UNITÁRIO";
            this.valor_u.Name = "valor_u";
            this.valor_u.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 492);
            this.Controls.Add(this.dgv_venda);
            this.Controls.Add(this.lbl_venda);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_finalizar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.tbo_alterar);
            this.Controls.Add(this.tbo_valor);
            this.Controls.Add(this.tbo_quantidade);
            this.Controls.Add(this.tbo_produto);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_venda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.TextBox tbo_produto;
        private System.Windows.Forms.TextBox tbo_quantidade;
        private System.Windows.Forms.TextBox tbo_valor;
        private System.Windows.Forms.TextBox tbo_alterar;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_venda;
        private System.Windows.Forms.DataGridView dgv_venda;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome_produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_u;
    }
}

