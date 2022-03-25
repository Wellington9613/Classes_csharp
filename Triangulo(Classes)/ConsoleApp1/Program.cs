using System;
using System.Globalization;
namespace Aula
{
    class program

    {
        static void Main(string[] args)
        {  
            /*CLASSE QUE FOI ATRIBUIDA*/
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();



            Console.WriteLine("Entre com as medidas do triangulo X");

            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triangulo Y");

            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           
            double area = x.Area();
            double areay = y.Area();


            Console.WriteLine("AreaX= " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("AreaY = " + areay.ToString("F4", CultureInfo.InvariantCulture));
            if (area > areay)
            {
                Console.WriteLine("A area X é a maior");
            }
            else
                Console.WriteLine("A area y é a maior");





        }
    }
}
