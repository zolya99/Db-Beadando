using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P001_Connection.Model.Record
{
    class Poszt : BaseRecordP
    {
        private int id;
        private string megnevezes;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }

        public string Megnevezes
        {
            get { return megnevezes; }
            set
            {
                if (value == string.Empty)
                {
                    throw new Exception("A poszt nem lehet üres!");
                }
                megnevezes = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}", megnevezes);
        }
    }
}
