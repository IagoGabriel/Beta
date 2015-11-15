using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados.Entidades
{
    public class Comida_Ingrediente
    {
        private int comida_ingredienteId;
        private int ingredienteId;
        private int quantidade;
        private float produtoId;



        public Comida_Ingrediente()
        {
            this.comida_ingredienteId = 0;
            this.ingredienteId = 0;
            this.quantidade = 0;
            this.produtoId = 0;
        }

        public Comida_Ingrediente(int comida_ingredienteId, int ingredienteId, int quantidade, float produtoId)
        {
            this.comida_ingredienteId = comida_ingredienteId;
            this.ingredienteId = ingredienteId;
            this.quantidade = quantidade;
            this.produtoId = produtoId;
        }


        public int getComida_ingredienteId()
        {
            return this.comida_ingredienteId;
        }

        public void setComida_ingredienteId(int comida_ingredienteId)
        {
            this.comida_ingredienteId = comida_ingredienteId;
        }

        public int getIngredienteId()
        {
            return this.ingredienteId;
        }

        public void setIngredienteId(int ingredienteId)
        {
            this.ingredienteId = ingredienteId;
        }


        public int getQuantidade()
        {
            return this.quantidade;
        }

        public void setQuantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }

        
        public float getProdutoId()
        {
            return this.produtoId;
        }

        public void setProdutoId(float produtoId)
        {
            this.produtoId = produtoId;
        }
    }
}
