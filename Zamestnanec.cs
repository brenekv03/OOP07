using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP07
{
    class Zamestnanec
    {
        private string jmeno;
        private string prijmeni;
        private int odpracHodiny = 0;
        public int HodinovaMzda { get; }
        public Zamestnanec(string jmeno, string prijmeni,int hodinovaMzda )
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            HodinovaMzda = hodinovaMzda;
        }
        public void OdpracujHodiny(int hodiny)
        {
            odpracHodiny += hodiny;
        }
        public double VypoctiMzdu()
        {
            double mzda = HodinovaMzda * odpracHodiny;
            return mzda;
        }

        public string Vypis()
        {
            string s = "\nJméno: " + jmeno +
                "\nPříjmení: " + prijmeni +
                "\nOdpracované hodiny: " + odpracHodiny +
                "\nHodinová mzda: " + HodinovaMzda +
                "\nMzda: " + VypoctiMzdu();
            return s;
        }
    }
}
