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
        public static Bairros Buscar(int codigo)
        {
            Bairros bairro = null;
            using (OracleCommand c = ConexaoOracle.ObterConexao().CreateCommand())
            {
                c.CommandType = System.Data.CommandType.Text;
                c.CommandText = "SELECT bairroid, nome, valor FROM bairros WHERE bairroid = :codigo";
                c.Parameters.Add("codigo", OracleType.Int32).Value = codigo;

                using (OracleDataReader leitor = c.ExecuteReader())
                {
                    if (leitor.HasRows)
                    {
                        leitor.Read();
                        int bd_bairroid = leitor.GetInt32(0);
                        String bd_nome = leitor.GetString(1);
                        float bd_valor = leitor.GetFloat(2);

                        bairro = new Bairros(bd_bairroid, bd_nome, bd_valor);
                    }
                }
            }
            return bairro;
        }

        public static int BuscaNome(String nome)
        {
            int bd_bairroid = 0;
            using (OracleCommand c = ConexaoOracle.ObterConexao().CreateCommand())
            {
                c.CommandType = System.Data.CommandType.Text;
                c.CommandText = "SELECT bairroid FROM bairros WHERE nome = :nome";
                c.Parameters.Add("nome", OracleType.VarChar).Value = nome;

                using (OracleDataReader leitor = c.ExecuteReader())
                {
                    if (leitor.HasRows)
                    {
                        leitor.Read();
                        bd_bairroid = leitor.GetInt32(0);
                    }
                }
            }
            return bd_bairroid;
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
