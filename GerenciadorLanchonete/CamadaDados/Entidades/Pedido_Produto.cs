using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados.Entidades
{
    public class Pedido_Produto
    {
        private int pedido_produtoId;
        private int produtoId;
        private float valor;
        private int quantidade;
        private int pedidoId;
        private int adicional_comidaId;



        public Pedido_Produto()
        {
            this.pedido_produtoId = 0;
            this.produtoId = 0;
            this.valor = 0;
            this.quantidade = 0;
            this.pedidoId = 0;
            this.adicional_comidaId = 0;
        }

        public Pedido_Produto(int pedido_produtoId, int produtoId, float valor, int quantidade, int pedidoId, int adicional_comidaId)
        {
            this.pedido_produtoId = pedido_produtoId;
            this.produtoId = produtoId;
            this.valor = valor;
            this.quantidade = quantidade;
            this.pedidoId = pedidoId;
            this.adicional_comidaId = adicional_comidaId;
        }

        public Pedido_Produto( int produtoId, float valor, int quantidade, int pedidoId, int adicional_comidaId)
        {
            this.produtoId = produtoId;
            this.valor = valor;
            this.quantidade = quantidade;
            this.pedidoId = pedidoId;
            this.adicional_comidaId = adicional_comidaId;
        }


        public int getPedido_produtoId()
        {
            return this.pedido_produtoId;
        }

        public void setPedido_produtoId(int pedido_produtoId)
        {
            this.pedido_produtoId = pedido_produtoId;
        }

        public int getProdutoId()
        {
            return this.produtoId;
        }

        public void setProdutoId(int produtoId)
        {
            this.produtoId = produtoId;
        }

        public float getValor()
        {
            return this.valor;
        }

        public void setValor(float valor)
        {
            this.valor = valor;
        }

        public int getQuantidade()
        {
            return this.quantidade;
        }

        public void setQuantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }

        public int getPedidoId()
        {
            return this.pedidoId;
        }

        public void setPedidoId(int pedidoId)
        {
            this.pedidoId = pedidoId;
        }

        public int getAdicional_comidaId()
        {
            return this.adicional_comidaId;
        }
      
        public void setAdicional_comidaId(int adicional_comidaId)
        {
            this.adicional_comidaId = adicional_comidaId;
        }
    }
}