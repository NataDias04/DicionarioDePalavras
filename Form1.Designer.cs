namespace Trabalho_AED2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip barraDeMenu;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.TextBox caixaDeTexto;
        private System.Windows.Forms.ToolStripMenuItem dicionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verificarPalavrasToolStripMenuItem;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se recursos gerenciados devem ser descartados; caso contrário, false.</param>
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
            barraDeMenu = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            salvarToolStripMenuItem = new ToolStripMenuItem();
            dicionarioToolStripMenuItem = new ToolStripMenuItem();
            verificarPalavrasToolStripMenuItem = new ToolStripMenuItem();
            adicionarPalavrasSublinhadasToolStripMenuItem = new ToolStripMenuItem();
            caixaDeTexto = new TextBox();
            barraDeMenu.SuspendLayout();
            SuspendLayout();
            // 
            // barraDeMenu
            // 
            barraDeMenu.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem, dicionarioToolStripMenuItem });
            barraDeMenu.Location = new Point(0, 0);
            barraDeMenu.Name = "barraDeMenu";
            barraDeMenu.Padding = new Padding(7, 2, 0, 2);
            barraDeMenu.Size = new Size(933, 24);
            barraDeMenu.TabIndex = 0;
            barraDeMenu.Text = "barraDeMenu";
            barraDeMenu.ItemClicked += barraDeMenu_ItemClicked;
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, salvarToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(61, 20);
            arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(105, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // salvarToolStripMenuItem
            // 
            salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            salvarToolStripMenuItem.Size = new Size(105, 22);
            salvarToolStripMenuItem.Text = "Salvar";
            salvarToolStripMenuItem.Click += salvarToolStripMenuItem_Click;
            // 
            // dicionarioToolStripMenuItem
            // 
            dicionarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { verificarPalavrasToolStripMenuItem, adicionarPalavrasSublinhadasToolStripMenuItem });
            dicionarioToolStripMenuItem.Name = "dicionarioToolStripMenuItem";
            dicionarioToolStripMenuItem.Size = new Size(73, 20);
            dicionarioToolStripMenuItem.Text = "Dicionário";
            // 
            // verificarPalavrasToolStripMenuItem
            // 
            verificarPalavrasToolStripMenuItem.Name = "verificarPalavrasToolStripMenuItem";
            verificarPalavrasToolStripMenuItem.Size = new Size(237, 22);
            verificarPalavrasToolStripMenuItem.Text = "Verificar Palavras";
            verificarPalavrasToolStripMenuItem.Click += verificarPalavrasToolStripMenuItem_Click;
            // 
            // adicionarPalavrasSublinhadasToolStripMenuItem
            // 
            adicionarPalavrasSublinhadasToolStripMenuItem.Name = "adicionarPalavrasSublinhadasToolStripMenuItem";
            adicionarPalavrasSublinhadasToolStripMenuItem.Size = new Size(237, 22);
            adicionarPalavrasSublinhadasToolStripMenuItem.Text = "Adicionar palavras sublinhadas";
            verificarPalavrasToolStripMenuItem.Click += adicionarPalavrasSublinhadasToolStripMenuItem_Click;
            // 
            // caixaDeTexto
            //
            caixaDeTexto.Dock = DockStyle.Fill;
            caixaDeTexto.Location = new Point(0, 24);
            caixaDeTexto.Margin = new Padding(4, 3, 4, 3);
            caixaDeTexto.Multiline = true;
            caixaDeTexto.Name = "caixaDeTexto";
            caixaDeTexto.Size = new Size(933, 495);
            caixaDeTexto.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(caixaDeTexto);
            Controls.Add(barraDeMenu);
            MainMenuStrip = barraDeMenu;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Editor de Texto";
            barraDeMenu.ResumeLayout(false);
            barraDeMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem adicionarPalavrasSublinhadasToolStripMenuItem;
    }
}
