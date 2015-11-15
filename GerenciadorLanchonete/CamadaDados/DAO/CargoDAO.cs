using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados.Entidades;
using System.Data.OracleClient;

namespace CamadaDados.DAO
{
	public class CargoDAO
	{
		public static List<String> BuscaTodos()
		{
			List<String> cargos = new List<String>();
			using (OracleCommand c = ConexaoOracle.ObterConexao().CreateCommand())
			{
				c.CommandType = System.Data.CommandType.Text;
				c.CommandText = "SELECT nome FROM cargos";

				using (OracleDataReader leitor = c.ExecuteReader())
				{
					while (leitor.Read())
					{
						String bd_nome = leitor.GetString(0);
						cargos.Add(bd_nome);
					}
				}
			}
			return cargos;
		}

		public static Cargos Buscar(int codigo)
		{
			Cargos cargo = null;
			using (OracleCommand c = ConexaoOracle.ObterConexao().CreateCommand())
			{
				c.CommandType = System.Data.CommandType.Text;
				c.CommandText = "SELECT cargoid, nome, salario, descricao FROM cargos WHERE cargoid = :codigo";
				c.Parameters.Add("codigo", OracleType.Int32).Value = codigo;

				using (OracleDataReader leitor = c.ExecuteReader())
				{
					if (leitor.HasRows)
					{
						leitor.Read();
						int bd_cargoid = leitor.GetInt32(0);
						String bd_nome = leitor.GetString(1);
						float bd_salario = leitor.GetFloat(2);
						String bd_descricao = leitor.GetString(3);

						cargo = new Cargos(bd_cargoid, bd_nome, bd_salario, bd_descricao);
					}
				}
			}
			return cargo;
		}

        public static int BuscaNome(String nome)
        {
            int bd_cargoid = 0;
            using (OracleCommand c = ConexaoOracle.ObterConexao().CreateCommand())
            {
                c.CommandType = System.Data.CommandType.Text;
                c.CommandText = "SELECT cargoid FROM cargos WHERE nome = :nome";
                c.Parameters.Add("nome", OracleType.VarChar).Value = nome;

                using (OracleDataReader leitor = c.ExecuteReader())
                {
                    if (leitor.HasRows)
                    {
                        leitor.Read();
                        bd_cargoid = leitor.GetInt32(0);
                    }
                }
            }
            return bd_cargoid;
        }

	}
}
