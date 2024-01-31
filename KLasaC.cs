using System;
using main;

int[] broji = new int[5];

for (int i = 0; i < 5; ++i)
{
    broji[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(String.Format("Zbroj: {0} | Prosjek: {1}", KlasaC.Zbroj(broji), KlasaC.Prosjek(broji)));

namespace main
{
    class KlasaC
    {
        public static int Zbroj(int[] niz)
        {
            int zbroj = 0;
            foreach (int broj in niz)
            {
                zbroj += broj;
            }
            return zbroj;
        }

        public static double Prosjek(int[] niz)
        {
            int zbroj = Zbroj(niz);
            return (double)zbroj / niz.Length;
        }
    }
}
