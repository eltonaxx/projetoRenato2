using Aula09.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Aula09.Dados
{
    public class ClienteRepositorio : RepositorioBase<Cliente>
    {
        public IEnumerable<Cliente> ListarCliente()
        {
            return Contexto
                .Cliente
                .ToList();
        }
    }
}
