using LogicClassLibrary.Interface.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Interface.Manager
{
    public interface IPaginatorManager
    {
        IPaginator<T> GetPaginator<T>();
        void UpdatePageSize(int pageSize);
    }
}
