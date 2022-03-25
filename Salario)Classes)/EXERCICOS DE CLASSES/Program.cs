using System;
using System.Globalization;

namespace Exercicio
{
    class Program
    {
        static void Main (string[] args)
        {
            Usuario user1, user2;

            user1 = new Usuario();
            user2 = new Usuario();

            Salario valor1, valor2;
            valor1 =  new Salario();
            valor2 = new Salario();

            Console.WriteLine(" Digite seu nome e sua idade");
            user1.Nome = Console.ReadLine();
            user1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Quanto você recebe mensalmente? ");
            valor1.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine(user1.Nome);
            Console.WriteLine(user1.Idade);

            Console.WriteLine(" Digite seu nome e sua idade");
            user2.Nome = Console.ReadLine();
            user2.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Quanto você recebe mensalmente? ");
            valor2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(user2.Nome);
            Console.WriteLine(user2.Idade);

            if (user1.Idade > user2.Idade)
            {
                Console.WriteLine("Pessoa mais velha é: " + user1.Nome);
            }
            else
                Console.WriteLine("Pessoa mais velha é: " + user2.Nome);


            double media = (valor1.salario + valor2.salario) / 2;
            Console.WriteLine("Salario medio é: " + media);






        }
    }
}