using System;

namespace ProblemaTrianguloTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x = new Triangulo();
            Triangulo y = new Triangulo();
            x.A = 3;
            x.B = 4;
            x.C = 5;
            y.A = 7.5;
            y.B = 4.5;
            y.C = 4.02;


            double p = (x.A + x.B + x.C) / 2;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Area de X: " + areaX);
            Console.WriteLine("Area de Y: " + areaY);

            if (areaX > areaY)
                Console.WriteLine("areaX é maior que areaY");
            else if (areaY > areaX)
                Console.WriteLine("areaY é maior que areaX");
            else
                Console.WriteLine("areaX e areaY são iguais");
        }
    }
}

