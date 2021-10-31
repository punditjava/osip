using System;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;
using Tao_OpenGL_Initialization_Test;

namespace _3D
{
    public partial class Form1 : Form
    {

        private readonly int countOfElements = 10000;
        private double[,] geometricArray;

        bool notCalculate = true;

        private readonly MethodSelector methodSelector = new MethodSelector(new MethodRungeKutta());

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

            listBox1.SetSelected(1, true);

            RenderTime.Start();
        }

        private void RenderTime_Tick(object sender, EventArgs e) {
            draw();
            
        }

        private void draw() {

            if (notCalculate) {
                geometricArray = methodSelector.calculate(countOfElements, 1, 1, 10);
                notCalculate = false;
            }

            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glClearColor(255, 255, 240, 1);

            Gl.glLoadIdentity();


            Gl.glTranslated(0, 0, -7 - trackBar.Value);
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

            Gl.glBegin(Gl.GL_LINE_STRIP);

            Gl.glColor3d(255, 0, 0);

            for (int ax = 0; ax < countOfElements; ax++) {
                Gl.glVertex3d(geometricArray[ax, 0], geometricArray[ax, 1], geometricArray[ax, 2]);

            }
            Gl.glEnd();

            Gl.glPopMatrix();
            Gl.glFlush();
            AnT.Invalidate();
        }



        public Form1() {
            InitializeComponent();

            AnT.InitializeContexts();
        }

        private void Z_Scroll(object sender, EventArgs e) {
            Gl.glRotated(Z.Value, 1, 0, 0);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
            if (listBox1.SelectedIndex == 1) {
                methodSelector.setFormula(new FormulaLorenzModel(10, 8 / 3, 28));
            }
            else {
                methodSelector.setFormula(new FormulaRosslerModel(0.2, 0.2, 5.7));
            }
            notCalculate = true;
        }
        
    }
}
