using DesktopDependencyInjectionSample.Domain.Entities;
using DesktopDependencyInjectionSample.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesktopDependencyInjectionSample.Infra.Repositories
{
    class Repository<TEntity> : IRepository<TEntity> where TEntity is BaseEntity
    {
    }
}
