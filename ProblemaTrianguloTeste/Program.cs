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

            Console.WriteLine("Area de X: " + x.Area());
            Console.WriteLine("Area de Y: " + y.Area());

            if (x.Area() > y.Area())
                Console.WriteLine("areaX é maior que areaY");
            else if (y.Area() > x.Area())
                Console.WriteLine("areaY é maior que areaX");
            else
                Console.WriteLine("areaX e areaY são iguais");
        }
    }
}

