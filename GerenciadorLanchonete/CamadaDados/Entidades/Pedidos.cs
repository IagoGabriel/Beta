using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados.Entidades
{
    public class Pedidos
    {
        private int pedidoId;
        private int clienteId;
        private int funcionarioId;
        private int entregaId;
        private float valorTotal;
        private float valorPago;
        private String formaPagamento;
        private DateTime data;
        private float desconto;
        private String status;
        private int cancelado;


        public Pedidos()
        {
            this.pedidoId = 0;
            this.clienteId = 0;
            this.funcionarioId = 0;
            this.entregaId = 0;
            this.valorTotal = 0;
            this.valorPago = 0;
            this.formaPagamento = "";
            this.data = DateTime.Now;
            this.desconto = 0;
            this.status = "";
            this.cancelado = 0;
        }

        public Pedidos(int pedidoId, int clienteId, int funcionarioId, int entregaId, float valorTotal, float valorPago, String formaPagamento, DateTime data ,float desconto, String status, int cancelado )
        {
            this.pedidoId = pedidoId;
            this.clienteId = clienteId;
            this.funcionarioId = funcionarioId;
            this.entregaId = entregaId;
            this.valorTotal = valorTotal;
            this.valorPago = valorPago;
            this.formaPagamento = formaPagamento;
            this.data = data;
            this.desconto = desconto;
            this.status = status;
            this.cancelado = cancelado;
        }

        

        public int getPedidoId()
        {
            return this.pedidoId;
        }

        public void setPedidoId(int pedidoId)
        {
            this.pedidoId = pedidoId;
        }

          public int getClienteId()
        {
            return this.clienteId;
        }

        public void setClienteId(int clienteId)
        {
            this.clienteId = clienteId;
        }


        public int getFuncionarioId()
        {
            return this.funcionarioId;
        }

        public void setFuncionarioId(int funcionarioId)
        {
            this.funcionarioId = funcionarioId;
        }

        public int getEntregaId()
        {
            return this.entregaId;
        }

        public void setEntregaId(int entregaId)
        {
            this.entregaId = entregaId;
        }
   

        public float getValorTotal()
        {
            return this.valorTotal;
        }

        public void setValorTotal(float valorTotal)
        {
            this.valorTotal = valorTotal;
        }

        public float getValorPago()
        {
            return this.valorPago;
        }

        public void setValorPago(float valorPago)
        {
            this.valorPago = valorPago;
        }

        public String getFormaPagamento()
        {
            return this.formaPagamento;
        }

        public void setFormaPagamento(String formaPagamento)
        {
            this.formaPagamento = formaPagamento;
        }

        public DateTime getData()
        {
            return this.data;
        }

        public void setData(DateTime data)
        {
            this.data = data;
        }

        public float getDesconto()
        {
            return this.desconto;
        }

        public void setDesconto(float desconto)
        {
            this.desconto = desconto;
        }

        public String getStatus()
        {
            return this.status;
        }

        public void setStatus(String status)
        {
            this.status = status;
        }

        public int getCancelado()
        {
            return this.cancelado;
        }

        public void setCancelado(int cancelado)
        {
            this.cancelado = cancelado;
        }
    }
}
