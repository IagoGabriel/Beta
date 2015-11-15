using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados.Entidades
{
    public class Adicional_Comida
    {
        private int adicional_comidaId;
        private int quantidade;
        private int adicionalId;
        private float valor;



        public Adicional_Comida()
        {
            this.adicional_comidaId = 0;
            this.quantidade = 0;
            this.adicionalId = 0;
            this.valor = 0;
        }

        public Adicional_Comida(int adicional_comidaId, int quantidade, int adicionalId, float valor)
        {
            this.adicional_comidaId = adicional_comidaId;
            this.quantidade = quantidade;
            this.adicionalId = adicionalId;
            this.valor = valor;
        }


        public int getAdicional_comidaId()
        {
            return this.adicional_comidaId;
        }

        public void setAdicional_comidaId(int adicional_comidaId)
        {
            this.adicional_comidaId = adicional_comidaId;
        }


        public int getQuantidade()
        {
            return this.quantidade;
        }

        public void setQuantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }


        public int getAdicionalId()
        {
            return this.adicionalId;
        }

        public void setAdicionalId(int adicionalId)
        {
            this.adicionalId = adicionalId;
        }


        public float getValor()
        {
            return this.valor;
        }

        public void setValor(float valor)
        {
            this.valor = valor;
        }
    }
}
