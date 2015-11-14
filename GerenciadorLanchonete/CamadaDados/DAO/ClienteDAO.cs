using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados.Entidades;
using System.Data.OracleClient;

namespace CamadaDados.DAO
{
    public class ClienteDAO
    {
        public static Clientes Buscar(int codigo)
        {
            Clientes cliente = null;
            try
            {
                using (OracleCommand c = ConexaoOracle.ObterConexao().CreateCommand())
                {
                    c.CommandType = System.Data.CommandType.Text;
                    c.CommandText = "SELECT clienteid, bairroid, nome, estado, endereco, numero, observacao, ativo FROM clientes WHERE clienteid = :codigo";
                    c.Parameters.Add("codigo", OracleType.Int32).Value = codigo;

                    using (OracleDataReader leitor = c.ExecuteReader())
                    {
                        if (leitor.HasRows)
                        {
                            leitor.Read();
                            int bd_clienteid = leitor.GetInt32(0);
                            int bd_bairroid = leitor.GetInt32(1);
                            String bd_cliente = leitor.GetString(2);
                            String bd_estado = leitor.GetString(3);
                            String bd_endereco = leitor.GetString(4);
                            int bd_numero = leitor.GetInt32(5);
                            String bd_observacao = leitor.GetString(6);
							int bd_ativo = leitor.GetInt32(7);

							cliente = new Clientes(bd_clienteid, bd_cliente, bd_bairroid, bd_numero, bd_endereco, bd_estado, bd_observacao, bd_ativo);
                        }
                    }
                }
                return cliente;
            }
            catch (NullReferenceException e)
            {
                throw e;
            }
        }

		public static Clientes BuscaTelefone(int telefone)
		{
			Clientes cliente = null;
			try
			{
				using (OracleCommand c = ConexaoOracle.ObterConexao().CreateCommand())
				{
					c.CommandType = System.Data.CommandType.Text;
					c.CommandText = "SELECT clienteid, bairroid, nome, estado, endereco, numero, observacao, ativo FROM clientes WHERE numero = :numero";
					c.Parameters.Add("numero", OracleType.Int32).Value = telefone;

					using (OracleDataReader leitor = c.ExecuteReader())
					{
						if (leitor.HasRows)
						{
							leitor.Read();
							int bd_clienteid = leitor.GetInt32(0);
							int bd_bairroid = leitor.GetInt32(1);
							String bd_cliente = leitor.GetString(2);
							String bd_estado = leitor.GetString(3);
							String bd_endereco = leitor.GetString(4);
							int bd_numero = leitor.GetInt32(5);
							String bd_observacao = leitor.GetString(6);
							int bd_ativo = leitor.GetInt32(7);

							cliente = new Clientes(bd_clienteid, bd_cliente, bd_bairroid, bd_numero, bd_endereco, bd_estado, bd_observacao, bd_ativo);
						}
					}
				}
				return cliente;
			}
			catch (NullReferenceException e)
			{
				throw e;
			}
		}

		public static bool Alterar(Clientes cliente)
        {
            using (OracleCommand c = ConexaoOracle.ObterConexao().CreateCommand())
            {
                c.CommandType = System.Data.CommandType.Text;
                c.CommandText = "UPDATE clientes SET bairroid=:bairroid, nome=:nome, estado=:estado, endereco=:endereco, numero=:numero, observacao=:observacao, ativo=:ativo WHERE clienteid = :codigo";
                c.Parameters.Add("bairroid", OracleType.Int32).Value = cliente.getBairroId();
                c.Parameters.Add("nome", OracleType.VarChar).Value = cliente.getNome();
                c.Parameters.Add("estado", OracleType.VarChar).Value = cliente.getEstado();
                c.Parameters.Add("endereco", OracleType.VarChar).Value = cliente.getEndereco();
                c.Parameters.Add("numero", OracleType.VarChar).Value = cliente.getNumero();
                c.Parameters.Add("observacao", OracleType.VarChar).Value = cliente.getObservacao();
                c.Parameters.Add("codigo", OracleType.Int32).Value = cliente.getClienteId();
				c.Parameters.Add("ativo", OracleType.Int32).Value = cliente.getAtivo();

				c.ExecuteNonQuery();
                return true;
            }
        }

    }
}
