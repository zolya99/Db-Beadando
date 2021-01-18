using P001_Connection.Model.Record;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P001_Connection.Model.Manager.Interface
{
    interface ISelect<T> where T : BaseRecord
    {
        List<T> GetListFocista();
        T GetOneFocista(T record);
    }
}
