using System;

namespace Uppgift_2_4
{
    class Program
    {
        static void Main(string[] arg)
        {

            Console.WriteLine("Lön för första personen");
            string Lön1 = Console.ReadLine();
            Console.WriteLine("Lön för andra personen");
            string Lön2 = Console.ReadLine();
            Console.WriteLine("Lön för tredje personen");
            string Lön3 = Console.ReadLine();
            int person_1 = int.Parse(Lön1);
            int person_2 = int.Parse(Lön2);
            int person_3 = int.Parse(Lön3);
            int Personer = person_1 + person_2 + person_3;
            int resultat = Personer / 3;
            Console.WriteLine(resultat + " är medellönet");
        }
    }
}
            

            

