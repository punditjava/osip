namespace Tao_OpenGL_Initialization_Test
{
    class MethodRungeKutta : ICalcuteMethods
    {
        private IFormula formula;
        private double x, y, z;
        private const float dt = 0.01f;

        private double k1, k2, k3, k4, m1, m2, m3, m4, l1, l2, l3, l4;
        public double[,] calcute(int size, IFormula formula, double x0, double y0, double z0) {
            double[,] GrapValuesArray = new double[size, 3];
            int elements_count = 1;
            this.formula = formula;
            this.x = x0;
            this.y = y0;
            GrapValuesArray[elements_count - 1, 0] = x;
            GrapValuesArray[elements_count - 1, 1] = y;
            GrapValuesArray[elements_count - 1, 2] = z;

            for (double f = 0; f < size - 1; f += 1) {
                calKoef();
                x += (k1 + 2 * k2 + 2 * k3 + k4) / 6;
                y += (m1 + 2 * m2 + 2 * m3 + m4) / 6;
                z += (l1 + 2 * l2 + 2 * l3 + l4) / 6;
                GrapValuesArray[elements_count, 0] = x;
                GrapValuesArray[elements_count, 1] = y;
                GrapValuesArray[elements_count, 2] = z;
                elements_count++;
            }

            return GrapValuesArray;
        }
        private void calKoef() {
            calK1();
            calM1();
            calL1();
            calK2();
            calM2();
            calL2();
            calK3();
            calM3();
            calL3();
            calK4();
            calM4();
            calL4();
        }
        private void calK1() {
            k1 = formula.computingX(x, y, z) * dt;
        }
        private void calM1() {
            m1 = formula.computingY(x, y, z) * dt;
        }
        private void calL1() {
            l1 = formula.computingZ(x, y, z) * dt;
        }
        private void calK2() {
            k2 = formula.computingX(x + k1 / 2, y + m1 / 2, z + l1 / 2) * dt;
        }
        private void calM2() {
            m2 = formula.computingY(x + k1 / 2, y + m1 / 2, z + l1 / 2) * dt;
        }
        private void calL2() {
            l2 = formula.computingZ(x + k1 / 2, y + m1 / 2, z + l1 / 2) * dt;
        }
        private void calK3() {
            k3 = formula.computingX(x + k2 / 2, y + m2 / 2, z + l2 / 2) * dt;
        }
        private void calM3() {
            m3 = formula.computingY(x + k2 / 2, y + m2 / 2, z + l2 / 2) * dt;
        }
        private void calL3() {
            l3 = formula.computingZ(x + k2 / 2, y + m2 / 2, z + l2 / 2) * dt;
        }
        private void calK4() {
            k4 = formula.computingX(x + k3, y + m3, z + l3) * dt;
        }
        private void calM4() {
            m4 = formula.computingY(x + k3, y + m3, z + l3) * dt;
        }
        private void calL4() {
            l4 = formula.computingZ(x + k3, y + m3, z + l3) * dt;
        }
    }
}
