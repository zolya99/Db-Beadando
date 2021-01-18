using P001_Connection.Model.Record;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P001_Connection.Model.Manager.Interface
{
    // ez az interface a beszúrási műveletet írja elő 
    interface IInsert<T> where T : BaseRecord
    {
        bool InsertFocista(T record);
    }
}
