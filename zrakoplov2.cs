using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _20240411
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zrakoplov a = new Zrakoplov("Airbus", 2000, 6000);
            Zrakoplov cs = new Zrakoplov("Cessna Skycatcher", 75, 870);
            Zrakoplov p = new Zrakoplov("Pilatus", 1200, 1333);
            Zrakoplov x380 = new Zrakoplov("Airbus", 2000, 6000);
            Zrakoplov C162 = new Zrakoplov("Cessna Skycatcher", 75, 870);
            Zrakoplov PC_21 = new Zrakoplov("Pilatus", 1200, 1333);
        }
    }

    class Zrakoplov
    {
        private string Naziv;
        private double SnagaMotora; // kW
        private int DosegLeta; // km
        public Zrakoplov(string naziv, double snagaMotora, int dosegLeta)
        {
            Naziv = naziv;
            SnagaMotora = snagaMotora;
            DosegLeta = dosegLeta;
        }
    }
}
