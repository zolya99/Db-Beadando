using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace P001_Connection.Model.Record
{
    class Focista : BaseRecord
    {
        private int id;
        private int szuletesi_ev;
        private string vezeteknev;
        private string keresztnev;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }

        public int Szuletesi_ev
        {
            get { return szuletesi_ev; }
            set
            {
                if (value == 0)
                {
                    throw new Exception("Az érték nem lehet 0!");
                }
                szuletesi_ev = value;
            }
        }

        public string Vezeteknev
        {
            get { return vezeteknev; }
            set
            {
                if (value == string.Empty)
                {
                    throw new Exception("A vezetéknév nem lehet üres!");
                }
                vezeteknev = value;
            }
        }

        public string Keresztnev
        {
            get { return keresztnev; }
            set
            {
                if (value == string.Empty)
                {
                    throw new Exception("A keresztnév nem lehet üres!");
                }
                keresztnev = value;
            }
        }



        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Szuletesi_ev, Vezeteknev, Keresztnev);
        }
    }
}
