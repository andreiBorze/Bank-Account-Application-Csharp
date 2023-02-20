using System;
using System.Collections.Generic;
using System.Text;

namespace lab9ex1
{
    public class ContCurent : Cont
    {
        public decimal LimitaDescoperire { get; private set; }

        public ContCurent(decimal sold, string nume, decimal descoperit = 5000):base(sold,nume)
        {
            LimitaDescoperire = descoperit;
        }

        public override void Depunere(decimal valoare)
        {
            if (Sold >= 0)
            {
                Sold += valoare;
            }
            else
            {
                LimitaDescoperire += valoare;
                if (LimitaDescoperire > 5000)
                {
                    Sold += LimitaDescoperire - 5000;
                    LimitaDescoperire = 5000;
                }
            }
        }

        public override void Extragere(decimal valoare)
        {
            if (valoare <= 0)
            {
                Console.WriteLine("Suma trebuie sa fie pozitiva.");
                return;
            }

            if (valoare > Sold + LimitaDescoperire)
            {
                Console.WriteLine("Nu se poate extrage suma ceruta.");
            }
            else if (valoare <= Sold)
            {
                Sold -= valoare;
            }
            else if (valoare <= Sold + LimitaDescoperire)
            {
                LimitaDescoperire -= (valoare - Sold);
                Sold = 0;
            }
            else
            {
                Console.WriteLine("Nu se poate extrage suma ceruta.");
            }
        }

        public override string GetDescriere()
        {
            return $"{base.GetDescriere()} (Cont Curent) -Limita descoperire ramasa: {LimitaDescoperire}";
        }

    }
}
