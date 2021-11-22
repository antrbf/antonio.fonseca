using System;

namespace Cálculo_horas
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2021, 11, 22, 13, 18, 59, 500);
            Console.WriteLine(d);

            DateTime d2 = d.AddHours(11);

            Console.WriteLine(d2);

            Console.ReadLine();
        }
    }       
}
