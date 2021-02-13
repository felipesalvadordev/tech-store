using System;
using System.Collections.Generic;
using System.Text;
using TechStore.Core.DomainObjects;

namespace TechStore.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
