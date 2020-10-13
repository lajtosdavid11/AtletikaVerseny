using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtletikaVerseny
{
    class Atleta
    {
        public string Rajtszam { get; private set; }
        public string VezNev { get; private set; }
        public string KerNev { get; private set; }
        public string Egyesulet { get; private set; }
        public int Ugras { get; private set; }

        public string Nev;

        public Atleta(string sor)
        {
            string[] a = sor.Split(';');
            Rajtszam = a[0];
            VezNev = a[1];
            Egyesulet = a[2];
            Ugras = int.Parse(a[3]);
            
        }
    }
}
