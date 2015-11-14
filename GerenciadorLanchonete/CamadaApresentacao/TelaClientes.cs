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
			rdCelular.Enabled = true;
			rdResidencial.Enabled = true;

			if (mtbCelular.Visible==true)
			{
				mtbCelular.Enabled = true;
			}
			else
			{
				if (mtbResidencial.Visible == true)
				{
					mtbResidencial.Enabled = true;
				}
            }
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            tbCodigo.Clear();
            tbEndereco.Clear();
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
			mtbCelular.Enabled = false;
			mtbResidencial.Enabled = false;
			rdCelular.Checked = false;
			rdResidencial.Checked = false;
			rdCelular.Enabled = false;
			rdResidencial.Enabled = false;

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
                    cbBairro.Text = BairroDAO.Buscar(cliente.getBairroId()).getNome();
                    tbEstado.Text = cliente.getEstado();
                    tbObservacao.Text = cliente.getObservacao();

					if (cliente.getNumero().Length==14)
					{
						mtbResidencial.Text = cliente.getNumero();
						mtbCelular.Visible = false;
						mtbResidencial.Visible = true;
						mtbCelular.Clear();
					}
					else
					{
						if (cliente.getNumero().Length == 15)
						{
							mtbCelular.Text = cliente.getNumero();
							mtbResidencial.Visible = false;
							mtbCelular.Visible = true;
							mtbResidencial.Clear();
						}
                    }

					rdResidencial.Checked = false;
					rdCelular.Checked = false;
					rdCelular.Enabled = false;
					rdResidencial.Enabled = false;

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
			String numero="";

			if (rdCelular.Checked)
			{
				numero = mtbCelular.Text;
			}
			else
			{
				if (rdResidencial.Checked)
				{
					numero = mtbResidencial.Text;
				}
			}

            if(botao == 2){
                if (tbCodigo.Text.Equals("") || tbNome.Text.Equals("") || tbEndereco.Text.Equals("") || tbCodigo.Text.Equals("") || cbBairro.Text.Equals("") || tbEstado.Text.Equals("") || tbCodigo.Text.Equals(""))
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
                    Clientes cliente = new Clientes(int.Parse(tbCodigo.Text), tbNome.Text, BairroDAO.BuscaNome(cbBairro.Text), numero, tbEndereco.Text, tbEstado.Text, tbObservacao.Text, checkAtivo);
                    if (ClienteDAO.Alterar(cliente))
                    {
                        MessageBox.Show("Cliente " + cliente.getNome() + " foi alterado com sucesso!");
                        bCancelar_Click(sender, e);
                    }
                }
            }
        }

        private void cbAtivo_CheckedChanged(object sender, EventArgs e){}

		private void pbLupaTelefone_Click(object sender, EventArgs e){
			try {
				if (rdResidencial.Checked)
				{
					if (!(rdResidencial.Text.Equals("(__)____-____")))
					{
						Clientes cliente = ClienteDAO.BuscaTelefone(mtbResidencial.Text);
						tbCodigo.Text = cliente.getClienteId().ToString();
						tbNome.Text = cliente.getNome();
						tbEndereco.Text = cliente.getEndereco();
						cbBairro.Text = BairroDAO.Buscar(cliente.getBairroId()).getNome();
						tbEstado.Text = cliente.getEstado();
						tbObservacao.Text = cliente.getObservacao();

						int checkAtivo = cliente.getAtivo();

						if (checkAtivo == 1)
						{
							cbAtivo.Checked = true;
						}
						else
						{
							cbAtivo.Checked = false;
						}
					}
				}
				else
				{
					if (rdCelular.Checked)
					{
						if (!(rdCelular.Text.Equals("(__)_____-____")))
						{
							Clientes cliente = ClienteDAO.BuscaTelefone(mtbCelular.Text);
							tbCodigo.Text = cliente.getClienteId().ToString();
							tbNome.Text = cliente.getNome();
							tbEndereco.Text = cliente.getEndereco();
							cbBairro.Text = BairroDAO.Buscar(cliente.getBairroId()).getNome();
							tbEstado.Text = cliente.getEstado();
							tbObservacao.Text = cliente.getObservacao();

							int checkAtivo = cliente.getAtivo();

							if (checkAtivo == 1)
							{
								cbAtivo.Checked = true;
							}
							else
							{
								cbAtivo.Checked = false;
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Não existe cliente com esse telefone!");
			}
		}

		private void rdResidencial_CheckedChanged(object sender, EventArgs e)
		{
			mtbCelular.Enabled = false;
			mtbCelular.Visible = false;
			mtbResidencial.Enabled = true;
			mtbResidencial.Visible = true;
		}

		private void rdCelular_CheckedChanged(object sender, EventArgs e)
		{
			mtbCelular.Enabled = true;
			mtbResidencial.Visible = false;
			mtbResidencial.Enabled = false;
			mtbCelular.Visible = true;
		}

		private void mtbCelular_Click(object sender, EventArgs e)
		{
			mtbCelular.SelectionStart = 1;
		}

		private void mtbResidencial_Click(object sender, EventArgs e)
		{
			mtbResidencial.SelectionStart = 1;
		}
	}
}
