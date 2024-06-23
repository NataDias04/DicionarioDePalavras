using System;
using System.Windows.Forms;

namespace Trabalho_AED2
{
    public partial class FormAdicionarPalavra : Form
    {
        public string? Palavra { get; private set; }

        public FormAdicionarPalavra()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Palavra = txtPalavra.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void txtPalavra_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAdicionarPalavra_Load(object sender, EventArgs e)
        {

        }
    }
}
