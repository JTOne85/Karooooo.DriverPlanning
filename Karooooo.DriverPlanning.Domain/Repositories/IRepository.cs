using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karooooo.DriverPlanning.Domain.Repositories
{
    public interface IRepository<T> where T: class
    {
        Task<T?> GetByIdAsync(int id);
    }
}
