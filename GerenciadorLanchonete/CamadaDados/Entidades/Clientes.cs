using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados.Entidades
{
    public class Clientes
    {
        private int clienteId;
        private String nome;
        private int bairroId;
        private String numero;
        private String endereco;
        private String estado;
        private String observacao;
		private int ativo;

        public Clientes()
        {
            this.clienteId = 0;
            this.nome = "";
            this.bairroId = 0;
            this.numero = "";
            this.endereco = "";
            this.estado = "";
            this.observacao = "";
			this.ativo = 1;
        }

        public Clientes(int clienteId, String nome, int bairroId, String numero, String endereco, String estado, String observacao, int ativo)
        {
            this.clienteId = clienteId;
            this.nome = nome;
            this.bairroId = bairroId;
            this.numero = numero;
            this.endereco = endereco;
            this.estado = estado;
            this.observacao = observacao;
			this.ativo = ativo;
        }

        public Clientes(String nome, int bairroId, String numero, String endereco, String estado, String observacao, int ativo)
        {
            this.nome = nome;
            this.bairroId = bairroId;
            this.numero = numero;
            this.endereco = endereco;
            this.estado = estado;
            this.observacao = observacao;
            this.ativo = ativo;
        }

        public int getClienteId()
        {
            return this.clienteId;
        }

        public void setClienteId(int clienteId)
        {
            this.clienteId = clienteId;
        }

        public String getNome()
        {
            return this.nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public int getBairroId()
        {
            return bairroId;
        }

        public void setBairroId(int bairroId)
        {
            this.bairroId = bairroId;
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

		public int getAtivo()
		{
			return this.ativo;
		}

		public void setAtivo(int ativo)
		{
			this.ativo = ativo;
		}
	}
}
