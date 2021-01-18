using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P001_Connection.Model.Record
{
    class Csapat : BaseRecordC
    {
        private int id;
        private string nev;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }


        public string Nev
        {
            get { return nev; }
            set
            {
                if (value == string.Empty)
                {
                    throw new Exception("A csapat neve nem lehet üres");
                }
                nev = value;
            }

        }

        public override string ToString()
        {
            return string.Format("{0}", Nev);
        }
    }
}
