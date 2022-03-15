using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Lab1;


namespace Plecak_Forms
{
    public partial class Plecak : Form
    {
        public Plecak()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Run_Click(object sender, EventArgs e)
        {
            int n = int.Parse(tbLiczba.Text);
            int seed = int.Parse(tbSeed.Text);
            int size = int.Parse(tbPojemnosc.Text);

            int suma = 0;

            List<Przedmiot> przedmioty = new List<Przedmiot>();
            List<Przedmiot> items = new List<Przedmiot>();

            Plecak plecak = new Plecak(0, size, items);
            Generator generator = new Generator(n, seed);
            for (int i = 0; i < n; i++)
            {
                Przedmiot przedmiot = new Przedmiot(i + 1, generator.numbers[i], generator.numbers[n - i - 1]);
                przedmioty.Add(przedmiot);
            }

            for (int i = 0; i < n; i++)
            {
                if (przedmioty[i].Waga < plecak._Rozmiar - suma)
                {
                    plecak._Przedmioty.Add(przedmioty[i]);
                    suma += przedmioty[i].Waga;
                }
            }
        }
    }
  

}
