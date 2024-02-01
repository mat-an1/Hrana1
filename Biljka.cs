using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biljka
{
    class Biljka
    {
    }

    class Stablo : Biljka
    {
        bool otpadajuListovi;
        public bool OtpadajuListovi { get => otpadajuListovi; set => otpadajuListovi = value; }
        public Stablo(bool otpadajuListovi)
        {
            OtpadajuListovi = otpadajuListovi;
        }
    }

    class Cvijet : Biljka
    {

    }

    class Crnogoricno : Stablo
    {
        public Crnogoricno() : base(true)
        {
        }
    }

    class Bjelogoricno : Stablo
    {
        public Bjelogoricno() : base(false)
        {
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Bjelogoricno Hrast = new Bjelogoricno();
            Crnogoricno Bor = new Crnogoricno();
            Console.WriteLine("Hrast:{0} , Bor: {1}",
                Hrast.OtpadajuListovi, Bor.OtpadajuListovi);

            Console.ReadKey();
        }
    }
}
