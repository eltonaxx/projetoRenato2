using Aula09.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Aula09.Dados
{
    public class EnderecoRepositorio : RepositorioBase<Endereco>
    {
        public IEnumerable<Endereco> ListarEndereco()
        {
            return Contexto
                .Endereco
                .ToList();
        }
    }
}
