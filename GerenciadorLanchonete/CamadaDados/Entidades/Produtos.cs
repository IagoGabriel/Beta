using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados.Entidades
{
    public class Produtos
    {
        private int produtoId;
        private String nome;
        private float precoVenda;
        private float precoCusto;
        private String status;
        private String descricao;
        private int categoriaId;

        public Produtos()
        {
            this.produtoId = 0;
            this.nome = "";
            this.precoVenda = 0;
            this.precoCusto = 0;
            this.status = "";
            this.descricao = "";
            this.categoriaId = 0;
        }

        public Produtos(int produtoId, String nome, float precoVenda, float precoCusto, String status, String descricao,  int categoriaId)
        {
            this.produtoId = produtoId;
            this.nome = nome;
            this.precoVenda = precoVenda;
            this.precoCusto = precoCusto;
            this.status = status;
            this.descricao = descricao;
            this.categoriaId = categoriaId;

        }

        public int getProdutoId()
        {
            return this.produtoId;
        }

        public void setProdutoId(int produtoId)
        {
            this.produtoId = produtoId;
        }

        public String getNome()
        {
            return this.nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }
            
        public float getPrecoVenda()
        {
            return precoVenda;
        }

        public void setPrecoVenda(float precoVenda)
        {
            this.precoVenda = precoVenda;
        }
        

        public float getPrecoCusto()
        {
            return this.precoCusto;
        }

        public void setPrecoCusto(float precoCusto)
        {
            this.precoCusto = precoCusto;
        }
        
           
        public String getStatus()
        {
            return this.status;
        }

        public void setStatus(String status)
        {
            this.status = status;
        }
        
        public String getDescricao()
        {
            return this.descricao;
        }

        public void setDescricao(String descricao)
        {
            this.descricao = descricao;
        }

        
        public int getCategoriaId()
        {
            return this.categoriaId;
        }

        public void setCategoriaId(int categoriaId)
        {
            this.categoriaId = categoriaId;
        }
    }
}


