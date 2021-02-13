using System;
using System.Threading.Tasks;

namespace TechStore.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
