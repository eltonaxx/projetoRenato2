using Aula09.Comum.NotificationPattern;
using Aula09.Dominio;
using Aula09.Servico;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Aula09.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnderecoController
    {
        private readonly EnderecoServico enderecoServico;

        public EnderecoController()
        {
            enderecoServico = new EnderecoServico();
        }

        [HttpGet("Endereco")]
        public IEnumerable<Endereco> Ativos() => enderecoServico.ListarEndereco();

        //[HttpGet("sem-estoque")]
        //public IEnumerable<Cliente> ListarTodosComEstoqueZerado()
        //{
        //    return clienteServico.ListarTodosComEstoqueZerado();
        //}

        [HttpPost("Salvar")]
        public NotificationResult Salvar(Endereco entidade)
        {
            return enderecoServico.Salvar(entidade);
        }

        [HttpDelete]
        public NotificationResult Excluir(Endereco entidade)
        {
            return enderecoServico.Excluir(entidade);
        }
    }
}
