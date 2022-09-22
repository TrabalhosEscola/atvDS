using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenchonProject
{
    public partial class Produto : Form
    {
        bool tipoEdicao = false;
        int atual = 0;
        private void HabilitaTextBox()
        {
            tbCodigo.Enabled = false;
            tbUnidade.Enabled = true;
            tbDescricao.Enabled = true;
            tbQtd.Enabled = true;
            tbCusto.Enabled = true;
            tbVenda.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAlterar.Enabled = false;
            btnAnterior.Enabled = false;
            btnExcluir.Enabled = false;
            btnImprimir.Enabled = false;
            btnNovo.Enabled = false;
            btnPesquisar.Enabled = false;
            btnProximo.Enabled = false;
            btnSair.Enabled = false;
        }
        private void DesabilitaTextBox()
        {
            tbCodigo.Enabled = false;
            tbUnidade.Enabled = false;
            tbDescricao.Enabled = false;
            tbQtd.Enabled = false;
            tbCusto.Enabled = false;
            tbVenda.Enabled = false;
            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAlterar.Enabled = true;
            btnAnterior.Enabled = true;
            btnExcluir.Enabled = true;
            btnImprimir.Enabled = true;
            btnNovo.Enabled = true;
            btnPesquisar.Enabled = true;
            btnProximo.Enabled = true;
            btnSair.Enabled = true;
        }

        private void MostrarOsDados()
        {
            tbCodigo.Text = PagPrincipal.produtos[atual].codigo.ToString();
            tbUnidade.Text = PagPrincipal.produtos[atual].nome;
            tbDescricao.Text = PagPrincipal.produtos[atual].descricao;
            tbQtd.Text = PagPrincipal.produtos[atual].qtd;
            tbCusto.Text = PagPrincipal.produtos[atual].precoDeCusto;
            tbVenda.Text = PagPrincipal.produtos[atual].precoDeVenda;
        }
        public Produto()
        {
            InitializeComponent();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (atual != 0)
            {
                atual--;
                MostrarOsDados();
            }
            else
            {
                MessageBox.Show("Inicio do arquivo!!");
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (atual < PagPrincipal.contadorProdutos - 1)
            {
                atual++;
                MostrarOsDados();
            }
            else
            {
                MessageBox.Show("Fim do arquivo!!");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (PagPrincipal.contadorProdutos < 15)
            {

                tbCodigo.Text = (PagPrincipal.contadorProdutos + 1).ToString();
                tbUnidade.Text = "";
                tbDescricao.Text = "";
                tbQtd.Text = "";
                tbCusto.Text = "";
                tbVenda.Text = "";
                HabilitaTextBox();
                tipoEdicao = true;
            }
            else
            {
                MessageBox.Show("Arquivo cheio!!!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (PagPrincipal.contadorProdutos > 0)
            {
                tipoEdicao = false;
                HabilitaTextBox();
            }
            else
            {
                MessageBox.Show("Arquivo vazio!!!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (PagPrincipal.contadorProdutos > 0)
            {
                PagPrincipal.produtos[atual].nome = "";
                PagPrincipal.produtos[atual].descricao = "";
                PagPrincipal.produtos[atual].qtd = "";
                PagPrincipal.produtos[atual].precoDeCusto = "";
                PagPrincipal.produtos[atual].precoDeVenda = "";
                MostrarOsDados();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tipoEdicao)
            {
                PagPrincipal.produtos[PagPrincipal.contadorProdutos].codigo = int.Parse(tbCodigo.Text);
                PagPrincipal.produtos[PagPrincipal.contadorProdutos].nome = tbUnidade.Text;
                PagPrincipal.produtos[PagPrincipal.contadorProdutos].descricao = tbDescricao.Text;
                PagPrincipal.produtos[PagPrincipal.contadorProdutos].qtd = tbQtd.Text;
                PagPrincipal.produtos[PagPrincipal.contadorProdutos].precoDeCusto = tbCusto.Text;
                PagPrincipal.produtos[PagPrincipal.contadorProdutos].precoDeVenda = tbVenda.Text;

                atual = PagPrincipal.contadorProdutos++;
            }
            else
            {
                PagPrincipal.produtos[atual].nome = tbUnidade.Text;
                PagPrincipal.produtos[atual].descricao = tbDescricao.Text;
                PagPrincipal.produtos[atual].qtd = tbQtd.Text;
                PagPrincipal.produtos[atual].precoDeCusto = tbCusto.Text;
                PagPrincipal.produtos[atual].precoDeVenda = tbVenda.Text;
            }
            DesabilitaTextBox();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitaTextBox();
            MostrarOsDados();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisa.Visible = true;
            tbPesquisa.Focus();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE PRODUTO" + (char)10 + (char)10;
            strDados = strDados + "--------------------------------------------------------------------------------------------------------" + (char)10 + (char)10;
            strDados = strDados + "Nome: " + tbCodigo.Text + (char)10 + (char)10;
            strDados = strDados + "Unidade: " + tbUnidade.Text + (char)10 + (char)10;
            strDados = strDados + "Descrição: " + tbDescricao.Text + (char)10 + (char)10;
            strDados = strDados + "Quantidade em estoque: " + tbQtd.Text + (char)10 + (char)10;
            strDados = strDados + "Preço de custo: " + tbCusto.Text + (char)10 + (char)10;
            strDados = strDados + "Preço de venda: " + tbVenda.Text;

            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 50, 50);
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            int x;
            for (x = 0; x < PagPrincipal.contadorProdutos; x++)
            {
                if (PagPrincipal.produtos[x].nome.IndexOf(tbPesquisa.Text) >= 0)
                {
                    atual = x;
                    MostrarOsDados();
                    break;
                }
            }
            if (x >= PagPrincipal.contadorProdutos)
            {
                MessageBox.Show("Produto não encontrado");
            }
            Pesquisa.Visible = false;
        }

        private void btnCancelarPesquisa_Click(object sender, EventArgs e)
        {
            Pesquisa.Visible = false;
        }

        private void Produto_Load(object sender, EventArgs e)
        {
            DesabilitaTextBox();
            MostrarOsDados();
        }
    }
}
