using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao_OpenGL_Initialization_Test;

namespace _3D
{
    class FormulaRosslerModel : IFormula
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;
        public FormulaRosslerModel(double a, double b, double c) {
            this.c = c;
            this.a = a;
            this.b = b;
        }

        public double computingX(double x, double y, double z) {
            return -y - z;
        }

        public double computingY(double x, double y, double z) {
            return x + a * y;
        }

        public double computingZ(double x, double y, double z) {
            return b + z * (x - c);
        }
    }
}
