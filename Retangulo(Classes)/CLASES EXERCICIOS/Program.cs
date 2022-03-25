using System;
using System.Globalization;


namespace Project
{
    class program

    {
        static void Main(string[] args)
        {
            Retangulo p = new Retangulo();
         
            Console.WriteLine("Entre com a Altura e a Largura: ");
            p.Altura = double.Parse(Console.ReadLine());
            p.Largura = double.Parse(Console.ReadLine());

            Console.WriteLine(p);
            

        }
    }
}