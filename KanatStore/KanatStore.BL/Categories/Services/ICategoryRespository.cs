using KanatStore.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanatStore.BLL.Categories.Services
{
    public interface ICategoryRespository
    {
        public List<Category> GetAll();
    }
}
