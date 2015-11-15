using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados.Entidades
{
    public class Adicionais
    {
        private int adicionalId;
        private int ingredienteId;

        public Adicionais()
        {
            this.adicionalId = 0;
            this.ingredienteId = 0;
        }

        public Adicionais(int adicionalId, int ingredienteId)
        {
            this.adicionalId = adicionalId;
            this.ingredienteId = ingredienteId;
        }

        public Adicionais(int ingredienteId)
        {
            this.ingredienteId = ingredienteId;
        }

        public int getAdicionalId()
        {
            return this.adicionalId;
        }

        public void setAdicionalId(int adicionalId)
        {
            this.adicionalId = adicionalId;
        }

        public int getIngredienteId()
        {
            return this.ingredienteId;
        }

        public void setIngredinteId(int ingredienteId)
        {
            this.ingredienteId = ingredienteId;
        }


    }
}