using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados.Interfaces
{
    interface IConexaoBD<T> : IDisposable
    {
        T ObterConexao();

        void FecharConexao();
    }
}
