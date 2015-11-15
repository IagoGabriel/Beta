using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados.Entidades;
using System.Data.OracleClient;

namespace CamadaDados.DAO
{
    public class CategoriaDAO
    {
        public static List<String> BuscaTodos()
        {
            List<String> categorias = new List<String>();
            using (OracleCommand c = ConexaoOracle.ObterConexao().CreateCommand())
            {
                c.CommandType = System.Data.CommandType.Text;
                c.CommandText = "SELECT nome  FROM categorias";

                using (OracleDataReader leitor = c.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        String bd_nome = leitor.GetString(0);
                        categorias.Add(bd_nome);
                    }
                }
            }
            return categorias;
        }

        public static Categorias Buscar(int codigo)
        {
            Categorias categoria = null;
            using (OracleCommand c = ConexaoOracle.ObterConexao().CreateCommand())
            {
                c.CommandType = System.Data.CommandType.Text;
                c.CommandText = "SELECT categoriaid, nome, descricao FROM categorias WHERE categoriaid = :codigo";
                c.Parameters.Add("codigo", OracleType.Int32).Value = codigo;

                using (OracleDataReader leitor = c.ExecuteReader())
                {
                    if (leitor.HasRows)
                    {
                        leitor.Read();
                        int bd_categoriaid = leitor.GetInt32(0);
                        String bd_nome = leitor.GetString(1);
                        String bd_descricao = leitor.GetString(2);

                        categoria = new Categorias(bd_categoriaid, bd_nome, bd_descricao);
                    }
                }
            }
            return categoria;
        }

        public static int BuscaNome(String nome)
        {
            int bd_categoriaid = 0;
            using (OracleCommand c = ConexaoOracle.ObterConexao().CreateCommand())
            {
                c.CommandType = System.Data.CommandType.Text;
                c.CommandText = "SELECT categoriaid FROM categorias WHERE nome = :nome";
                c.Parameters.Add("nome", OracleType.VarChar).Value = nome;

                using (OracleDataReader leitor = c.ExecuteReader())
                {
                    if (leitor.HasRows)
                    {
                        leitor.Read();
                        bd_categoriaid = leitor.GetInt32(0);
                    }
                }
            }
            return bd_categoriaid;
        }

    }
}
