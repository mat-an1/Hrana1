using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Brod b = new Brod();
            Console.Write("Brod >>> ");
            b.KudaVozi();

            Zrakoplov z = new Zrakoplov();
            Console.Write("Zrakoplov >>> ");
            z.KudaVozi();

            Console.ReadKey();
        }
    }

    class Vozilo
    {
        private bool leti;
        private bool plovi;

        public bool JeLiLeti { get => leti; set => leti = value; }
        public bool JeLiPlovi { get => plovi; set => plovi = value; }

        public void KudaVozi()
        {
            Console.WriteLine(String.Format("Leti: {0} | Plovi: {1}", JeLiLeti, JeLiPlovi));
        }
    }

    class Brod : Vozilo
    {
        public Brod()
        {
            JeLiPlovi = true;
            JeLiLeti = false;
        }
    }

    class Zrakoplov : Vozilo
    {
        public Zrakoplov()
        {
            JeLiPlovi = false;
            JeLiLeti = true;
        }
    }

}