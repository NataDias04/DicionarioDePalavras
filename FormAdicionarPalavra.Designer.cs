namespace Trabalho_AED2
{
    partial class FormAdicionarPalavra
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtPalavra;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancelar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtPalavra = new TextBox();
            btnOk = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtPalavra
            // 
            txtPalavra.Location = new Point(14, 14);
            txtPalavra.Margin = new Padding(4, 3, 4, 3);
            txtPalavra.Name = "txtPalavra";
            txtPalavra.Size = new Size(303, 23);
            txtPalavra.TabIndex = 0;
            txtPalavra.TextChanged += txtPalavra_TextChanged;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(135, 44);
            btnOk.Margin = new Padding(4, 3, 4, 3);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(88, 27);
            btnOk.TabIndex = 1;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(230, 44);
            btnCancelar.Margin = new Padding(4, 3, 4, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 27);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormAdicionarPalavra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(331, 82);
            Controls.Add(btnCancelar);
            Controls.Add(btnOk);
            Controls.Add(txtPalavra);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormAdicionarPalavra";
            Text = "Adicionar Palavra";
            Load += FormAdicionarPalavra_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
