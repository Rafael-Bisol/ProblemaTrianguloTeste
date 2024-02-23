using System;

namespace ProblemaTrianguloTeste
{
    class Triangulo
    {
        public double A, B, C;

        public double SemiPerimetro()
        {
            return (A + B + C) / 2;
        }

        public double Area()
        {
            double p = SemiPerimetro();
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}

