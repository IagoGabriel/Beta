using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados.Entidades;
using System.Data.OracleClient;

namespace CamadaDados.DAO
{
    public class ProdutoDAO
    {
        public static Produtos Buscar(int codigo)
        {
            Produtos produtos = null;
            try
            {
                using (OracleCommand c = ConexaoOracle.ObterConexao().CreateCommand())
                {
                    c.CommandType = System.Data.CommandType.Text;
                    c.CommandText = "SELECT produtoid, nome, precovenda, precocusto, status, descricao, categoriaid FROM produtos WHERE produtoid = :codigo";
                    c.Parameters.Add("codigo", OracleType.Int32).Value = codigo;

                    using (OracleDataReader leitor = c.ExecuteReader())
                    {
                        if (leitor.HasRows)
                        {
                            leitor.Read();
                            int bd_produtoid = leitor.GetInt32(0);
                            String bd_nome = leitor.GetString(1);
                            float bd_precoVenda = leitor.GetFloat(2);
                            float bd_precoCusto = leitor.GetFloat(3);
                            String bd_status = leitor.GetString(4);
                            String bd_descricao = leitor.GetString(5);
                            int bd_categoriaid = leitor.GetInt32(6);

                            produtos= new Produtos(bd_produtoid, bd_nome, bd_precoVenda, bd_precoCusto, bd_status, bd_descricao, bd_categoriaid);
                        }
                    }
                }
                return produtos;
            }
            catch (NullReferenceException e)
            {
                throw e;
            }
        }
        public static bool Inserir(Produtos produto)
        {
            try
            {
                using (OracleCommand c = ConexaoOracle.ObterConexao().CreateCommand())
                {
                    c.CommandType = System.Data.CommandType.Text;
                    c.CommandText = "INSERT into PRODUTOS values(PRODUTOS_SEQ.NEXTVAL, :categoriaid, :nome, :precovenda, :precocusto, :status, :descricao, :categoriaid)";
                    c.Parameters.Add("nome", OracleType.VarChar).Value = produto.getNome();
                    c.Parameters.Add("precovenda", OracleType.Float).Value = produto.getPrecoVenda();
                    c.Parameters.Add("precocusto", OracleType.Float).Value = produto.getPrecoCusto();
                    c.Parameters.Add("status", OracleType.VarChar).Value = produto.getStatus();
                    c.Parameters.Add("descricao", OracleType.VarChar).Value = produto.getDescricao();
                    c.Parameters.Add("categoriaid", OracleType.Int32).Value = produto.getCategoriaId();
                    c.ExecuteNonQuery();
                    return true;
                }
            }
            catch (OracleException e)
            {
                throw e;
            }
        }

        public static bool Alterar(Produtos produto)
        {
            try
            {
                using (OracleCommand c = ConexaoOracle.ObterConexao().CreateCommand())
                {
                    c.CommandType = System.Data.CommandType.Text;
                    c.CommandText = "UPDATE PRODUTOS SET  nome=:nome, precovenda=:precovenda, precocusto=:precocusto, status=:status,descricao=:descricao, categoriaid=:categoriaid WHERE produtoid = :codigo";
                    c.Parameters.Add("nome", OracleType.VarChar).Value = produto.getNome();
                    c.Parameters.Add("precovenda", OracleType.Float).Value = produto.getPrecoVenda();
                    c.Parameters.Add("precocusto", OracleType.Float).Value = produto.getPrecoCusto();
                    c.Parameters.Add("status", OracleType.VarChar).Value = produto.getStatus();
                    c.Parameters.Add("descricao", OracleType.VarChar).Value = produto.getDescricao();
                    c.Parameters.Add("categoriaid", OracleType.Int32).Value = produto.getCategoriaId();

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
