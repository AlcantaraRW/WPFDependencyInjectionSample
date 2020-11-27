using DesktopDependencyInjectionSample.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DesktopDependencyInjectionSample.Infra.Context
{
    public class SampleContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}
