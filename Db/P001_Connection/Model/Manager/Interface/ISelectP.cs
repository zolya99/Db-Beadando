using P001_Connection.Model.Record;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P001_Connection.Model.Manager.Interface
{
    interface ISelectP<P> where P : BaseRecordP
    {
        List<P> GetListPoszt();
        P GetOnePoszt(P record);
    }
}
