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

        public FormulaIkedaModel() {

        }

        public double computingX(double x, double y, double z)
        {
            return (double)(0.99 - 0.9f * (x * Math.Cos(computingt(x, y)) - y * Math.Sin(computingt(x, y))));
        }
        public double computingY(double x, double y, double z)
        {
            return (double)(1.2 * (x * Math.Sin(computingt(x, y)) + y * Math.Cos(computingt(x, y))));

        }
        public double computingt(double x, double y)
        {
            return (double)(0.4f - 6 / (1 + x * x + y * y));
        }


    }
}
