using KanatStore.BLL.Product.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanatStore.BLL.UoW
{
    public interface IUnitOfWork:IDisposable
    {
        IProductRespository Product { get; }
        int Save();
    }
}
