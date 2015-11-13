using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados.Interfaces;
using CamadaDados.Entidades;
using System.Data.OracleClient;

namespace CamadaDados.DAO
{
    public class BairroDAO
    {
        //private static ConexaoOracle _conn = new ConexaoOracle();
        public static void Buscar()
        {
            
        }

        public static List<String> BuscaTodos()
        {
            List<String> bairros = new List<String>();
            using (OracleCommand c = ConexaoOracle.ObterConexao().CreateCommand())
            {
                c.CommandType = System.Data.CommandType.Text;
                c.CommandText = "select nome from bairros";

                using (OracleDataReader leitor = c.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        String bd_nome = leitor.GetString(0);
                        bairros.Add(bd_nome);
                    }
                }
            }
            return bairros;
        }

    }
}
