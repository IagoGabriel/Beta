using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados.Entidades
{
    public class Entregas
    {
        private int entregaId;
        private int funcionarioId;
        private string status;
        private DateTime data;


        public Entregas()
        {
            this.entregaId = 0;
            this.funcionarioId = 0;
            this.status = "";
            this.data = DateTime.Now;
        }

        public Entregas(int entregaId, int funcionarioId, String status, DateTime data)
        {
            this.entregaId = entregaId;
            this.funcionarioId = funcionarioId;
            this.status = status;
            this.data = data;

        }

        

        public int getEntregaId()
        {
            return this.entregaId;
        }

        public void setEntregaId(int entregaId)
        {
            this.entregaId = entregaId;
        }

        public int getFuncionarioId()
        {
            return this.funcionarioId;
        }

        public void setFuncionarioId(int funcionarioId)
        {
            this.funcionarioId = funcionarioId;
        }
        
        public String getStatus()
        {
            return this.status;
        }

        public void setStatus(String status)
        {
            this.status = status;
        }

         public DateTime getData()
        {
            return this.data;
        }

        public void setData(DateTime data)
        {
            this.data = data;
        }
    }
}

