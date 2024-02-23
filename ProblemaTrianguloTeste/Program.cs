using System;

namespace ProblemaTrianguloTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;
            xA = 3;
            xB = 4;
            xC = 5;
            yA = 7.5;
            yB = 4.5;
            yC = 4.02;

            double p = (xA + xB + xC) / 2;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

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

