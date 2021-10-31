using System;
using Tao.OpenGl;


namespace Tao_OpenGL_Initialization_Test
{

    class Draw
    {

        private readonly float sizeOfSystem;
        private readonly int[] components;
        private readonly float d;
        private readonly int N;
        private readonly float x_0;
        private readonly float y_0;
        public Draw(float sizeOfSystem, int [] components, float d, int N, float x_0, float y_0) {
            this.sizeOfSystem = sizeOfSystem;
            this.components = components;
            this.d = d;
            this.N = N;
            this.x_0 = x_0;
            this.y_0 = y_0;
        }

        public void drawSystemOfCoordinates(int num) {
            //Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            Gl.glLoadIdentity();
            Gl.glColor3f(0, 0, 0);
            Gl.glPushMatrix();
            Gl.glTranslated(num * sizeOfSystem,sizeOfSystem, 0);


            Gl.glBegin(Gl.GL_LINES);
            drawAxis();
            //drawArrows();
            Gl.glEnd();

            drawNet(num);
            //drawSigna();


        }

        private void drawSigna() {
            PrintText2D.PrintText(sizeOfSystem + 0.1f, 0, "x");
            PrintText2D.PrintText(0.3f, sizeOfSystem - 0.1f, "y");
        }
        private void drawAxis() {
            Gl.glColor3f(255, 0, 0);
            Gl.glVertex2d(sizeOfSystem, -sizeOfSystem);
            Gl.glVertex2d(sizeOfSystem, sizeOfSystem);

            //Gl.glVertex2d(-sizeOfSystem, 0);
            //Gl.glVertex2d(sizeOfSystem, 0);
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
        private void drawNet(int num) {
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
            int Num1 = 0;
            int Num2 = 0;
            switch (num)
            {
                case 1:
                    Num1 = N * N + 1;
                    break;
                case 3:
                    Num1 = N * N;
                    break;
                default:
                    Num1 = N * N * 3 + 1;
                    break;
            }
             foreach (int comp in components)
            {
                float y = y_0 - (comp) / N * d;
                float x = x_0 + (comp) % N * d;
                Gl.glRectf(x, y, x + d, y - d);
                //Gl.glColor3f(y*100, y % 255, x % 255);
            }
            Gl.glBegin(Gl.GL_LINE_STRIP);
            Gl.glEnd();

        }
    }

}
