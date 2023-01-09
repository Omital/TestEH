using TestEH.EntityFramework;
using EntityFramework.DynamicFilters;

namespace TestEH.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly TestEHDbContext _context;

        public InitialHostDbBuilder(TestEHDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
