using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Servico
{
    public class ComercioServico
    {
        private readonly ComercioRepositorio _comercioRepositorio;

        public ComercioServico()
        {
            _comercioRepositorio = new ComercioRepositorio();
        }

        public NotificationResult Salvar(Comercio entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.IdComercio < 0)
                    notificationResult.Add(new NotificationError("Comercio inválido."));

                if (notificationResult.IsValid)
                {

                    if (entidade.IdComercio == 0)
                        _comercioRepositorio.Adicionar(entidade);
                    else
                        _comercioRepositorio.Atualizar(entidade);

                    notificationResult.Add("Comercio cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public IEnumerable<Comercio> ListarComercio()
        {
            return _comercioRepositorio.ListarComercio();
        }

        public NotificationResult Excluir(Comercio entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (entidade.IdComercio < 0)
                    notificationResult.Add(new NotificationError("Comercio inválido."));

                if (notificationResult.IsValid)
                {

                    _comercioRepositorio.Remover(entidade);

                    notificationResult.Add("Comercio Removido com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public IEnumerable<Comercio> ListarTodos()
        {
            return _comercioRepositorio.ListarTodos();
        }
    }
}
