using System;
using System.Collections.Generic;
using System.Text;

namespace lab9ex1
{
    public class ContInvestitii : ContEconomii
    {
        public int DataScadenta { get; private set; }
        public ContInvestitii(decimal sold, string nume, decimal rataDobanda, int dataScadenta)
            : base(sold, nume, rataDobanda)
        {
            DataScadenta = dataScadenta;
        }

        public override void Extragere(decimal valoare)
        {
            if (DateTime.Now.Day < DataScadenta)
            {
                Console.WriteLine("Nu se poate extrage suma ceruta. Termenul de extragere nu a fost atins.");
            }
            else
            {
                base.Extragere(valoare);
            }
        }
    }
}
