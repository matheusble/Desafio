using Desafio.Models;
using Desafio.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Desafio
{
    class Program 
    {


        static void Main(string[] args)
        {
             List<Boi> bois = new List<Boi>();
             List<Area> areas = new List<Area>();

             BoiViewModel model = new BoiViewModel();

            Area a = new Area();
            Boi b = new Boi();


            Console.WriteLine("#1: Para adicionar um brinco ao Boi#");
            Console.WriteLine("#2: Para adicionar uma nova área#");
            Console.WriteLine("#3: Para listar todos os bois#");
            Console.WriteLine("#4: Simular o GMD do boi na área#");
            Console.WriteLine("#5: Listar todos os bois já designados em áreas#");
            Console.WriteLine("#6: Para buscar um brinco específico#");
            Console.WriteLine("#7: Exit");
            bool con = true;

            while (con)
            {

                int option = int.Parse(Console.ReadLine());


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
                        Console.Write("Digite 1 para adicionar uma nova área ou escolha outra opção: ");
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
                        Console.WriteLine();
                        Console.Write("Digite 2 para adicionar uma nova área ou escolha outra opção: ");
                        continue;

                    case 3:
                        Console.WriteLine();
                        Console.WriteLine("Listar bois: ");
                        Console.WriteLine();
                        ListarBois();
                        Console.WriteLine();
                        Console.Write("Digite 3 para listar novamente ou escolha outra opção: ");
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
                        Console.WriteLine();
                        Console.Write("Digite 4 mudar outro boi de área ou escolha outra opção: ");
                        continue;

                    case 5:

                        Console.WriteLine();
                        Console.WriteLine("Bois atribuídos nas áreas : ");
                        BoiNaArea();
                        Console.WriteLine();
                        Console.Write("Digite 5 para ver novamente ou escolha outra opção: ");

                        continue;


                    case 6:

                        Console.WriteLine();
                        Console.Write("Buscar brinco específico: ");
                        b.Brinco = Console.ReadLine();
                        BuscaBoi(b.Brinco);
                        Console.WriteLine();
                        Console.Write("Digite 6 para buscar outro brinco ou escolha outra opção: ");

                        continue;

                    case 7:
                    default:
                        con = false;
                        break;
                }

            }


            void AdicionarBoi(string brinco, double peso)
            {

                if (Exist(brinco) != true)
                {
                    bois.Add(new Boi(brinco, peso));
                }
                else
                {
                    Console.WriteLine("O brinco especificado já está cadastrado");
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
            void ListarBois()
            {
                foreach (var i in bois)
                {
                    Console.WriteLine("Brinco do boi: {0}, Peso do boi: {1}", i.Brinco, i.Peso);
                }
            }

            void MudarBoi(string brinco, string area, int Ndias)
            {

                if (Exist(brinco) == true && ExistArea(area))
                {
                    foreach (var i in bois)
                    {

                        foreach (var j in areas)
                        {
                            if (i.Brinco == brinco && j.nameArea == area)
                            {
                                if (j.CountBoi < j.max)
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
                else
                {
                    Console.WriteLine("O brinco especificado ou a área especificada não existe");
                }
            }


            void BuscaBoi(string brinco)
            {
                if (Exist(brinco) == true)
                {
                    var boi = bois.FirstOrDefault(x => x.Brinco == brinco);
                    Console.WriteLine(boi);
                }
                else
                {
                    Console.WriteLine("O brinco especificado não existe");
                }
            }



             void AdicionarArea(string nameArea, int max, double gmd)
            {
                if (ExistArea(nameArea) == true)
                {
                    areas.Add(new Area(nameArea, max, gmd));
                }
                else
                {
                    Console.WriteLine("A área já está cadastrada");
                }
            }
             bool ExistArea(string brinco)
            {
                return bois.Any(x => x.Brinco == brinco);
            }



            bool Exist(string nameArea)
            {
                return areas.Any(x => x.nameArea == nameArea);
            }
        }
    }

}
