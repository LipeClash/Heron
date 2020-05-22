using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("         |\\                                               ");
            Console.WriteLine("         | \\                       SEMIPERÍMETRO          ");
            Console.WriteLine("         |  \\                                             ");
            Console.WriteLine("         |   \\                       a + b + c            ");
            Console.WriteLine("         |    \\                S =   __________           ");
            Console.WriteLine("         |     \\                         7                ");
            Console.WriteLine("         |      \\                                         ");
            Console.WriteLine("  a = 5  |       \\    b = 7           ARÉA                ");
            Console.WriteLine("         |        \\                                       ");
            Console.WriteLine("         |         \\                   2.5                ");
            Console.WriteLine("         |          \\          A =    _____  =  10        ");
            Console.WriteLine("         |           \\                  2                 ");
            Console.WriteLine("         |____________\\                                   ");
            Console.WriteLine("             c = 2                      10                 ");
            Console.WriteLine("                                       _____  =  5         ");
            Console.WriteLine("                                         2                 ");
            
            Double A = 5;
            Double B = 7;
            Double C = 2;
            Double Medidasdolados = A + B + C;
            Console.WriteLine($" Lado a..: {A} \n Lado b..: {B} \n Lado c..: {C}");
            Console.WriteLine("\n");
            Console.WriteLine(" Semiperímetro..: 7");
            Console.WriteLine(" Área...........: 5");

        }
    }
}
