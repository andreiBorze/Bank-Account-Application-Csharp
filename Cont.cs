using System;
using System.Collections.Generic;
using System.Text;

namespace lab9ex1
{
    public abstract class Cont
    {
        private Guid Id;
        protected decimal Sold { get; set; }
        private string Nume { get; set; }

        public Cont(decimal sold, string nume)
        {
            this.Id = Guid.NewGuid();
            Sold = sold;
            Nume = nume;
        }

        public virtual void Depunere(decimal valoare)
        {
            Sold += valoare;
        }

        public virtual void Extragere(decimal valoare)
        {
            Sold -= valoare;
        }
        public virtual string GetDescriere()
        {
            return $"Id: {this.Id}, nume: {Nume}, sold curent: {Sold}";
        }
    }
}
