using System;
using System.Collections.Generic;
using System.Text;

namespace lab9ex1
{
    public class ContEconomii: Cont
    {
        public decimal RataDobanda { get; private set; }
        public ContEconomii(decimal sold, string nume, decimal rata):base(sold, nume)
        {
            RataDobanda = rata;
        }

        public override void Depunere(decimal valoare)
        {
            Sold += valoare;
            ActualizeazaSold();
        }

        public override void Extragere(decimal valoare)
        {
            if (valoare > Sold)
            {
                Console.WriteLine("Nu se poate extrage suma ceruta.");
            }
            else
            {
                Sold -= valoare;
                ActualizeazaSold();
            }
        }

        private void ActualizeazaSold()
        {
           Sold *= (1+RataDobanda);
        }

        public override string GetDescriere()
        {
            return $"Cont de economii {base.GetDescriere()} și o rată a dobânzii de {RataDobanda}.";
        }
    }
}
