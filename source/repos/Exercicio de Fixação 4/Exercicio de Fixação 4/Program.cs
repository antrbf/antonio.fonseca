using System;
using System.Globalization;

namespace Exercicio_de_Fixação_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();

            double areaY = y.Area();

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}
/* Exercico com FOR
           int min, max, soma;

           int x = int.Parse(Console.ReadLine());
           int y = int.Parse(Console.ReadLine());

           if (x < y) {
               min = x;
               max = y;
           }
           else {
               min = y;
               max = x;
           }

           soma = 0;
           for (int i = min + 1; i < max; i++)
               if (i % 2 != 0)
               {
                   soma = soma + i;
               }
           Console.WriteLine(soma);

           */

/* Tabuada com FOR
       static void Main(string[] args)
       {

           int n = int.Parse(Console.ReadLine());

           for (int i = 1; i <= 10; i++)
           {
               int resultado = i * n;
               Console.WriteLine(i + " x " + n + " = " + resultado);
           }
       */

/* Exercicio While 1 
           Console.Write("Quantos números inteiros você vai digitar? ");
           int N = int.Parse(Console.ReadLine());

           for (int i = 1; i <= N; i++)
           {
               if (i % 2 != 0)
               {
                   Console.WriteLine(i);
               }

           }
           */

/*
 * Exercicio While
            Console.Write("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0.0)
            {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Número " + x + " é negativo");
            */

/* Exercicio 5 
 * 
string[] valores = Console.ReadLine().Split(' ');
int codigo = int.Parse(valores[0]);
int quantidade = int.Parse(valores[1]);

double total;
if (codigo == 1)
{
    total = quantidade * 4.0;
}
else if (codigo == 2)
{
    total = quantidade * 4.5;
}
else if (codigo == 3)
{
    total = quantidade * 5.0;
}
else if (codigo == 4)
{
    total = quantidade * 2.0;
}
else
{
    total = quantidade * 1.5;
}

Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
*/