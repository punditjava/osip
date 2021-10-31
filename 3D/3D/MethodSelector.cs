﻿namespace Tao_OpenGL_Initialization_Test
{
    class MethodSelector
    {
        private ICalcuteMethods calcuteMethod;
        private IFormula formula;
        public MethodSelector() {
        }

        public MethodSelector(ICalcuteMethods calcuteMethod) {
            this.calcuteMethod = calcuteMethod;
        }
        public void setCalculateMethod(ICalcuteMethods calcuteMethod) {
            this.calcuteMethod = calcuteMethod;
        }
        public double[,] calculate(int size, double x0, double y0, double z0) {
            return this.calcuteMethod.calcute(size, formula, x0, y0, z0);
        }
        public void setFormula(IFormula formula) {
            this.formula = formula;
        }
    }
}
