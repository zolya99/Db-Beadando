using P001_Connection.Model.Record;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P001_Connection.Model.Manager.Interface
{
    interface IUpdateP<P> where P : BaseRecordP
    {
        bool UpdatePoszt(P record);
    }
}
