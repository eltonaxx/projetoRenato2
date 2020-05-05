using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Servico
{
    public class ClienteServico
    {
        private readonly ClienteRepositorio _clienteRepositorio;

        public ClienteServico()
        {
            _clienteRepositorio = new ClienteRepositorio();
        }

        public NotificationResult Salvar(Cliente entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.IdCliente < 0)
                    notificationResult.Add(new NotificationError("Cliente inválido."));

                if (notificationResult.IsValid)
                {

                    if (entidade.IdCliente == 0)
                        _clienteRepositorio.Adicionar(entidade);
                    else
                        _clienteRepositorio.Atualizar(entidade);

                    notificationResult.Add("Cliente cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public IEnumerable<Cliente> ListarCliente()
        {
            return _clienteRepositorio.ListarCliente();
        }

        public NotificationResult Excluir(Cliente entidade)
        {
            //_clienteRepositorio.Remover(entidade);
            //return "";

            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.IdCliente < 0)
                    notificationResult.Add(new NotificationError("Cliente inválido."));

                if (notificationResult.IsValid)
                {

                        _clienteRepositorio.Remover(entidade);

                    notificationResult.Add("Cliente Removido com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public IEnumerable<Cliente> ListarTodos()
        {
            return _clienteRepositorio.ListarTodos();
        }
    }
}
