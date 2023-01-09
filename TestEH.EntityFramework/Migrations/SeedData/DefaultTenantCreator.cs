using System.Linq;
using TestEH.EntityFramework;
using TestEH.MultiTenancy;

namespace TestEH.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly TestEHDbContext _context;

        public DefaultTenantCreator(TestEHDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
