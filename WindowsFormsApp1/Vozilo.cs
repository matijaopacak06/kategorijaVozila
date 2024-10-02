using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Vozilo
    {
        string model;
        int godinaproizvodnje;
        int brojkotaca;

        public Vozilo(string model, int godinaproizvodnje, int brojkotaca)
        {
            this.Model = model;
            this.Godinaproizvodnje = godinaproizvodnje;
            this.Brojkotaca = brojkotaca;
        }

        public string Model { get => model; set => model = value; }
        public int Godinaproizvodnje { get => godinaproizvodnje; set => godinaproizvodnje = value; }
        public int Brojkotaca { get => brojkotaca; set => brojkotaca = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }



}
