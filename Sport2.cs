using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sport nogomet = new Sport("Nogomet", true, 42);
            Sport vaterpolo = new Sport("Vaterpolo", true, 84);
            Sport curling = new Sport("Curling", true, 168);
        }
    }

    class Sport
    {
        private string Naziv;
        private bool IgraLiSeLoptom;
        private byte BrojIgraca;

        public Sport(string naziv)
        {
            Naziv = naziv;
        }
        public Sport(string naziv, bool igraLiSeLoptom)
        {
            Naziv = naziv;
            IgraLiSeLoptom = igraLiSeLoptom;
        }
        public Sport(string naziv, bool igraLiSeLoptom, byte brojIgraca)
        {
            Naziv = naziv;
            IgraLiSeLoptom = igraLiSeLoptom;
            BrojIgraca = brojIgraca;
        }
    }


}
