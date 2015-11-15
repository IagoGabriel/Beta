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
			tbCodigo.Select();
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
            try
            {
                int checkAtivo;
                String numero = "";

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

                if (botao == 1)
                {
                    if (tbNome.Text.Equals("") || tbEndereco.Text.Equals("") || (mtbResidencial.Text.Equals("") && mtbCelular.Text.Equals("")) || cbCargo.Text.Equals("") || tbEstado.Text.Equals("") || tbBairro.Text.Equals(""))
                    {
                        MessageBox.Show("Preencha todos os campos obrigatórios: *");
                    }
                    else
                    {
                        if (cbAtivo.Checked)
                        {
                            checkAtivo = 1;
                        }
                        else
                        {
                            checkAtivo = 0;
                        }
                        if (tbObservacao.Text == "")
                        {
                            tbObservacao.Text = " ";
                        }
                        Funcionarios funcionario = new Funcionarios(CargoDAO.BuscaNome(cbCargo.Text), tbNome.Text, tbBairro.Text, tbEstado.Text, tbEndereco.Text, numero, tbObservacao.Text, checkAtivo);
                        if (FuncionarioDAO.Inserir(funcionario))
                        {
                            bCancelar_Click(sender, e);
                            MessageBox.Show("Funcionário " + funcionario.getNome() + " foi cadastrado com sucesso!");
                        }
                    }
                }

                if (botao == 2)
                {
                    if (tbCodigo.Text.Equals("") || tbNome.Text.Equals("") || tbEndereco.Text.Equals("") || (mtbResidencial.Text.Equals("") && mtbCelular.Text.Equals("")) || cbCargo.Text.Equals("") || tbEstado.Text.Equals("") || tbBairro.Text.Equals(""))
                    {
                        MessageBox.Show("Preencha todos os campos obrigatórios: *");
                    }
                    else
                    {
                        if (cbAtivo.Checked)
                        {
                            checkAtivo = 1;
                        }
                        else
                        {
                            checkAtivo = 0;
                        }
                        if (tbObservacao.Text == "")
                        {
                            tbObservacao.Text = " ";
                        }
                        Funcionarios funcionario = new Funcionarios(int.Parse(tbCodigo.Text), CargoDAO.BuscaNome(cbCargo.Text), tbNome.Text, tbBairro.Text, tbEstado.Text, tbEndereco.Text, numero, tbObservacao.Text, checkAtivo);

                        if (FuncionarioDAO.Alterar(funcionario))
                        {
                            bCancelar_Click(sender, e);
                            MessageBox.Show("Funcionário " + funcionario.getNome() + " foi alterado com sucesso!");
                        }
                    }
                }
            }catch(Exception ex){
                if (ex.Message.Contains("UniqueConstraint"))
                {
                    MessageBox.Show("Um valor único não foi informado.");
                }
                else
                {
                    MessageBox.Show("Ocorreu um erro, contate o administrador do sistema.");
                }
            }
		}
		private void bCancelar_Click(object sender, EventArgs e)
		{
			tbCodigo.Select();
			rdCelular.Checked = false;
			rdResidencial.Checked = false;
			rdCelular.Enabled = true;
			rdResidencial.Enabled = true;
			mtbCelular.Enabled = false;
			mtbResidencial.Enabled = false;

			tbCodigo.Clear();
			tbEndereco.Clear();
			tbNome.Clear();
			tbBairro.Clear();
			tbEstado.Clear();
			tbObservacao.Clear();
            cbCargo.Text = "";
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

            if ((!tbCodigo.Enabled) && botao != 1)
            {
                bCancelar_Click(sender, e);
                rdResidencial.Checked = true;
            }

        }

        private void rdCelular_CheckedChanged(object sender, EventArgs e)
        {
            mtbCelular.Enabled = true;
            mtbResidencial.Visible = false;
            mtbResidencial.Enabled = false;
            mtbCelular.Visible = true;

            if ((!tbCodigo.Enabled) && botao != 1)
            {
                bCancelar_Click(sender, e);
                rdCelular.Checked = true;
            }

        }

        private void pbLupaTelefone_Click(object sender, EventArgs e)
        {
            try
            {
                tbCodigo.Enabled = false;
                if (rdResidencial.Checked)
                {
                    if (!(mtbResidencial.Text.Equals("(  )     -")))
                    {
                        Funcionarios funcionario = FuncionarioDAO.BuscaTelefone(mtbResidencial.Text);
                        tbCodigo.Text = funcionario.getFuncionarioId().ToString();
                        tbNome.Text = funcionario.getNome();
                        tbEndereco.Text = funcionario.getEndereco();
                        cbCargo.Text = CargoDAO.Buscar(funcionario.getCargoId()).getNome();
                        tbEstado.Text = funcionario.getEstado();
                        tbBairro.Text = funcionario.getBairro();
                        tbObservacao.Text = funcionario.getObservacao();

                        int checkAtivo = funcionario.getAtivo();

                        if (checkAtivo == 1)
                        {
                            cbAtivo.Checked = true;
                        }
                        else
                        {
                            cbAtivo.Checked = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Preencha o campo do telefone: *");
                    }
                }
                else
                {
                    if (rdCelular.Checked)
                    {
                        if (!(mtbCelular.Text.Equals("(  )      -")))
                        {
                            Funcionarios funcionario = FuncionarioDAO.BuscaTelefone(mtbCelular.Text);
                            tbCodigo.Text = funcionario.getFuncionarioId().ToString();
                            tbNome.Text = funcionario.getNome();
                            tbEndereco.Text = funcionario.getEndereco();
                            cbCargo.Text = CargoDAO.Buscar(funcionario.getCargoId()).getNome();
                            tbEstado.Text = funcionario.getEstado();
                            tbObservacao.Text = funcionario.getObservacao();
                            tbBairro.Text = funcionario.getBairro();

                            int checkAtivo = funcionario.getAtivo();

                            if (checkAtivo == 1)
                            {
                                cbAtivo.Checked = true;
                            }
                            else
                            {
                                cbAtivo.Checked = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Preencha o campo do telefone: *");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecione o tipo de telefone: Residencial ou Celular.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não existe cliente com esse telefone!");
            }
        }

        private void tbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                pbLupaCodigo_Click(sender, e);
            }
        }

        private void mtbResidencial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                pbLupaTelefone_Click(sender, e);
            }
        }

        private void mtbCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                pbLupaTelefone_Click(sender, e);
            }
        }

        private void mtbResidencial_Click(object sender, EventArgs e)
        {
            mtbResidencial.SelectionStart = 1;
        }

        private void mtbCelular_Click(object sender, EventArgs e)
        {
            mtbCelular.SelectionStart = 1;
        }
	}
}
