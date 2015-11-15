using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados.Entidades
{
	public class Funcionarios
	{
		private int funcionarioId;
		private int cargoId;
		private String nome;
		private String bairro;
		private String estado;
		private String endereco;
		private String numero;
		private String observacao;
		private int ativo;

		public Funcionarios()
		{
			this.funcionarioId = 0;
			this.cargoId = 0;
			this.nome = "";
			this.bairro = "";
			this.estado = "";
			this.endereco = "";
			this.numero = "";
			this.observacao = "";
			this.ativo = 1;			
		}

		public Funcionarios(int funcionarioId, int cargoId, String nome, String bairro, String estado, String endereco, String numero, String observacao, int ativo)
		{
			this.funcionarioId = funcionarioId;
			this.cargoId = cargoId;
			this.nome = nome;    
			this.bairro = bairro;
			this.estado = estado;
			this.endereco = endereco;
			this.numero = numero;
			this.numero = numero;
			this.observacao = observacao;this
		}

		public int getFuncionarioId()
		{
			return this.funcionarioId;
		}

		public void setFuncionarioId(int funcionarioId)
		{
			this.funcionarioId = funcionarioId;
		}

		public int getCargoId()
		{
			return this.cargoId;
		}

		public void setCargoId(int cargoId)
		{
			this.cargoId = cargoId;
		}

		public String getNome()
		{
			return this.nome;
		}

		public void setNome(String nome)
		{
			this.nome = nome;
		}

		public String getBairro()
		{
			return this.bairro;
		}

		public void setBairro(String bairro)
		{
			this.bairro = bairro;
		}

		public String getEstado()
		{
			return this.estado;
		}

		public void setEstado(String estado)
		{
			this.estado = estado;
		}

		public String getEndereco()
		{
			return this.endereco;
		}

		public void setEndereco(String endereco)
		{
			this.endereco = endereco;
		}

		public String getNumero()
		{
			return this.numero;
		}

		public void setNumero(String numero)
		{
			this.numero = numero;
		}

		public String getObservacao()
		{
			return this.observacao;
		}

		public void setObservacao(String observacao)
		{
			this.observacao = observacao;
		}

		public int getAtivo()
		{
			return this.ativo;
		}

		public void setAtivo(int ativo)
		{
			this.ativo = ativo;
		}

		private void cadastrarFuncionario() { }
		private void alterarFuncionario() { }
		private void excluirFuncionario() { }
		private void buscarFuncionario() { }
	}
}
