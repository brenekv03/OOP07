using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP07
{
    class Vedouci:Zamestnanec
    {
        private int priplatekZaVedeni;
        public Vedouci(string jmeno, string prijmeni, int hodinovaMzda, int priplatek) : base(jmeno, prijmeni, hodinovaMzda)
        {
            this.priplatekZaVedeni = priplatek;
        }
        public override double VypoctiMzdu()
        {
            return base.VypoctiMzdu()+priplatekZaVedeni;
        }
    }
}
