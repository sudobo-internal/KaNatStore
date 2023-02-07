using KanatStore.BLL.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanatStore.BLL.Product.Services
{
    public interface IProductRespository:CommonRepository
    {
        public List<ProductDto> GetAll();
        public ProductDto GetById(int id);
        public void Create(ProductDto pro);
        public bool Update(ProductDto pro);
        public bool Delete(int id);

    }
}
