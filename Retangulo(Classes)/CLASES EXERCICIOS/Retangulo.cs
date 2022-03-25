using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Project
{
    internal class Retangulo
    {
        
        public double Altura;
        public double Largura;

        public double Area()
        {
            return Altura * Largura;
        }
        public double Perimetro()
        {
            return Altura + Altura + Largura + Largura;
        }
        public double DiagonalRetangulo()
        {
            return Math.Sqrt(Altura * Altura + Largura * Largura);

        }
        public override string ToString()
        {
            return "AREA = "
                + Area().ToString("F2", CultureInfo.InvariantCulture)
                +" PERÍMETRO = "
                + Perimetro().ToString("F2", CultureInfo.InvariantCulture)
                + " DIAGONAL = "
                + DiagonalRetangulo().ToString("F2", CultureInfo.InvariantCulture);


        }

        
    }
}
