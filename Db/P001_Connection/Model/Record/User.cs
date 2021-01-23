using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P001_Connection.Model.Record
{
    class User : BaseRecordU
    {
        private int id;
        private string felhasznalonev;
        private string jelszo;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }

        public string Felhasznalonev
        {
            get { return felhasznalonev; }
            set
            {
                if (value == string.Empty)
                {
                    throw new Exception("A felhasználónév nem lehet üres!");
                }
                felhasznalonev = value;
            }
        }

        public string Jelszo
        {
            get { return jelszo; }
            set
            {
                if (value == string.Empty)
                {
                    throw new Exception("A jelszó nem lehet üres!");
                }
                jelszo = value;
            }
        }
    }
}
