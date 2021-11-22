using System;
using System.Globalization;

namespace Exercicio_de_Fixação_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = Console.ReadLine();
            int quantidadeDeQuartos = int.Parse(Console.ReadLine());
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string cor = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com seu nome completo: " + nome);
            Console.WriteLine("Quantos quartos tem na sua casa? " + quantidadeDeQuartos);
            Console.WriteLine("Entre com o preço de um produto: " + preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
            Console.Write("Nome: " + cor + " | ");
            Console.Write("Idade: " + idade + " | ");
            Console.Write("Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();

        }
    }
}
