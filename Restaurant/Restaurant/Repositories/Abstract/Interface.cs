using Restaurant.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Repositories.Abstract
{
    public interface IProductsRepository: IDbRepository<Product>
    {
    }
}
