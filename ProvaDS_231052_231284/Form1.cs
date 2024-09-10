using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaDS_231052_231284
{
    public partial class Form1 : Form
    {
        int total_venda = 1;
        double total_valor = 0;

        public Form1()
        {
            InitializeComponent();
            UpdateTotalVendas();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            // Adiciona o conteúdo das caixas de texto nas colunas correspondentes
            dgv_venda.Rows.Add(tbo_produto.Text, tbo_quantidade.Text, tbo_valor.Text);
            //
            // Limpa as caixas de texto
            tbo_produto.Clear();
            tbo_quantidade.Clear();
            tbo_valor.Clear();
            // Exibe uma mensagem ao usuário de inclusão com sucesso!
            MessageBox.Show("Produto incluido com sucesso!", "Inclusão",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            UpdateTotalVendas();
        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            // Verifica a existência de linhas no Grid
            dgv_venda.Rows.RemoveAt(dgv_venda.CurrentRow.Index);

            //Exibe uma mensagem ao usuário de exclusão com sucesso
            MessageBox.Show("Produto excluído com sucesso!", "Exclusão",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            UpdateTotalVendas();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (tbo_alterar.Text != "")
            {
                // Move o novo valor da caixa de texto Alterar para a célula selecionada
                dgv_venda.CurrentRow.Cells["quantidade"].Value = tbo_alterar.Text;
                //Limpa
                tbo_alterar.Clear();
                // Exibe a mensagem de alteração com sucesso
                MessageBox.Show("Produto alterado com sucesso!", "Alteração",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            UpdateTotalVendas();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            lbl_venda.Text = total_venda.ToString();
            total_venda += 1;
            while (dgv_venda.RowCount != 0) 
            {
                foreach (DataGridViewRow item in dgv_venda.Rows)
                {
                    dgv_venda.Rows.Remove(item);
                }
            }
            UpdateTotalVendas();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            tbo_produto.Clear();
            tbo_quantidade.Clear();
            tbo_valor.Clear();
            tbo_alterar.Clear();
            lbl_valor.Text = total_valor.ToString();
            while (dgv_venda.RowCount != 0)
            {
                foreach (DataGridViewRow item in dgv_venda.Rows)
                {
                    dgv_venda.Rows.Remove(item);
                }
            }
            UpdateTotalVendas();
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateTotalVendas()
        {
            total_valor = 0;
            foreach (DataGridViewRow row in dgv_venda.Rows)
            {
                if (row.Cells["valor_u"].Value != null && row.Cells["quantidade"].Value != null)
                {
                    double valorProduto;
                    int quantidadeProduto;
                    if (double.TryParse(row.Cells["valor_u"].Value.ToString(), out valorProduto) &&
                        int.TryParse(row.Cells["quantidade"].Value.ToString(), out quantidadeProduto))
                    {
                        total_valor += valorProduto * quantidadeProduto;

                    }
                }

            }
            lbl_valor.Text = $"{total_valor:C}";
        }
    }
}
