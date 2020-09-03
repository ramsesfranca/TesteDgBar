using MinhaAplicacao.Dominio.Entidades;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace MinhaAplicacao.Dominio.Interfaces.Repositories
{
    public interface IRepositorioBase<in TId, TEntidade> : IDisposable
        where TId : IEquatable<TId>
        where TEntidade : EntidadeBase<TId>
    {
        void Inserir(TEntidade entidade);
        void Alterar(TEntidade entidade);
        void Deletar(TEntidade entidade);
        IQueryable<TEntidade> SelecionarPorId(TId id, params string[] navegacaos);
        IQueryable<TEntidade> SelecionarTodos(params string[] navegacaos);
        IQueryable<TEntidade> SelecionarPor(Expression<Func<TEntidade, bool>> predicado, params string[] navegacaos);
    }
}
