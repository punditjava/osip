using System.Collections.Generic;

namespace Tao_OpenGL_Initialization_Test
{
    class MethodSelector
    {
        private ICalcuteMethods calcuteMethod;
        public MethodSelector() {
        }

        public MethodSelector(ICalcuteMethods calcuteMethod) {
            this.calcuteMethod = calcuteMethod;
        }
        public void setCalculateMethod(ICalcuteMethods calcuteMethod) {
            this.calcuteMethod = calcuteMethod;
        }
        public List<int> calculate() {
            return this.calcuteMethod.calculate();
        }
    }
}
