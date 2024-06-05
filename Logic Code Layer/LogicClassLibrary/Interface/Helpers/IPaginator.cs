using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicClassLibrary.Interface.Helpers
{
    public interface IPaginator<T>
    {
        int CurrentPage { get; }
        int PageSize { get; set; }
        List<T> LoadPage(int pageNumber);
        List<T> NextPage();
        List<T> PreviousPage();
    }
}
