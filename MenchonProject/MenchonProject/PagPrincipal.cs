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
    public partial class PagPrincipal : Form
    {
        public struct Usuarios
        {
            public int codigo;
            public string nome;
            public string nivel;
            public string login;
            public string senha;
        }
        static public Usuarios[] usuarios = new Usuarios[10];
        static public int contUsuario = 0;
        public struct Clientes
        {
            public int codigo;
            public string nome;
            public string cpf;
            public string rg;
            public string endereco;
            public string bairro;
            public string cidade;
            public string uf;
            public string cep;
            public string telefone;
            public string email;
        }
        static public Clientes[] clientes = new Clientes[15];
        static public int contadorClientes = 0;

        public struct Produtos
        {
            public int codigo;
            public string nome;
            public string descricao;
            public string qtd;
            public string precoDeCusto;
            public string precoDeVenda;
        }
        static public Produtos[] produtos = new Produtos[20];
        static public int contadorProdutos = 0;
        public PagPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuario mostrarPagina = new Usuario();
            mostrarPagina.ShowDialog();
        }

        private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produto mostrarPagina = new Produto();
            mostrarPagina.ShowDialog();
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cliente mostrarPagina = new Cliente();
            mostrarPagina.ShowDialog();
        }

        private void printDocumentUsuario_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados = "";
            Graphics objImpressao = e.Graphics;
            int pag = 0, linha = 0, i = 0;
            bool cabecalho = true, itens = true;

            while (cabecalho)
            {
                pag++;
                strDados = "                                       RELATÓRIO DE USUÁRIOS" + (char)10;
                strDados += "Data: " + DateTime.Now.ToString("dd/MM/yyyy") + "                                                        Pag: " + pag.ToString("00") + (char)10;
                strDados += "--------------------------------------------------------------------------------" + (char)10;
                strDados += "Código Nome                                     Nível Login" + (char)10;
                strDados += "--------------------------------------------------------------------------------" + (char)10;
                linha = 5;
                while (itens)
                {
                    strDados += usuarios[i].codigo.ToString("000000") + " " + usuarios[i].nome.PadRight(40) + "   " + usuarios[i].nivel + "   " + usuarios[i].login + (char)10;
                    linha++;
                    i++;
                    if (linha >= 64)
                    {
                        itens = false;
                        strDados += (char)12;
                    }
                    if (i >= contUsuario)
                    {
                        itens = false;
                        cabecalho = false;
                    }
                }
                objImpressao.DrawString(strDados, new Font("Courier New", 10, FontStyle.Regular), Brushes.Black, 50, 50);
            }
        }

        private void printDocumentCliente_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados = "";
            Graphics objImpressao = e.Graphics;
            int pag = 0, linha = 0, i = 0;
            bool cabecalho = true, itens = true;

            while (cabecalho)
            {
                pag++;
                strDados = "                                       RELATÓRIO DE CLIENTES" + (char)10;
                strDados += "Data: " + DateTime.Now.ToString("dd/MM/yyyy") + "                                                        Pag: " + pag.ToString("00") + (char)10;
                strDados += "--------------------------------------------------------------------------------" + (char)10;
                strDados += "Código Nome                                     RG Email" + (char)10;
                strDados += "--------------------------------------------------------------------------------" + (char)10;
                linha = 5;
                while (itens)
                {
                    strDados += clientes[i].codigo.ToString("000000") + " " + clientes[i].nome.PadRight(40) + "    " + clientes[i].rg + "     " + clientes[i].email + (char)10;
                    linha++;
                    i++;
                    if (linha >= 64)
                    {
                        itens = false;
                        strDados += (char)12;
                    }
                    if (i >= contadorClientes)
                    {
                        itens = false;
                        cabecalho = false;
                    }
                }
                objImpressao.DrawString(strDados, new Font("Courier New", 10, FontStyle.Regular), Brushes.Black, 50, 50);
            }
        }

        private void printDocumentProduto_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDados = "";
            Graphics objImpressao = e.Graphics;
            int pag = 0, linha = 0, i = 0;
            bool cabecalho = true, itens = true;

            while (cabecalho)
            {
                pag++;
                strDados = "                                       RELATÓRIO DE PRODUTOS" + (char)10;
                strDados += "Data: " + DateTime.Now.ToString("dd/MM/yyyy") + "                                                        Pag: " + pag.ToString("00") + (char)10;
                strDados += "--------------------------------------------------------------------------------" + (char)10;
                strDados += "Código Unidade                                     Custo Venda" + (char)10;
                strDados += "--------------------------------------------------------------------------------" + (char)10;
                linha = 5;
                while (itens)
                {
                    strDados += produtos[i].codigo.ToString("000000") + " " + produtos[i].nome.PadRight(40) + "    " + produtos[i].precoDeCusto + "     " + produtos[i].precoDeVenda + (char)10;
                    linha++;
                    i++;
                    if (linha >= 64)
                    {
                        itens = false;
                        strDados += (char)12;
                    }
                    if (i >= contadorProdutos)
                    {
                        itens = false;
                        cabecalho = false;
                    }
                }
                objImpressao.DrawString(strDados, new Font("Courier New", 10, FontStyle.Regular), Brushes.Black, 50, 50);
            }
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewUsuario.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewCliente.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewProduto.ShowDialog();
        }
    }
}
