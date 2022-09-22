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
    public partial class Cliente : Form
    {
        bool tipoEdicao = false;
        int atual = 0;
        private void HabilitarTextBox()
        {
            tbCodigo.Enabled = false;
            tbNome.Enabled = true;
            tbEndereco.Enabled = true;
            tbCpf.Enabled = true;
            tbRg.Enabled = true;
            tbEndereco.Enabled = true;
            tbBairro.Enabled = true;
            tbCidade.Enabled = true;
            tbUf.Enabled = true;
            tbCep.Enabled = true;
            tbTelefone.Enabled = true;
            tbEmail.Enabled = true;
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
        private void DesabilitarTextBox()
        {
            tbCodigo.Enabled = false;
            tbNome.Enabled = false;
            tbEndereco.Enabled = false;
            tbCpf.Enabled = false;
            tbRg.Enabled = false;
            tbEndereco.Enabled = false;
            tbBairro.Enabled = false;
            tbCidade.Enabled = false;
            tbUf.Enabled = false;
            tbCep.Enabled = false;
            tbTelefone.Enabled = false;
            tbEmail.Enabled = false;
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
            tbCodigo.Text = PagPrincipal.clientes[atual].codigo.ToString();
            tbNome.Text = PagPrincipal.clientes[atual].nome;
            tbCpf.Text = PagPrincipal.clientes[atual].cpf;
            tbRg.Text = PagPrincipal.clientes[atual].rg;
            tbEndereco.Text = PagPrincipal.clientes[atual].endereco;
            tbBairro.Text = PagPrincipal.clientes[atual].bairro;
            tbCidade.Text = PagPrincipal.clientes[atual].cidade;
            tbUf.Text = PagPrincipal.clientes[atual].uf;
            tbCep.Text = PagPrincipal.clientes[atual].cep;
            tbTelefone.Text = PagPrincipal.clientes[atual].telefone;
            tbEmail.Text = PagPrincipal.clientes[atual].email;
        }
        public Cliente()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tbVenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            DesabilitarTextBox();
            MostrarOsDados();
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
            if (atual < PagPrincipal.contadorClientes - 1)
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
            if (PagPrincipal.contadorClientes < 15)
            {

                tbCodigo.Text = (PagPrincipal.contadorClientes + 1).ToString();
                tbNome.Text = "";
                tbCpf.Text = "";
                tbRg.Text = "";
                tbEndereco.Text = "";
                tbBairro.Text = "";
                tbCidade.Text = "";
                tbUf.Text = "";
                tbCep.Text = "";
                tbTelefone.Text = "";
                tbEmail.Text = "";
                HabilitarTextBox();
                tipoEdicao = true;
            }
            else
            {
                MessageBox.Show("Arquivo cheio!!!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (PagPrincipal.contadorClientes > 0)
            {
                tipoEdicao = false;
                HabilitarTextBox();
            }
            else
            {
                MessageBox.Show("Arquivo vazio!!!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (PagPrincipal.contadorClientes > 0)
            {
                PagPrincipal.clientes[atual].codigo = int.Parse(tbCodigo.Text);
                PagPrincipal.clientes[atual].nome = "";
                PagPrincipal.clientes[atual].cpf = "";
                PagPrincipal.clientes[atual].rg = "";
                PagPrincipal.clientes[atual].endereco = "";
                PagPrincipal.clientes[atual].bairro = "";
                PagPrincipal.clientes[atual].cidade = "";
                PagPrincipal.clientes[atual].uf = "";
                PagPrincipal.clientes[atual].cep = "";
                PagPrincipal.clientes[atual].telefone = "";
                PagPrincipal.clientes[atual].email = "";
                MostrarOsDados();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tipoEdicao)
            {
                PagPrincipal.clientes[PagPrincipal.contadorClientes].codigo = int.Parse(tbCodigo.Text);
                PagPrincipal.clientes[PagPrincipal.contadorClientes].nome = tbNome.Text;
                PagPrincipal.clientes[PagPrincipal.contadorClientes].cpf = tbCpf.Text;
                PagPrincipal.clientes[PagPrincipal.contadorClientes].rg = tbRg.Text;
                PagPrincipal.clientes[PagPrincipal.contadorClientes].endereco = tbEndereco.Text;
                PagPrincipal.clientes[PagPrincipal.contadorClientes].bairro = tbBairro.Text;
                PagPrincipal.clientes[PagPrincipal.contadorClientes].cidade = tbCidade.Text;
                PagPrincipal.clientes[PagPrincipal.contadorClientes].uf = tbUf.Text;
                PagPrincipal.clientes[PagPrincipal.contadorClientes].cep = tbCep.Text;
                PagPrincipal.clientes[PagPrincipal.contadorClientes].telefone = tbTelefone.Text;
                PagPrincipal.clientes[PagPrincipal.contadorClientes].email = tbEmail.Text;

                atual = PagPrincipal.contadorClientes++;
            }
            else
            {
                PagPrincipal.clientes[atual].codigo = int.Parse(tbCodigo.Text);
                PagPrincipal.clientes[atual].nome = tbNome.Text;
                PagPrincipal.clientes[atual].cpf = tbCpf.Text;
                PagPrincipal.clientes[atual].rg = tbRg.Text;
                PagPrincipal.clientes[atual].endereco = tbEndereco.Text;
                PagPrincipal.clientes[atual].bairro = tbBairro.Text;
                PagPrincipal.clientes[atual].cidade = tbCidade.Text;
                PagPrincipal.clientes[atual].uf = tbUf.Text;
                PagPrincipal.clientes[atual].cep = tbCep.Text;
                PagPrincipal.clientes[atual].telefone = tbTelefone.Text;
                PagPrincipal.clientes[atual].email = tbEmail.Text;
            }
            DesabilitarTextBox();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitarTextBox();
            MostrarOsDados();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisa.Visible = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            int x;
            for (x = 0; x < PagPrincipal.contadorClientes; x++)
            {
                if (PagPrincipal.clientes[x].nome.IndexOf(tbPesquisa.Text) >= 0)
                {
                    atual = x;
                    MostrarOsDados();
                    break;
                }
            }
            if (x >= PagPrincipal.contadorClientes)
            {
                MessageBox.Show("Produto não encontrado");
            }
            Pesquisa.Visible = false;
        }

        private void btnCancelarPesquisa_Click(object sender, EventArgs e)
        {
            Pesquisa.Visible = false;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados;
            Graphics objImpressao = e.Graphics;

            strDados = "FICHA DE CLIENTE" + (char)10 + (char)10;
            strDados = strDados + "--------------------------------------------------------------------------------------------------------" + (char)10 + (char)10;
            strDados = strDados + "Nome: " + tbNome.Text + (char)10 + (char)10;
            strDados = strDados + "CPF:: " + tbCpf.Text + (char)10 + (char)10;
            strDados = strDados + "RG: " + tbRg.Text + (char)10 + (char)10;
            strDados = strDados + "Endereço: " + tbEndereco.Text + (char)10 + (char)10;
            strDados = strDados + "Bairro: " + tbBairro.Text + (char)10 + (char)10;
            strDados = strDados + "Cidade: " + tbCidade.Text + (char)10 + (char)10;
            strDados = strDados + "UF: " + tbUf.Text + (char)10 + (char)10;
            strDados = strDados + "CEP: " + tbCep.Text + (char)10 + (char)10;
            strDados = strDados + "Telefone: " + tbTelefone.Text + (char)10 + (char)10;
            strDados = strDados + "Email: " + tbEmail.Text;

            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 50, 50);
        }
    }
}
