using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace videojatekKollekcio
{
    public class Jatek
    {
        public string Cim { get; set; }
        public string Fejleszto { get; set; }
        public string Platform { get; set; }
        public int KiadasEv { get; set; }

        public Jatek(string sor)
        {
            string[] darabok = darabolas(sor);
            Cim = darabok[0];
            Fejleszto = darabok[1];
            Platform = darabok[2];
            KiadasEv = int.Parse(darabok[3]);
        }

        private string[] darabolas(string sor)
        {
            return sor.Split(";");
        }

    }
}
