using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio;

namespace Desafio.Models
{

    public class Boi
    {
        public static List<Boi> bois { get; set; }
        public static List<Area> areas { get; set; }


        public string Brinco { get; set; }
        public double Peso { get; set; }
        public string AreaBoi { get; set; }
        public int Ndias { get; set; }
        public Area area { get; set; }

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

        public void AdicionarBoi(string brinco, double peso)
        {
            bois.Add(new Boi(brinco, peso));
        }

        public void BoiNaArea()
        {
            foreach (var i in bois)
            {
                if (i.AreaBoi != null)
                {
                    Console.WriteLine("Brinco do boi: {0}, Peso do boi: {1}, Area do boi: {2}", i.Brinco, i.Peso, i.AreaBoi);
                }
                else
                {
                    Console.WriteLine("Nenhum boi está atrelado a alguma área");
                }
            }
        }
        public void ListarBois()
        {
            foreach (var i in bois)
            {
                Console.WriteLine("Brinco do boi: {0}, Peso do boi: {1}", i.Brinco, i.Peso);
            }
        }

        public void MudarBoi(string brinco, string area, int Ndias)
        {
            foreach (var i in bois)
            {

                foreach (var j in areas)
                {
                    if (j.CountBoi < j.max)
                    {
                        if (i.Brinco == brinco && j.nameArea == area)
                        {
                            j.CountBoi++;
                            i.AreaBoi = area;
                            i.Peso += (j.GMD * Ndias);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida");
                    }
                }
            }
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
