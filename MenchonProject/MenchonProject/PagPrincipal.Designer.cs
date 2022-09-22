namespace MenchonProject
{
    partial class PagPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocumentUsuario = new System.Drawing.Printing.PrintDocument();
            this.printDocumentCliente = new System.Drawing.Printing.PrintDocument();
            this.printDocumentProduto = new System.Drawing.Printing.PrintDocument();
            this.printPreviewUsuario = new System.Windows.Forms.PrintPreviewDialog();
            this.printPreviewCliente = new System.Windows.Forms.PrintPreviewDialog();
            this.printPreviewProduto = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(648, 69);
            this.label1.TabIndex = 3;
            this.label1.Text = "MENCHON EMPRESA";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrsToolStripMenuItem,
            this.relaoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrsToolStripMenuItem
            // 
            this.cadastrsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeUsuáriosToolStripMenuItem,
            this.cadastroDeProdutosToolStripMenuItem,
            this.cadastroDeClientesToolStripMenuItem});
            this.cadastrsToolStripMenuItem.Name = "cadastrsToolStripMenuItem";
            this.cadastrsToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cadastrsToolStripMenuItem.Text = "Cadastros";
            // 
            // cadastroDeUsuáriosToolStripMenuItem
            // 
            this.cadastroDeUsuáriosToolStripMenuItem.Name = "cadastroDeUsuáriosToolStripMenuItem";
            this.cadastroDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cadastroDeUsuáriosToolStripMenuItem.Text = "Usuários";
            this.cadastroDeUsuáriosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeUsuáriosToolStripMenuItem_Click);
            // 
            // cadastroDeProdutosToolStripMenuItem
            // 
            this.cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
            this.cadastroDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cadastroDeProdutosToolStripMenuItem.Text = "Produtos";
            this.cadastroDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeProdutosToolStripMenuItem_Click);
            // 
            // cadastroDeClientesToolStripMenuItem
            // 
            this.cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
            this.cadastroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cadastroDeClientesToolStripMenuItem.Text = "Clientes";
            this.cadastroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeClientesToolStripMenuItem_Click);
            // 
            // relaoToolStripMenuItem
            // 
            this.relaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuáriosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.produtosToolStripMenuItem});
            this.relaoToolStripMenuItem.Name = "relaoToolStripMenuItem";
            this.relaoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.relaoToolStripMenuItem.Text = "Relatórios";
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.clientesToolStripMenuItem.Text = "Produtos";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.produtosToolStripMenuItem.Text = "Clientes";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // printDocumentUsuario
            // 
            this.printDocumentUsuario.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentUsuario_PrintPage);
            // 
            // printDocumentCliente
            // 
            this.printDocumentCliente.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentCliente_PrintPage);
            // 
            // printDocumentProduto
            // 
            this.printDocumentProduto.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentProduto_PrintPage);
            // 
            // printPreviewUsuario
            // 
            this.printPreviewUsuario.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewUsuario.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewUsuario.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewUsuario.Document = this.printDocumentUsuario;
            this.printPreviewUsuario.Enabled = true;
            this.printPreviewUsuario.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewUsuario.Icon")));
            this.printPreviewUsuario.Name = "printPreviewUsuario";
            this.printPreviewUsuario.Visible = false;
            // 
            // printPreviewCliente
            // 
            this.printPreviewCliente.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewCliente.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewCliente.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewCliente.Document = this.printDocumentCliente;
            this.printPreviewCliente.Enabled = true;
            this.printPreviewCliente.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewCliente.Icon")));
            this.printPreviewCliente.Name = "printPreviewCliente";
            this.printPreviewCliente.Visible = false;
            // 
            // printPreviewProduto
            // 
            this.printPreviewProduto.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewProduto.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewProduto.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewProduto.Document = this.printDocumentProduto;
            this.printPreviewProduto.Enabled = true;
            this.printPreviewProduto.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewProduto.Icon")));
            this.printPreviewProduto.Name = "printPreviewProduto";
            this.printPreviewProduto.Visible = false;
            // 
            // PagPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MenchonProject.Properties.Resources.imagemfund;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Name = "PagPrincipal";
            this.Text = "PagPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocumentUsuario;
        private System.Drawing.Printing.PrintDocument printDocumentCliente;
        private System.Drawing.Printing.PrintDocument printDocumentProduto;
        private System.Windows.Forms.PrintPreviewDialog printPreviewUsuario;
        private System.Windows.Forms.PrintPreviewDialog printPreviewCliente;
        private System.Windows.Forms.PrintPreviewDialog printPreviewProduto;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
    }
}