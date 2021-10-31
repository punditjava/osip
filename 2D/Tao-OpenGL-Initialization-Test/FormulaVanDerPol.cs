using System;

namespace Tao_OpenGL_Initialization_Test
{
    class FormulaVanDerPol : IFormula
    {
        private readonly float alfa;
        private readonly float omega;
        private readonly float beta;

        public FormulaVanDerPol(float alfa, float beta, float omega) {
            this.alfa = alfa;
            this.beta = beta;
            this.omega = omega;
        }
        public float computingX(float x, float y, float t) {
            return (float)(x *x - y*y+ alfa);
        }
        public float computingY(float x, float y, float t) {
            return (float)(2*x*y + beta);
        }
    }
}
