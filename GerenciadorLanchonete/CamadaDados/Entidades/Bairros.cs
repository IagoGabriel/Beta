using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados.Entidades
{
    public class Bairros
    {
        private int bairroId;
        private String nome;
        private float valor;

        public Bairros()
        {
            this.bairroId = 0;
            this.nome = "";
            this.valor = 0;
        }

        public Bairros(int bairroId, String nome, float valor)
        {
            this.bairroId = bairroId;
            this.nome = nome;
            this.valor = valor;
        }

        public int getBairroId()
        {
            return bairroId;
        }

        public void setBairroId(int bairroId)
        {
            this.bairroId = bairroId;
        }

        public String getNome()
        {
            return this.nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public float getValor()
        {
            return this.valor;
        }

        public void setValor(float valor)
        {
            this.valor = valor;
        }

        private void cadastrarBairro() { }
        private void alterarBairro() { }
        private void excluirBairro() { }
        private void buscarBairro() { }
    }
}
