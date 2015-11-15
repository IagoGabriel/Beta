using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados.Entidades
{
    public class Usuarios
    {
        private int usuarioId;
        private String nome;
        private String senha;
        private int funcionarioId;


        public Usuarios()
        {
            this.usuarioId = 0;
            this.nome = "";
            this.senha = "";
            this.funcionarioId = 0;
        }

        public Usuarios(int usuarioId, String nome, String senha, int funcionarioId)
        {
            this.usuarioId = usuarioId;
            this.nome = nome;
            this.senha = senha;
            this.funcionarioId = funcionarioId;
        }
        

        public int getUsuarioId()
        {
            return this.usuarioId;
        }

        public void setUsuarioId(int usuarioId)
        {
            this.usuarioId = usuarioId;
        }

        public String getNome()
        {
            return this.nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public String getSenha()
        {
            return this.senha;
        }

        public void setSenha(String senha)
        {
            this.senha = senha;
        }

        public int getFuncionarioId()
        {
            return this.funcionarioId;
        }

        public void setFuncionarioId(int funcionarioId)
        {
            this.funcionarioId = funcionarioId;
        }

    }
}