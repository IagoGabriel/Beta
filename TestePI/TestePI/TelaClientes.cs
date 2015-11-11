using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestePI
{
    public partial class TelaClientes : Form
    {
        public TelaClientes()
        {
            InitializeComponent();
        }

        private void bCadastrar_Click(object sender, EventArgs e)
        {
            tbCodigo.Enabled = false;
            tbCep.Enabled = true;
            tbEndereco.Enabled = true;
            tbTelefone.Enabled = true;
            tbNome.Enabled = true;
            tbBairro.Enabled = true;
            tbEstado.Enabled = true;
            tbObservacao.Enabled = true;
            cbAtivo.Checked = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lupa foi clicada!");
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            tbCodigo.Clear();
            tbCep.Clear();
            tbEndereco.Clear();
            tbTelefone.Clear();
            tbNome.Clear();
            tbBairro.Clear();
            tbEstado.Clear();
            tbObservacao.Clear();
        }

        private void bAlterar_Click(object sender, EventArgs e)
        {
            tbCodigo.Enabled = false;
            tbCep.Enabled = true;
            tbEndereco.Enabled = true;
            tbTelefone.Enabled = true;
            tbNome.Enabled = true;
            tbBairro.Enabled = true;
            tbEstado.Enabled = true;
            tbObservacao.Enabled = true;
        }
    }
}
