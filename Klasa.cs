using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjezbaOOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi string: ");
            string s = Console.ReadLine();
            if (s.Length > 2)
            {
                KlasaB klasab = new KlasaB();
                Console.WriteLine(klasab.BezPrvogIZadnjeg(s));
            }
            else
            {
                Console.WriteLine("Krivi unos");
            }
            Console.ReadKey();
        }
    }

    class KlasaB
    {
        public string BezPrvogIZadnjeg(string s)
        {
            return s.Substring(1, s.Length - 2);
        }
    }
}