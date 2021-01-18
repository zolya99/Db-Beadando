using P001_Connection.Model.Record;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P001_Connection.Model.Manager.Interface
{
    interface IDelete<T> where T : BaseRecord
    {
        bool DeleteFocista(T record); // törli a T típusú rekordot 
    }
}
