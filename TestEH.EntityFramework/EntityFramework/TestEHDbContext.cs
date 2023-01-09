using Abp.DynamicEntityProperties;
using Abp.Zero.EntityFramework;
using System.Data.Common;
using System.Data.Entity;
using TestEH.Authorization.Roles;
using TestEH.Authorization.Users;
using TestEH.MultiTenancy;
using TestEH.Peopels;

namespace TestEH.EntityFramework
{
    public class TestEHDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        public virtual IDbSet<Person> Peopels { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public TestEHDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in TestEHDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of TestEHDbContext since ABP automatically handles it.
         */
        public TestEHDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public TestEHDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public TestEHDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DynamicProperty>().Property(p => p.PropertyName).HasMaxLength(250);
            modelBuilder.Entity<DynamicEntityProperty>().Property(p => p.EntityFullName).HasMaxLength(250);
        }
    }
}
