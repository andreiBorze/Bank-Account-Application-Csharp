using System;

namespace lab9ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContEconomii economii = new ContEconomii(1000, "Economii", 0.05m);
            ContCurent curent = new ContCurent(500, "Curent");

            Console.WriteLine(economii.GetDescriere());
            Console.WriteLine(curent.GetDescriere());

            economii.Depunere(500);
            curent.Extragere(100);
            curent.Depunere(2000);

            Console.WriteLine(economii.GetDescriere());
            Console.WriteLine(curent.GetDescriere());

            ContInvestitii investitii = new ContInvestitii(2000, "Investitii", 0.1m, 20);
            Console.WriteLine(investitii.GetDescriere());

            investitii.Depunere(1000);
            Console.WriteLine(investitii.GetDescriere());

            investitii.Extragere(500);

            Console.WriteLine(investitii.GetDescriere());

            Console.ReadKey();
        }
    }
}
