using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaDados.DAO;

namespace CamadaApresentacao
{
    public partial class TelaClientes : Form
    {
        public TelaClientes()
        {
            InitializeComponent();

            List<String> bairros = BairroDAO.BuscaTodos();

            for (int i = 0; i < bairros.Count(); i++)
            {
                cbBairro.Items.Add(bairros[i]);
            }
        }

        private void bCadastrar_Click(object sender, EventArgs e)
        {
            tbCodigo.Enabled = false;
            tbCep.Enabled = true;
            tbEndereco.Enabled = true;
            tbTelefone.Enabled = true;
            tbNome.Enabled = true;
            cbBairro.Enabled = true;
            tbEstado.Enabled = true;
            tbObservacao.Enabled = true;
        }

        private void bAlterar_Click(object sender, EventArgs e)
        {
            tbCodigo.Enabled = false;
            tbCep.Enabled = true;
            tbEndereco.Enabled = true;
            tbTelefone.Enabled = true;
            tbNome.Enabled = true;
            cbBairro.Enabled = true;
            tbEstado.Enabled = true;
            tbObservacao.Enabled = true;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            tbCodigo.Clear();
            tbCep.Clear();
            tbEndereco.Clear();
            tbTelefone.Clear();
            tbNome.Clear();
            cbBairro.Text = "";
            tbEstado.Clear();
            tbObservacao.Clear();
            tbCodigo.Enabled = true;
            tbCep.Enabled = false;
            tbEndereco.Enabled = false;
            tbTelefone.Enabled = false;
            tbNome.Enabled = false;
            cbBairro.Enabled = false;
            tbEstado.Enabled = false;
            tbObservacao.Enabled = false;
        }
    }
}
