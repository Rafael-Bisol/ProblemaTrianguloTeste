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

        public Triangulo(){
            A = 1;
            B = 1;
            C = 1;
        }
        public Triangulo(double A, double B, double C){
            this.A = A;
            this.B = B;
            this.C = C;
        }
    }
}

