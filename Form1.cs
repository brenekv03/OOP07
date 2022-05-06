using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zamestnanec zamestnanec = new Zamestnanec("Lakatoš", "Bodnar", 100);
            zamestnanec.OdpracujHodiny(10);
            MessageBox.Show( zamestnanec.Vypis());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vedouci vedouci = new Vedouci("Ivan", "Bodnar", 110,69);
            vedouci.OdpracujHodiny(10);
            MessageBox.Show(vedouci.Vypis());
        }
    }
}
