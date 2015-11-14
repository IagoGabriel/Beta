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
using CamadaDados.Entidades;

namespace CamadaApresentacao
{
    public partial class TelaClientes : Form
    {
        int botao = 0;

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
            tbEndereco.Enabled = true;
            tbNome.Enabled = true;
            cbBairro.Enabled = true;
            tbEstado.Enabled = true;
            tbObservacao.Enabled = true;
            botao = 1;
			cbAtivo.Enabled = true;
			tbTelefone.ForeColor = Color.Black;
		}

        private void bAlterar_Click(object sender, EventArgs e)
        {
            tbCodigo.Enabled = false;
            tbEndereco.Enabled = true;
            tbNome.Enabled = true;
            cbBairro.Enabled = true;
            tbEstado.Enabled = true;
            tbObservacao.Enabled = true;
            botao = 2;
			cbAtivo.Enabled = true;
			tbTelefone.Enabled = true;
			tbTelefone.ForeColor = Color.Black;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            tbCodigo.Clear();
            tbEndereco.Clear();
            tbTelefone.Text = "(27)99999-9999";
            tbNome.Clear();
            cbBairro.Text = "";
            tbEstado.Clear();
            tbObservacao.Clear();
            tbCodigo.Enabled = true;
            tbEndereco.Enabled = false;
            tbNome.Enabled = false;
            cbBairro.Enabled = false;
            tbEstado.Enabled = false;
            tbObservacao.Enabled = false;
			cbAtivo.Enabled = false;
			cbAtivo.Checked = false;
			tbTelefone.ForeColor = Color.Silver;
		}

        private void pbLupaCodigo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(tbCodigo.Text.Equals("")))
                {
					Clientes cliente = ClienteDAO.Buscar(int.Parse(tbCodigo.Text));
                    tbNome.Text = cliente.getNome();
                    tbEndereco.Text = cliente.getEndereco();
                    tbTelefone.Text = cliente.getNumero().ToString();
                    cbBairro.Text = BairroDAO.Buscar(cliente.getBairroId()).getNome();
                    tbEstado.Text = cliente.getEstado();
                    tbObservacao.Text = cliente.getObservacao();

					tbTelefone.Enabled = false;

					int checkAtivo = cliente.getAtivo();

					if (checkAtivo == 1)
					{
						cbAtivo.Checked = true;
					}
					else
					{
						cbAtivo.Checked =false;
					}
					
				}
            }catch(Exception ex){
                MessageBox.Show("Não existe cliente com esse código!");
            }
        }

        private void bEfetivar_Click(object sender, EventArgs e)
        {
			int checkAtivo;

            if(botao == 2){
                if (tbCodigo.Text.Equals("") || tbNome.Text.Equals("") || tbEndereco.Text.Equals("") || tbTelefone.Text.Equals("") || tbCodigo.Text.Equals("") || cbBairro.Text.Equals("") || tbEstado.Text.Equals("") || tbCodigo.Text.Equals(""))
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios.");
                }
                else
                {
					if (cbAtivo.Checked) {
						checkAtivo = 1;
					}
					else
					{
						checkAtivo = 0;
					}
                    Clientes cliente = new Clientes(int.Parse(tbCodigo.Text), tbNome.Text, BairroDAO.BuscaNome(cbBairro.Text), int.Parse(tbTelefone.Text), tbEndereco.Text, tbEstado.Text, tbObservacao.Text, checkAtivo);
                    if (ClienteDAO.Alterar(cliente))
                    {
                        MessageBox.Show("Cliente " + cliente.getNome() + " foi alterado com sucesso!");
                        bCancelar_Click(sender, e);
                    }
                }
            }
        }

        private void cbAtivo_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void pbLupaTelefone_Click(object sender, EventArgs e)
		{

		}

		private void tbTelefone_TextChanged(object sender, EventArgs e)
		{

		}

		private void tbTelefone_Click(object sender, EventArgs e)
		{
			tbTelefone.SelectionStart = tbTelefone.Text.Length + 1;
		}
	}
}
