using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados.Entidades
{

	public class Cargos
	{
		private int cargoId;
		private String nome;
		private float salario;
		private String descricao;

		public Cargos()
		{
			this.cargoId = 0;
			this.nome = "";
			this.salario = 0;
			this.descricao = "";
		}

		public Cargos(int cargoId, String nome, float salario, String descricao)
		{
			this.cargoId = cargoId;
			this.nome = nome;
			this.salario = salario;
			this.descricao = descricao;
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

		private float getSalario()
		{
			return this.salario;
		}

		private void setSalario(float salario)
		{
			this.salario = salario;
		}

		public String getDescricao()
		{
			return this.descricao;
		}

		public void setDescricao(String descricao)
		{
			this.descricao = descricao;
		}

		private void cadastrarCargo() { }
		private void alterarCargo() { }
		private void excluirCargo() { }
		private void buscarCargo() { }
	}
}
