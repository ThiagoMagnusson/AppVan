using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.DAL.Repositorios.Base
{
    interface IRepositorio<TEntity> where TEntity : class
    {
        IQueryable<TEntity> PesquisarTodos();
        IQueryable<TEntity> Pesquisar(Func<TEntity, bool> predicate);
        TEntity Find(params object[] key);
        void Atualizar(TEntity obj);
        void SalvarTodos();
        void Adicionar(TEntity obj);
        void Excluir(Func<TEntity, bool> predicate);
    }
}

