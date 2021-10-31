using osiptest;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;
using Tao_OpenGL_Initialization_Test;

namespace _3D
{
    public partial class Form1 : Form
    {

        private readonly int countOfElements = 10000;
        private List<int> geometricArray;
        private Dictionary<int, double> values;

        bool notCalculate = true;

//        private MethodSelector methodSelector;
        private IFormula formula;
        private ICalcuteMethods calcuteMethods;

        private void Form1_Load(object sender, EventArgs e) {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);

            // настройка проекции

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)AnT.Width / (float)AnT.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            // настройка параметров OpenGL для визуализации 
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
            Gl.glEnable(Gl.GL_COLOR_MATERIAL);
            formula = new FormulaIkedaModel();
            calcuteMethods = new MethodIteration(formula);

            RenderTime.Start();
        }

        private void RenderTime_Tick(object sender, EventArgs e) {
            draw();
            
        }

        private void draw() {

            if (notCalculate) {
                Thread t = new Thread(new ThreadStart(calculate_mesure), 50000000);
                t.Start();
                t.Join();
                SparseMatrix sm = new SparseMatrix(calcuteMethods.Graph);
                Balance balance = new Balance(sm, 1e-5);

                values = balance.balancing();

                notCalculate = false;
            }

            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glClearColor(255, 255, 240, 1);

            Gl.glLoadIdentity();


            Gl.glTranslated(0, 0, -7 );
            Gl.glRotated(Z.Value, 1, 0, 0);
            Gl.glRotated(X.Value, 0, 1, 0);
            Gl.glRotated(Y.Value, 0, 0, 1);

            Gl.glColor3f(0, 0, 0);
            Gl.glBegin(Gl.GL_LINES);
            Gl.glVertex3d(0, 0, 0);
            Gl.glVertex3d(50, 0, 0);
            Gl.glVertex3d(0, 0, 0);
            Gl.glVertex3d(0, 50, 0);
            Gl.glVertex3d(0, 0, 0);
            Gl.glVertex3d(0, 0, 50);
            Gl.glEnd();

            Gl.glBegin(Gl.GL_QUADS);

            Gl.glColor3d(0, 0, 0);

            ///////////////////

            int N = calcuteMethods.N1;
            float d = calcuteMethods.D;
            float x_0 = calcuteMethods.X_0;
            float y_0 = calcuteMethods.Y_0;
            float d_2 = d * d;


            foreach (int comp in geometricArray)
            {
                float y = y_0 - comp / N * d;
                float x = x_0 + comp % N * d - d;
                Gl.glVertex3d(x, y, 0);
                Gl.glVertex3d(x + d, y, 0);
                Gl.glVertex3d(x + d, y - d, 0);
                Gl.glVertex3d(x, y - d, 0);
                Gl.glColor3d(0, 0, 0);
            }

            Gl.glColor3d(255, 0, 0);

            foreach (int comp in geometricArray)
            {
                float y = y_0 - comp / N * d;
                float x = x_0 + comp % N * d - d;
                if (values.ContainsKey(comp))
                {
                    double z = (values[comp]);
                    Gl.glVertex3d(x, y, z);
                    Gl.glVertex3d(x + d, y, z);
                    Gl.glVertex3d(x + d, y - d, z);
                    Gl.glVertex3d(x, y - d, z);
                    Gl.glColor3f(255, 0, 0);
                }
                else
                {
                    Gl.glVertex3d(x, y, 0);
                    Gl.glVertex3d(x + d, y, 0);
                    Gl.glVertex3d(x + d, y - d, 0);
                    Gl.glVertex3d(x, y - d, 0);
                    Gl.glColor3f(y * 100, y % 255, x % 255);
                }
            }
            Console.WriteLine(geometricArray.Count);


            //////////////////
            //Gl.glBegin(Gl.GL_LINE_STRIP);
            Gl.glEnd();

            Gl.glPopMatrix();
            Gl.glFlush();
            AnT.Invalidate();
        }

        private void calculate_mesure()
        {
            geometricArray = calcuteMethods.calculate();
        }

        public Form1() {
            InitializeComponent();

            AnT.InitializeContexts();
        }

        private void Z_Scroll(object sender, EventArgs e) {
            Gl.glRotated(1, 0, 0, 0);
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {

        }
    }
}
