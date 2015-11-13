using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamadaDados.Interfaces
{
    interface IDAO<Dado> : IDisposable
    {
        bool Inserir(Dado objeto);
        bool Atualizar(Dado objeto);
        bool Excluir(Dado objeto);
        Dado Buscar(string id);

        List<Dado> ObterTodos();
    }
}
