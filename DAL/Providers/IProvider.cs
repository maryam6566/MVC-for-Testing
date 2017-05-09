using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Providers
{
    interface IProvider < T,TPK>
    {
        bool Add(T pItem5Add);
        System.Collections.Generic.List<T> Get_All_Items();
        bool Delete(TPK pKey5delete);

    }
}
