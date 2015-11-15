using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados.Entidades
{
    public class Categorias
    {
        private int categoriaId;
        private String nome;
        private String descricao;


        public Categorias()
        {
            this.categoriaId = 0;
            this.nome = "";
            this.descricao = "";
        }

        public Categorias(int categoriaId, String nome, String descricao)
        {
            this.categoriaId = categoriaId;
            this.nome = nome;
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

        public String getNome()
        {
            return this.nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
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

