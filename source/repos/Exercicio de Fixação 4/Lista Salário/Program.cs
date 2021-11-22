using System;
using System.Globalization;
using System.Collections.Generic;

namespace Lista_Salário
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionários você quer registrar?");
            int n = int.Parse(Console.ReadLine());

            List<Funcionarios> list = new List<Funcionarios>();

            for (int i = 1; i <= n; i++)
            {

                Console.WriteLine("Funcionário #" + i + ": ");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionarios(id, nome, salario));
                Console.WriteLine();

            }

            Console.Write("Entre com quantos funcionarios você quer aumentar o salário : ");

            int procurarId = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Funcionarios func = list.Find(x => x.Id == procurarId);

            if (func != null)
            {
                Console.Write("Entre com a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.AumentoSalarial(porcentagem);
            }
            else
            {
                Console.WriteLine("Esse Id não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Atualizar lista de funcionários: ");
            foreach (Funcionarios obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.ReadLine();
        }
    }
}
