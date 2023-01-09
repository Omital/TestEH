using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace TestEH.EntityFramework.Repositories
{
    public abstract class TestEHRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TestEHDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TestEHRepositoryBase(IDbContextProvider<TestEHDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class TestEHRepositoryBase<TEntity> : TestEHRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TestEHRepositoryBase(IDbContextProvider<TestEHDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
