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
	public partial class TelaFuncionarios : Form
	{
		int botao = 0;

		public TelaFuncionarios()
		{
			InitializeComponent();
			cbCargo.Select();
			List<String> cargos = CargoDAO.BuscaTodos();

			for (int i = 0; i < cargos.Count(); i++)
			{
				cbCargo.Items.Add(cargos[i]);
			}
		}

		private void bCadastrar_Click(object sender, EventArgs e)
		{
			tbCodigo.Enabled = false;
			cbCargo.Enabled = true;
			tbEndereco.Enabled = true;
			tbNome.Enabled = true;
			tbBairro.Enabled = true;
			tbEstado.Enabled = true;
			tbObservacao.Enabled = true;
			botao = 1;
			cbAtivo.Enabled = true;
			rdCelular.Enabled = true;
			rdResidencial.Enabled = true;
		}

		private void bEfetivar_Click(object sender, EventArgs e)
		{
			/*Certo*/

		}
		private void bCancelar_Click(object sender, EventArgs e)
		{
			tbCodigo.Select();
			cbCargo.Enabled = false;
			rdCelular.Checked = false;
			rdResidencial.Checked = false;
			rdCelular.Enabled = true;
			rdResidencial.Enabled = true;
			mtbCelular.Enabled = false;
			mtbResidencial.Enabled = false;

			tbCodigo.Clear();
			tbEndereco.Clear();
			tbNome.Clear();
			tbBairro.Text = "";
			tbEstado.Clear();
			tbObservacao.Clear();
			mtbCelular.Clear();
			mtbResidencial.Clear();
			tbCodigo.Enabled = true;
			cbCargo.Enabled = false;
			tbEndereco.Enabled = false;
			tbNome.Enabled = false;
			tbBairro.Enabled = false;
			tbEstado.Enabled = false;
			tbObservacao.Enabled = false;
			cbAtivo.Enabled = false;
			cbAtivo.Checked = false;
		}

		private void bAlterar_Click(object sender, EventArgs e)
		{
			tbCodigo.Enabled = false;
			cbCargo.Enabled = true;
			tbEndereco.Enabled = true;
			tbNome.Enabled = true;
			tbBairro.Enabled = true;
			tbEstado.Enabled = true;
			tbObservacao.Enabled = true;
			botao = 2;
			cbAtivo.Enabled = true;
			rdCelular.Enabled = true;
			rdResidencial.Enabled = true;

			if (mtbCelular.Visible == true)
			{
				mtbCelular.Enabled = true;
				rdCelular.Checked = true;
			}
			else
			{
				if (mtbResidencial.Visible == true)
				{
					mtbResidencial.Enabled = true;
					rdResidencial.Checked = true;
				}
			}
		}


		private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void pbLupaCodigo_Click(object sender, EventArgs e)
		{
			try
			{
				if (!(tbCodigo.Text.Equals("")))
				{
					Funcionarios funcionario = FuncionarioDAO.Buscar(int.Parse(tbCodigo.Text));
					cbCargo.Text = CargoDAO.Buscar(funcionario.getCargoId()).getNome();
					tbNome.Text = funcionario.getNome();
					tbEndereco.Text = funcionario.getEndereco();
					tbBairro.Text = funcionario.getBairro();
					tbEstado.Text = funcionario.getEstado();
					tbObservacao.Text = funcionario.getObservacao();

					if (funcionario.getNumero().Length == 14)
					{
						rdResidencial.Checked = true;
						mtbResidencial.Text = funcionario.getNumero();
						mtbCelular.Visible = false;
						mtbResidencial.Visible = true;
						mtbCelular.Clear();
					}
					else
					{
						if (funcionario.getNumero().Length == 15)
						{
							rdCelular.Checked = true;
							mtbCelular.Text = funcionario.getNumero();
							mtbResidencial.Visible = false;
							mtbCelular.Visible = true;
							mtbResidencial.Clear();
						}
					}

					rdResidencial.Checked = false;
					rdCelular.Checked = false;
					rdCelular.Enabled = false;
					rdResidencial.Enabled = false;

					int checkAtivo = funcionario.getAtivo();

					if (checkAtivo == 1)
					{
						cbAtivo.Checked = true;
					}
					else
					{
						cbAtivo.Checked = false;
					}

					if (mtbCelular.Visible == true)
					{
						rdCelular.Checked = true;
						mtbCelular.Enabled = false;
					}
					else
					{
						if (mtbResidencial.Visible == true)
						{
							rdResidencial.Checked = true;
							mtbResidencial.Enabled = false;
						}
					}
				}
				else
				{
					MessageBox.Show("Preencha o código que deseja buscar!");
				}
			}
			catch (Exception ex)
			{
				bCancelar_Click(sender, e);
				MessageBox.Show("Não existe funcionário com esse código!");
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
	}
}
