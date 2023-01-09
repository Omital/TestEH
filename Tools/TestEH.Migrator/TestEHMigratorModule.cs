using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using TestEH.EntityFramework;

namespace TestEH.Migrator
{
    [DependsOn(typeof(TestEHDataModule))]
    public class TestEHMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<TestEHDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}