using System;
using System.Threading;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;

namespace Tao_OpenGL_Initialization_Test
{
    public partial class Form1 : Form
    {
        private double ScreenW, ScreenH;

        private float devX;
        private float devY;

        private bool notCalculate = true;
        private int pointPosition = 0;

        private Algoritm algoritm = new Algoritm();

        private float Mcoord_X = 0, Mcoord_Y = 0;

        private readonly int countOfMas = 10000;

        private float[,] coor;

        private readonly float zoom = 7f;
        private readonly float sizeOfSystem = 3.5f;
        public Form1() {
            InitializeComponent();
            if (AnT != null) {
                AnT.InitializeContexts();
            }

        }


        private void form1Load(object sender, EventArgs e) {
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE);
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();

            if ((float)AnT.Width <= (float)AnT.Height) {
                ScreenW = zoom;
                ScreenH = zoom * (float)AnT.Height / (float)AnT.Width;
                Glu.gluOrtho2D(0.0, ScreenW, 0.0, ScreenH);
            }
            else {
                ScreenW = zoom * (float)AnT.Width / (float)AnT.Height;
                ScreenH = zoom;
                Glu.gluOrtho2D(0.0, zoom * (float)AnT.Width / (float)AnT.Height, 0.0, zoom);
            }
            devX = (float)ScreenW / (float)AnT.Width;
            devY = (float)ScreenH / (float)AnT.Height;
            Gl.glMatrixMode(Gl.GL_MODELVIEW);


            algoritm.x_0 = -3.5f;
            algoritm.y_0 = 3.5f;
            algoritm.iter = 5;
            //Thread thread = new Thread(new ThreadStart(calculate_mesure));
            //thread.Start();
            //thread.Join();
            algoritm.x1 = 1;
            algoritm.y1 = -1;
            algoritm.x2 = 1;
            algoritm.y2 = 1;
            timer1.Start();
        }   

        private void simpleOpenGlControl1MouseMove(object sender, MouseEventArgs e) {
            Mcoord_X = e.X;
            Mcoord_Y = e.Y;
        }

        private void timer1Tick(object sender, EventArgs e) {

            if (pointPosition == countOfMas - 1)
                pointPosition = 0;
            
            draw();
            //AnT.Invalidate();
            pointPosition++;
        }

        private void draw() {

            if (notCalculate)
            {
                Thread thread = new Thread(new ThreadStart(calculate_mesure), 1000000000);
                thread.Start();
                thread.Join();

                put_coor();
                //drawSystemOfCoordinates();
                //drawFigure();

                notCalculate = false;
            }

            drawSystemOfCoordinates();
            drawFigure();
            //drawFigure();
            //outputLabes();


            Gl.glPopMatrix();

            //PrintText2D.PrintText(devX * Mcoord_X + 0.2f,
            //    (float)ScreenH - devY * Mcoord_Y + 0.4f,
            //    "[ x: " + (devX * Mcoord_X - zoom / 2f).ToString()
            //    + " ; y: " + ((float)ScreenH - devY * Mcoord_Y - (zoom / 2)).ToString() + "]");
            
            Gl.glFlush();
            AnT.Invalidate();
        }

        private void drawFigure()
        {
            for (int i=0; i < coor.Length / 4; i++) {

                Gl.glRectd(coor[i, 0], coor[i, 1], coor[i,2], coor[i,3]);
            }
            PrintText2D.PrintText(-1.65f, -1.95f, "P");
            PrintText2D.PrintText(-0.2f, 2.2f, "H");
            PrintText2D.PrintText(3.1f, -1.3f, "Q");
        }

        private void put_coor()
        {
            int k = 0;

            int N = algoritm.N;
            float d = algoritm.d;
            float y_0 = algoritm.y_0;
            float x_0 = algoritm.x_0;
            float y, x;
            coor = new float[algoritm.comp.Length, 4];
            foreach (int comp in algoritm.comp)
            {
                y = y_0 - (comp - 1) / N * d;
                x = x_0 + (comp - 1) % N * d;
                coor[k,0] = x;
                coor[k,1] = y;
                coor[k,2] = x + d;
                coor[k,3] = y - d;
                k++;
            }

        }

        private void calculate_mesure()
        {
            algoritm.calculate_mesure();
        }

        public void drawSystemOfCoordinates() {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glColor3f(0, 0, 0);
            Gl.glPushMatrix();
            Gl.glTranslated(sizeOfSystem, sizeOfSystem, 0);


            Gl.glBegin(Gl.GL_LINES);
            drawAxis();
            drawArrows();
            Gl.glEnd();

            //drawNet();
            drawSigna();


        }

        private void drawSigna() {
            PrintText2D.PrintText(sizeOfSystem + 0.1f, 0, "x");
            PrintText2D.PrintText(0.3f, sizeOfSystem - 0.1f, "y");
        }
        private void drawAxis() {
            Gl.glVertex2d(0, -sizeOfSystem);
            Gl.glVertex2d(0, sizeOfSystem);

            Gl.glVertex2d(-sizeOfSystem, 0);
            Gl.glVertex2d(sizeOfSystem, 0);
        }
        private void drawArrows() {
            float v = sizeOfSystem - 0.1f;
            Gl.glVertex2d(0, sizeOfSystem);
            Gl.glVertex2d(0.1, v);
            Gl.glVertex2d(0, sizeOfSystem);
            Gl.glVertex2d(-0.1, v);

            Gl.glVertex2d(sizeOfSystem, 0);
            Gl.glVertex2d(v, 0.1);
            Gl.glVertex2d(sizeOfSystem, 0);
            Gl.glVertex2d(v, -0.1);
        }
        private void drawNet() {
            Gl.glColor3f(0, 0, 255);
            Gl.glBegin(Gl.GL_LINE_STRIP);
            //for (float bx = -sizeOfSystem; bx <= sizeOfSystem; bx += d)
            //{
            //    Gl.glBegin(Gl.GL_LINE_STRIP);
            //    for (float ax = -sizeOfSystem; ax <= sizeOfSystem; ax += d)
            //    {
            //        Gl.glVertex2d(bx, ax);
            //    }
            //    Gl.glEnd();
            //}
            //Gl.glBegin(Gl.GL_LINE_STRIP);
            //for (float bx = -sizeOfSystem; bx <= sizeOfSystem; bx += d)
            //{
            //    Gl.glBegin(Gl.GL_LINE_STRIP);
            //    for (float ax = -sizeOfSystem; ax <= sizeOfSystem; ax += d)
            //    {
            //        Gl.glVertex2d(ax, bx);
            //    }
            //    Gl.glEnd();
            //}
            Gl.glEnd();
            Gl.glColor3f(0, 0, 0);
           
            Gl.glBegin(Gl.GL_LINE_STRIP);
            Gl.glEnd();

        }
    }
}
