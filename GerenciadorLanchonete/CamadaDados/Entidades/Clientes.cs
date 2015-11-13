﻿using System;
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
        private int numero;
        private String endereco;
        private String estado;
        private String observacao;

        public Clientes()
        {
            this.clienteId = 0;
            this.nome = "";
            this.bairroId = 0;
            this.numero = 0;
            this.endereco = "";
            this.estado = "";
            this.observacao = "";
        }

        public Clientes(int clienteId, String nome, int bairroId, int numero, String endereco, String estado, String observacao)
        {
            this.clienteId = clienteId;
            this.nome = nome;
            this.bairroId = bairroId;
            this.numero = numero;
            this.endereco = endereco;
            this.estado = estado;
            this.observacao = observacao;
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

        public int getNumero()
        {
            return this.numero;
        }

        public void setNumero(int numero)
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
    }
}
