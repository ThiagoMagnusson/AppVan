using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Banco.Entidades;

namespace Banco.DAL.Repositorios.Base
{
    public abstract class Repositorio<TEntity> : IDisposable,
        IRepositorio<TEntity> where TEntity : EntidadeBase
    {
        BancoContexto ctx = new BancoContexto();
        public void Adicionar(TEntity obj)
        {
            ctx.Set<TEntity>().Add(obj);
        }

        public void Atualizar(TEntity obj)
        {
            ctx.Entry(obj).State = EntityState.Modified;
        }

        public void Dispose()
        {
            ctx.Dispose();            
        }

        public void Excluir(Func<TEntity, bool> predicate)
        {
            ctx.Set<TEntity>()
                .Where(predicate).ToList()
                .ForEach(del => ctx.Set<TEntity>().Remove(del));
        }

        public TEntity Find(params object[] key)
        {
            return ctx.Set<TEntity>().Find(key);
        }

        public IQueryable<TEntity> Pesquisar(Func<TEntity, bool> predicate)
        {
            return PesquisarTodos().Where(predicate).AsQueryable();
        }

        public IQueryable<TEntity> PesquisarTodos()
        {
            return ctx.Set<TEntity>();
        }

        public void SalvarTodos()
        {
            ctx.SaveChanges();
        }

        public TEntity BuscarPorId(int id)
        {
            return Pesquisar(p => p.Id == id).FirstOrDefault();
        }
    }
}
