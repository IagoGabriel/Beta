using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados.Entidades
{
    public class Ingredientes
    {
        private int ingredienteId;
        private float preco;
        private string nome;
        private int estoque;
        private int ativo;
        private string descricao;


        public Ingredientes()
        {
            this.ingredienteId = 0;
            this.preco = 0;
            this.nome = "";
            this.estoque = 0;
            this.ativo = 1;
            this.descricao = "";
        }

        public Ingredientes(int ingredienteId, float preco, String nome, int estoque, int ativo, String descricao)
        {
            this.ingredienteId = ingredienteId;
            this.preco = preco;
            this.nome = nome;
            this.estoque = estoque;
            this.ativo = ativo;
            this.descricao = descricao;


        }
        

        public int getIngredienteId()
        {
            return this.ingredienteId;
        }

        public void setIngredienteId(int ingredienteId)
        {
            this.ingredienteId = ingredienteId;
        }

        public float getPreco()
        {
            return this.preco;
        }

        public void setPreco(float preco)
        {
            this.preco = preco;
        }


        public String getNome()
        {
            return this.nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public int getEstoque()
        {
            return this.estoque;
        }

        public void setEstoque(int estoque)
        {
            this.estoque = estoque;
        }

        public int getAtivo()
        {
            return this.ativo;
        }

        public void setAtivo(int ativo)
        {
            this.ativo = ativo;
        }

        public String getDescricao()
        {
            return this.descricao;
        }

        public void setDescricao(String descricao)
        {
            this.descricao = descricao;
        }




    }
}


