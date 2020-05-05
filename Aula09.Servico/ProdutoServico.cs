
using Aula09.Comum.NotificationPattern;
using Aula09.Dados;
using Aula09.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula09.Servico
{
    public class ProdutoServico
    {
        private readonly ProdutoRepositorio _produtoRepositorio;

        
        public ProdutoServico()
        {
            _produtoRepositorio = new ProdutoRepositorio();
        }

        public NotificationResult Salvar(Produto entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                entidade.DataCadastro = DateTime.Now;

                if (entidade.Estoque < 0) 
                    notificationResult.Add(new NotificationError("Qtde. de produtos no Estoque inválido.", NotificationErrorType.USER));

                if (entidade.PrecoCusto <= 0)
                    notificationResult.Add(new NotificationError("Preço de Custo inválido."));

                if (notificationResult.IsValid) {

                    if (entidade.idProduto == 0)
                        _produtoRepositorio.Adicionar(entidade);
                    else
                        _produtoRepositorio.Atualizar(entidade);

                    notificationResult.Add("Produto cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public IEnumerable<Produto> ListarAtivos()
        {
            return _produtoRepositorio.ListarAtivos();
        }

        public string Excluir(Produto entidade)
        {
            return "";
        }

        public IEnumerable<Produto> ListarTodos() {
            return _produtoRepositorio.ListarTodos();
        }

        public IEnumerable<Produto> ListarTodosComEstoqueZerado()
        {
            return _produtoRepositorio.ListarTodosComEstoqueZerado();
        }
    }
}
