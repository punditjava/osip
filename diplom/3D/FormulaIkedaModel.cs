using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao_OpenGL_Initialization_Test;

namespace _3D
{
    class FormulaIkedaModel : IFormula
    {
        double alfa = -0.9;
        double beta = 1.2;
        double R = 1;

        public double Alfa { get => alfa; set => alfa = value; }
        public double Beta { get => beta; set => beta = value; }
        public double RR { get => R; set => R = value; }
        public FormulaIkedaModel() {

        }

        public double computingX(double x, double y, double z)
        {
            return (double)(R + alfa * (x * Math.Cos(computingt(x, y)) - y * Math.Sin(computingt(x, y))));
        }
        public double computingY(double x, double y, double z)
        {
            return (double)(beta * (x * Math.Sin(computingt(x, y)) + y * Math.Cos(computingt(x, y))));

        }
        public double computingt(double x, double y)
        {
            return (double)(0.4f - 6 / (1 + x * x + y * y));
        }


    }
}
