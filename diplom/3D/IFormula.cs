namespace Tao_OpenGL_Initialization_Test
{
    interface IFormula
    {
        double Alfa { get; set; }
        double Beta { get; set; }
        double RR { get; set; }

        double computingX(double x, double y, double z= 0);
        double computingY(double x, double y, double z =0);

        //double computingZ(double x, double y, double z);
    }
}
