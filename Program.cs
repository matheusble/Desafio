using Desafio.Models;
using System;
using System.Collections.Generic;

namespace Desafio
{
    class Program
    {

        static List<Boi> bois;
        static List<Area> areas;
        static void Main(string[] args)
        {
            bois = new List<Boi>();
            areas = new List<Area>();

            Boi b = new Boi();
            Area a = new Area();


            Console.WriteLine("Escolha a opção: ");
            int option = int.Parse(Console.ReadLine());

            while (option != 7)
            {

                switch (option)
                {
                    case 1:
                        Console.WriteLine();
                        Console.WriteLine("Adicionar Boi: ");
                        Console.WriteLine();
                        Console.Write("Digite o brinco do boi: ");
                        b.Brinco = Console.ReadLine();
                        Console.Write("Digite o peso: ");
                        b.Peso = double.Parse(Console.ReadLine());
                        AdicionarBoi(b.Brinco, b.Peso);
                        option = int.Parse(Console.ReadLine());
                        continue;


                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Adicionar Area: ");
                        Console.WriteLine();
                        Console.Write("Digite o nome da área: ");
                        a.nameArea = Console.ReadLine();
                        Console.Write("Quantidade máxima: ");
                        a.max = int.Parse(Console.ReadLine());
                        Console.Write("Digite o GMD: ");
                        a.GMD = double.Parse(Console.ReadLine());
                        AdicionarArea(a.nameArea, a.max, a.GMD);
                        option = int.Parse(Console.ReadLine());
                        continue;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Listar bois: ");
                        Console.WriteLine();
                        ListarBois();
                        option = int.Parse(Console.ReadLine());
                        continue;

                    case 4:
                        Console.WriteLine();
                        Console.WriteLine("Mudar Área: ");
                        Console.WriteLine();
                        Console.Write("Digite o brinco do boi: ");
                        b.Brinco = Console.ReadLine();
                        Console.Write("Digite a area para o boi: ");
                        b.AreaBoi = Console.ReadLine();
                        Console.Write("Digite o número de dias: ");
                        b.Ndias = int.Parse(Console.ReadLine());
                        MudarBoi(b.Brinco, b.AreaBoi, b.Ndias);
                        option = int.Parse(Console.ReadLine());
                        continue;

                    case 5:

                        Console.WriteLine();
                        Console.WriteLine("Bois nas áreas: ");
                        BoiNaArea();
                        option = int.Parse(Console.ReadLine());

                        continue;

                    case 6:
                        continue;
                }

            }
            void AdicionarBoi(string brinco, double peso)
            {
                bois.Add(new Boi(brinco, peso));
            }

            void AdicionarArea(string nameArea, int max, double gmd)
            {
                areas.Add(new Area(nameArea, max, gmd));
            }

            void ListarBois()
            {
                foreach (var i in bois)
                {
                    Console.WriteLine("Brinco do boi: {0}, Peso do boi: {1}", i.Brinco, i.Peso);
                }
            }

            void MudarBoi(string brinco, string area, int Ndias)
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

            void BoiNaArea()
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

            bool Exists(string nameBoi)
            {
                bool decision = false;
                foreach (var i in bois)
                {
                    i.Brinco = nameBoi;
                    decision = true;
                }
                return decision;

            }
        }
    }
}
