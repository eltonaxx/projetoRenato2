using Aula09.Comum.NotificationPattern;
using Aula09.Dominio;
using Aula09.Servico;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Aula09.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComercioController
    {
        private readonly ComercioServico comercioServico;

        public ComercioController()
        {
            comercioServico = new ComercioServico();
        }

        [HttpGet("Comercios")]
        public IEnumerable<Comercio> Ativos() => comercioServico.ListarComercio();

        //[HttpGet("sem-estoque")]
        //public IEnumerable<Cliente> ListarTodosComEstoqueZerado()
        //{
        //    return clienteServico.ListarTodosComEstoqueZerado();
        //}

        [HttpPost("Salvar")]
        public NotificationResult Salvar(Comercio entidade)
        {
            return comercioServico.Salvar(entidade);
        }

        [HttpDelete]
        public NotificationResult Excluir(Comercio entidade)
        {
            return comercioServico.Excluir(entidade);
        }
    }
}
