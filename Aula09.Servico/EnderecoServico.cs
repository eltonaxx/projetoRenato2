using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;
using System;
using System.Collections.Generic;

namespace Aula09.Servico
{
    public class EnderecoServico
    {
        private readonly EnderecoRepositorio _enderecoRepositorio;

        public EnderecoServico()
        {
            _enderecoRepositorio = new EnderecoRepositorio();
        }

        public NotificationResult Salvar(Endereco entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.IdEndereco < 0)
                    notificationResult.Add(new NotificationError("Endereco inválido."));

                if (notificationResult.IsValid)
                {

                    if (entidade.IdEndereco == 0)
                        _enderecoRepositorio.Adicionar(entidade);
                    else
                        _enderecoRepositorio.Atualizar(entidade);

                    notificationResult.Add("Endereco cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public IEnumerable<Endereco> ListarEndereco()
        {
            return _enderecoRepositorio.ListarEndereco();
        }

        public NotificationResult Excluir(Endereco entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.IdEndereco < 0)
                    notificationResult.Add(new NotificationError("Endereco inválido."));

                if (notificationResult.IsValid)
                {

                    _enderecoRepositorio.Remover(entidade);

                    notificationResult.Add("Endereco Removido com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public IEnumerable<Endereco> ListarTodos()
        {
            return _enderecoRepositorio.ListarTodos();
        }
    }
}

