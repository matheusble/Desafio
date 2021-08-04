using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio;
using Desafio.Models.ViewModel;

namespace Desafio.Models
{

    public class Boi
    {
        BoiViewModel model = new BoiViewModel();
        public string Brinco { get; set; }
        public double Peso { get; set; }
        public string AreaBoi { get; set; }
        public int Ndias { get; set; }

        public Boi()
        {
        }

        public Boi(string brinco, double peso)
        {
            Brinco = brinco;
            Peso = peso;
        }

        public Boi(string areaBoi) : base()
        {
            AreaBoi = areaBoi;
        }

       

        
        public override bool Equals(object obj)
        {
            return obj is Boi boi &&
                   Brinco == boi.Brinco;
        }



        public override int GetHashCode()
        {
            return HashCode.Combine(Brinco);
        }

        public override string ToString()
        {
            return "Brinco do boi: " + Brinco + "," + " Peso do boi: " + Peso;

        }
    }
}
