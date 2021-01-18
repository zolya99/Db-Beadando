using P001_Connection.Model.Record;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P001_Connection.Model.Manager.Interface
{
    interface IDeleteP<P> where P : BaseRecordP
    {
        bool DeletePoszt(P record); 
    }

}
    
