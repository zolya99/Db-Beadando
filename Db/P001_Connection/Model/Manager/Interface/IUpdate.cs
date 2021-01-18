using P001_Connection.Model.Record;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P001_Connection.Model.Manager.Interface
{
    interface IUpdate<T> where T : BaseRecord
    {
        // frissíti a recordot az id alapján, az id mező 
        // értéknek a felülírását nem engedjük meg 
        bool UpdateFocista(T record); 
    }
}
