using Aula09.Comum.NotificationPattern;
using Aula09.Dominio;
using Aula09.Servico;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Aula09.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteServico clienteServico;

        public ClienteController()
        {
            clienteServico = new ClienteServico();
        }

        [HttpGet("Usuario")]
        public IEnumerable<Cliente> Ativos() => clienteServico.ListarCliente();

        //[HttpGet("sem-estoque")]
        //public IEnumerable<Cliente> ListarTodosComEstoqueZerado()
        //{
        //    return clienteServico.ListarTodosComEstoqueZerado();
        //}

        [HttpPost("Salvar")]
        public NotificationResult Salvar(Cliente entidade)
        {
            return clienteServico.Salvar(entidade);
        }

        [HttpDelete]
        public NotificationResult Excluir(Cliente entidade)
        {
            return clienteServico.Excluir(entidade);
        }
    }
}
