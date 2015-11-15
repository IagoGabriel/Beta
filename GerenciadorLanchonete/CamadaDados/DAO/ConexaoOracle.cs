using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CamadaDados.Interfaces;
using System.Data.OracleClient;

namespace CamadaDados.DAO
{
    public class ConexaoOracle
    {
        private static OracleConnection _conn;

        public ConexaoOracle()
        {
            string strConn = "Data Source=(DESCRIPTION="
                           + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=pi-1.csbvpjs9e63b.sa-east-1.rds.amazonaws.com)(PORT=1521)))"
                           + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=orcl)));"
                           + "User Id=" + Session.CreateSession.getUsuario() + ";Password=" + Session.CreateSession.getSenha()+ ";";
            _conn = new OracleConnection(strConn);
        }

        public static  OracleConnection ObterConexao()
        {
            if (_conn.State == System.Data.ConnectionState.Closed)
            {
                _conn.Open();
            }
            return _conn;
        
        }

        public static void FecharConexao()
        {
            if (_conn.State == System.Data.ConnectionState.Open)
            {
                _conn.Close();
            }
        }

        public static void Dispose()
        {
            FecharConexao();
        }
    }
}
