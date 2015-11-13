using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados.Session
{
    public class CreateSession
    {
        private static String usuario;
        private static String senha;

        public static void setUsuario(String user)
        {
            usuario = user;
        }
        public static String getUsuario()
        {
            return usuario;
        }
        public static void setSenha(String passwd)
        {
            senha = passwd;
        }
        public static String getSenha()
        {
            return senha;
        }

    }
}
