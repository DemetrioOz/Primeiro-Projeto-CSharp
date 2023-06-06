using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = this.p(this.A, this.B, this.C);
            return Math.Sqrt(p * (p - this.A) * (p - this.A) * (p - this.A));
        }

        private double p(double a, double b, double c)
        {
            return (a + b + c) / 2.0;
        }
    }
}

