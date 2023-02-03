using KanatStore.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KanatStore.BLL
{
    public interface CommonRepository:IDisposable
    {
        public void Dispose();
        public void Save();

    }
}
