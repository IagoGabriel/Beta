using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados.Entidades;
using System.Data.OracleClient;

namespace CamadaDados.DAO
{
	public class FuncionarioDAO
	{
		public static Funcionarios Buscar(int codigo)
		{
			Funcionarios funcionarios = null;
			try
			{
				using (OracleCommand c = ConexaoOracle.ObterConexao().CreateCommand())
				{
					c.CommandType = System.Data.CommandType.Text;
					c.CommandText = "SELECT funcionarioid, cargoid, nome, bairro, estado, endereco, numero, observacao, ativo FROM funcionarios WHERE funcionarioid = :codigo";
					c.Parameters.Add("codigo", OracleType.Int32).Value = codigo;

					using (OracleDataReader leitor = c.ExecuteReader())
					{
						if (leitor.HasRows)
						{
							leitor.Read();
							int bd_funcionarioid = leitor.GetInt32(0);
							int bd_cargoid = leitor.GetInt32(1);
							String bd_nome = leitor.GetString(2);
							String bd_bairro = leitor.GetString(3);
							String bd_estado = leitor.GetString(4);
							String bd_endereco = leitor.GetString(5);
							String bd_numero = leitor.GetString(6);
							String bd_observacao = leitor.GetString(7);
							int bd_ativo = leitor.GetInt32(8);

							funcionarios = new Funcionarios(bd_funcionarioid, bd_cargoid, bd_nome, bd_bairro, bd_estado, bd_endereco, bd_numero, bd_observacao, bd_ativo);
						}
					}
				}
				return funcionarios;
			}
			catch (NullReferenceException e)
			{
				throw e;
			}
		}

		public static Funcionarios BuscaTelefone(String telefone)
		{
			Funcionarios funcionarios = null;
			try
			{
				using (OracleCommand c = ConexaoOracle.ObterConexao().CreateCommand())
				{
					c.CommandType = System.Data.CommandType.Text;
					c.CommandText = "SELECT funcionarioid, cargoid, nome, bairro, estado, endereco, numero, observacao, ativo FROM funcionarios WHERE numero = :numero";
					c.Parameters.Add("numero", OracleType.VarChar).Value = telefone;

					using (OracleDataReader leitor = c.ExecuteReader())
					{
						if (leitor.HasRows)
						{
							leitor.Read();
							int bd_funcionarioid = leitor.GetInt32(0);
							int bd_cargoid = leitor.GetInt32(1);
							String bd_nome = leitor.GetString(2);
							String bd_bairro = leitor.GetString(3);
							String bd_estado = leitor.GetString(4);
							String bd_endereco = leitor.GetString(5);
							String bd_numero = leitor.GetString(6);
							String bd_observacao = leitor.GetString(7);
							int bd_ativo = leitor.GetInt32(8);

							funcionarios = new Funcionarios(bd_funcionarioid, bd_cargoid, bd_nome, bd_bairro, bd_estado, bd_endereco, bd_numero, bd_observacao, bd_ativo);
						}
					}
				}
				return funcionarios;
			}
			catch (NullReferenceException e)
			{
				throw e;
			}
		}

		public static bool Inserir(Funcionarios funcionario)
		{
            try
            {
                using (OracleCommand c = ConexaoOracle.ObterConexao().CreateCommand())
                {
                    c.CommandType = System.Data.CommandType.Text;
                    c.CommandText = "INSERT into FUNCIONARIOS values(FUNCIONARIOS_SEQ.NEXTVAL, :cargoid, :nome, :bairro, :estado, :endereco, :numero, :observacao, :ativo)";
                    c.Parameters.Add("cargoid", OracleType.Int32).Value = funcionario.getCargoId();
                    c.Parameters.Add("bairro", OracleType.VarChar).Value = funcionario.getBairro();
                    c.Parameters.Add("nome", OracleType.VarChar).Value = funcionario.getNome();
                    c.Parameters.Add("estado", OracleType.VarChar).Value = funcionario.getEstado();
                    c.Parameters.Add("endereco", OracleType.VarChar).Value = funcionario.getEndereco();
                    c.Parameters.Add("numero", OracleType.VarChar).Value = funcionario.getNumero();
                    c.Parameters.Add("observacao", OracleType.VarChar).Value = funcionario.getObservacao();
                    c.Parameters.Add("ativo", OracleType.Int32).Value = funcionario.getAtivo();
                    c.ExecuteNonQuery();
                    return true;
                }
            }
            catch (OracleException e)
            {
                throw e;
            }
		}

		public static bool Alterar(Funcionarios funcionario)
		{
            try
            {
                using (OracleCommand c = ConexaoOracle.ObterConexao().CreateCommand())
                {
                    c.CommandType = System.Data.CommandType.Text;
                    c.CommandText = "UPDATE FUNCIONARIOS SET cargoid=:cargoid, nome=:nome, bairro=:bairro, estado=:estado, endereco=:endereco, numero=:numero, observacao=:observacao, ativo=:ativo WHERE funcionarioid = :codigo";
                    c.Parameters.Add("cargoid", OracleType.Int32).Value = funcionario.getCargoId();
                    c.Parameters.Add("nome", OracleType.VarChar).Value = funcionario.getNome();
                    c.Parameters.Add("bairro", OracleType.VarChar).Value = funcionario.getBairro();
                    c.Parameters.Add("estado", OracleType.VarChar).Value = funcionario.getEstado();
                    c.Parameters.Add("endereco", OracleType.VarChar).Value = funcionario.getEndereco();
                    c.Parameters.Add("numero", OracleType.VarChar).Value = funcionario.getNumero();
                    c.Parameters.Add("observacao", OracleType.VarChar).Value = funcionario.getObservacao();
                    c.Parameters.Add("ativo", OracleType.Int32).Value = funcionario.getAtivo();
                    c.Parameters.Add("codigo", OracleType.Int32).Value = funcionario.getFuncionarioId();

                    c.ExecuteNonQuery();
                    return true;
                }
            }
            catch (OracleException e)
            {
                throw e;
            }
		}
	}
}
