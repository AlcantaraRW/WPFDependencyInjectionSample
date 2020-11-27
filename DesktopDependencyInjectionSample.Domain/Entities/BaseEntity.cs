using System;

namespace DesktopDependencyInjectionSample.Domain.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; protected set; }

        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
