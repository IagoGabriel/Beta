﻿using System;
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
            using (OracleCommand c = ConexaoOracle.ObterConexao().CreateCommand())
            {
                c.CommandType = System.Data.CommandType.Text;
                c.CommandText = "SELECT clienteid, bairroid, nome, estado, endereco, numero, observacao FROM clientes WHERE clienteid = :codigo";
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

                        cliente = new Clientes(bd_clienteid, bd_cliente, bd_bairroid, bd_numero, bd_endereco, bd_estado, bd_observacao);
                    }
                }
            }
            return cliente;
        }
    }
}
