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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }
        bool tipoEdicao = false;
        int atual = 0;
        private void HabilitaEdicao()
        {
            tbCodigo.Enabled = false;
            tbNome.Enabled = true;
            tbSenha.Enabled = true;
            tbNivel.Enabled = true;
            tbLogin.Enabled = true;
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
        private void DesabilitaEdicao()
        {
            tbCodigo.Enabled = false;
            tbNome.Enabled = false;
            tbSenha.Enabled = false;
            tbNivel.Enabled = false;
            tbLogin.Enabled = false;
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

        private void MostrarDados()
        {
            tbCodigo.Text = PagPrincipal.usuarios[atual].codigo.ToString();
            tbNome.Text = PagPrincipal.usuarios[atual].nome;
            tbNivel.Text = PagPrincipal.usuarios[atual].nivel;
            tbLogin.Text = PagPrincipal.usuarios[atual].login;
            tbSenha.Text = PagPrincipal.usuarios[atual].senha;
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            MostrarDados();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (atual != 0)
            {
                atual--;
                MostrarDados();
            }
            else
            {
                MessageBox.Show("Inicio do arquivo!!");
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (atual < PagPrincipal.contUsuario - 1)
            {
                atual++;
                MostrarDados();
            }
            else
            {
                MessageBox.Show("Fim do arquivo!!");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (PagPrincipal.contUsuario < 10)
            {

                tbCodigo.Text = (PagPrincipal.contUsuario + 1).ToString();
                tbNome.Text = "";
                tbNivel.Text = "";
                tbLogin.Text = "";
                tbSenha.Text = "";
                HabilitaEdicao();
                tipoEdicao = true;
            }
            else
            {
                MessageBox.Show("Arquivo cheio!!!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (PagPrincipal.contUsuario > 0)
            {
                tipoEdicao = false;
                HabilitaEdicao();
            }
            else
            {
                MessageBox.Show("Arquivo vazio!!!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (PagPrincipal.contUsuario > 0)
            {
                PagPrincipal.usuarios[atual].nome = "";
                PagPrincipal.usuarios[atual].nivel = "";
                PagPrincipal.usuarios[atual].login = "";
                PagPrincipal.usuarios[atual].senha = "";
                MostrarDados();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tipoEdicao)
            {
                PagPrincipal.usuarios[PagPrincipal.contUsuario].codigo = int.Parse(tbCodigo.Text);
                PagPrincipal.usuarios[PagPrincipal.contUsuario].nome = tbNome.Text;
                PagPrincipal.usuarios[PagPrincipal.contUsuario].nivel = tbNivel.Text;
                PagPrincipal.usuarios[PagPrincipal.contUsuario].login = tbLogin.Text;
                PagPrincipal.usuarios[PagPrincipal.contUsuario].senha = tbSenha.Text;
                atual = PagPrincipal.contUsuario++;
            }
            else
            {
                PagPrincipal.usuarios[atual].nome = tbNome.Text;
                PagPrincipal.usuarios[atual].nivel = tbNivel.Text;
                PagPrincipal.usuarios[atual].login = tbLogin.Text;
                PagPrincipal.usuarios[atual].senha = tbSenha.Text;
            }
            DesabilitaEdicao();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DesabilitaEdicao();
            MostrarDados();
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

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            int x;
            for (x = 0; x < PagPrincipal.contUsuario; x++)
            {
                if (PagPrincipal.usuarios[x].nome.IndexOf(tbPesquisa.Text) >= 0)
                {
                    atual = x;
                    MostrarDados();
                    break;
                }
            }
            if (x >= PagPrincipal.contUsuario)
            {
                MessageBox.Show("Usuário não encontrado");
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

            strDados = "FICHA DE USUÁRIO" + (char)10 + (char)10;
            strDados = strDados + "--------------------------------------------------------------------------------------------------------" + (char)10 + (char)10;
            strDados = strDados + "Código: " + tbCodigo.Text + (char)10 + (char)10;
            strDados = strDados + "Nome: " + tbNome.Text + (char)10 + (char)10;
            strDados = strDados + "Nível: " + tbNivel.Text + (char)10 + (char)10;
            strDados = strDados + "Login: " + tbLogin.Text;

            objImpressao.DrawString(strDados, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, 50, 50);
        }
    }
}