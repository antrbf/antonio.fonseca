using System;
using System.Globalization;

namespace Exercicio_Salário_Médio
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario x1 = new Funcionario();
            Funcionario x2 = new Funcionario();

            Console.WriteLine("Dados do Primeiro Funcionario");
            Console.Write("Nome: ");
            x1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            x1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do Segundo Funcionario");
            Console.Write("Nome: ");
            x2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            x2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = (x2.Salario + x1.Salario) / 2.0;

            Console.WriteLine("Salário médio = " + resultado.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
