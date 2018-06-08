using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Repositories
{
    public interface IDbRepository<T>
        where T: class, IDbEntity
    {
    }
}
