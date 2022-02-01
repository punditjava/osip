using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao_OpenGL_Initialization_Test;

namespace _3D
{
    class FormulaJuliaModel : IFormula
    {
        double alfa = 0;
        double beta = -1 / (2*Math.Sqrt(2));

        public double Alfa { get => alfa; set => alfa = value; }
        public double Beta { get => beta; set => beta = value; }
        public double RR { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double computingX(double x, double y, double z = 0)
        {
            return (double)(x * x - y * y + alfa);
        }

        public double computingY(double x, double y, double z = 0)
        {
            return (double)(2 * x * y + beta);
        }
    }
}
