using KanatStore.BLL.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KanatStore.DAL.Entities;

namespace KanatStore.BLL.Product.Services
{
    public interface IProductRespository
    {
        public List<ProductDetail> GetAll();
    }
}
