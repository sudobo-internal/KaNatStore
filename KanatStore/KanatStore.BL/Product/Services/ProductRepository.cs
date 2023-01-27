using KanatStore.BLL.Generic;
using KanatStore.DAL;
using KanatStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanatStore.BLL.Product.Services
{
    public class ProductRepository : GenericRepository<ProductDetail>, IProductRespository
    {
        protected ProductRepository(KanatStoreDBContext dbContext) : base(dbContext)
        {
        }
    }
}
