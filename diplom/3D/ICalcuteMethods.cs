using System.Collections.Generic;

namespace Tao_OpenGL_Initialization_Test
{
    interface ICalcuteMethods
    {
        int N1 { get; set; }
        float X_0 { get; set; }
        float D { get; set; }
        float Y_0 { get; set; }
        Dictionary<int, int[]> Graph { get; set; }
        int Iter { get; set; }

        List<int> calculate();

    }
}
