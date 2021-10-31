using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao_OpenGL_Initialization_Test;

namespace _3D
{
    class FormulaLorenzModel : IFormula
    {
        private readonly double sigma;
        private readonly double b;
        private readonly double r;
        public FormulaLorenzModel(double sigma, double b, double r) {
            this.b = b;
            this.r = r;
            this.sigma = sigma;
        }
        public double computingX(double x, double y, double z) {
            return -sigma * x + sigma * y;
        }

        public double computingY(double x, double y, double z) {
            return r * x - y - x * z;
        }

        public double computingZ(double x, double y, double z) {
            return x * y - b * z;
        }
    }
}
