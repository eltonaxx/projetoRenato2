using Aula09.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Aula09.Dados
{
    public class ComercioRepositorio : RepositorioBase<Comercio>
    {
        public IEnumerable<Comercio> ListarComercio()
        {
            return Contexto
                .Comercio
                .ToList();
        }
    }
}
