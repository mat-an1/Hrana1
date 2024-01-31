using System;
class ProgramskiJezik
{
    protected double postotak;
    public double Postotak
    {
        get { return postotak; }
        set { postotak = value; }
    }
}

class Proceduralni : ProgramskiJezik { }

class Objektni : ProgramskiJezik { }

class Funkcionalni : ProgramskiJezik { }

class Program
{
    static void Main()
    {
        Proceduralni x = new Proceduralni();
        Objektni y = new Objektni();
        Funkcionalni z = new Funkcionalni();

        Console.WriteLine("Unesite postotak za Proceduralni:");
        x.Postotak = double.Parse(Console.ReadLine());

        Console.WriteLine("Unesite postotak za Objektni:");
        y.Postotak = double.Parse(Console.ReadLine());

        Console.WriteLine("Unesite postotak za Funkcionalni:");
        z.Postotak = double.Parse(Console.ReadLine());

        double zbrojPostotaka = x.Postotak + y.Postotak + z.Postotak;

        if (zbrojPostotaka != 100)
        {
            Console.WriteLine("Neispravan unos! Zbroj postotaka nije 100.");
        }
        else
        {
            if (x.Postotak > y.Postotak && x.Postotak > z.Postotak)
                Console.WriteLine("Proceduralni je najzastupljeniji.");
            else if (y.Postotak > x.Postotak && y.Postotak > z.Postotak)
                Console.WriteLine("Objektni je najzastupljeniji.");
            else
                Console.WriteLine("Funkcionalni je najzastupljeniji.");
        }
    }
}
