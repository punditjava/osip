﻿using System;
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

        private float alfa = -0.4f, beta =0.1f, omega = 2.05f;

        private float[,] GrapValuesArray;

        private bool notCalculate = true;
        private int pointPosition = 0;

        private float Mcoord_X = 0, Mcoord_Y = 0;

        private readonly MethodSelector method = new MethodSelector();
        private readonly int countOfMas = 10000;
        private float x0 = 0.5f, y0 = 0.5f;

        private readonly float zoom = 10f;

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

            listBox1.SetSelected(0, true);
            textBoxX0.Text = x0.ToString();
            textBoxY0.Text = y0.ToString();
            timer1.Start();
        }

        private void drawDiagram()
        {
            method.setFormula(new FormulaVanDerPol(alfa, beta, omega));

            if (notCalculate)
            {
                GrapValuesArray = method.calculate(countOfMas, x0, y0);

                notCalculate = false;
            }

            Gl.glBegin(Gl.GL_LINE_STRIP);
            Gl.glVertex2d(GrapValuesArray[0, 0], GrapValuesArray[0, 1]);
            for (int ax = 1; ax < countOfMas; ax += 2)
            {
                Gl.glVertex2d(GrapValuesArray[ax, 0], GrapValuesArray[ax, 1]);
            }
            Gl.glEnd();
            Gl.glPointSize(zoom / 2);
            Gl.glColor3f(255, 0, 0);
            Gl.glBegin(Gl.GL_POINTS);
            Gl.glVertex2d(GrapValuesArray[pointPosition, 0], GrapValuesArray[pointPosition, 1]);
            Gl.glEnd();
            Gl.glPointSize(1);
        }

        private void simpleOpenGlControl1MouseMove(object sender, MouseEventArgs e) {
            Mcoord_X = e.X;
            Mcoord_Y = e.Y;
        }

        private void timer1Tick(object sender, EventArgs e) {

            if (pointPosition == countOfMas - 1)
                pointPosition = 0;
            draw();
          
            pointPosition++;
        }

        private void draw() {
            Draw draw = new Draw(zoom / 2);

            draw.drawSystemOfCoordinates();
            outputLabes();
            drawDiagram();

            Gl.glPopMatrix();

            PrintText2D.PrintText(devX * Mcoord_X + 0.2f,
                (float)ScreenH - devY * Mcoord_Y + 0.4f,
                "[ x: " + (devX * Mcoord_X - zoom / 2f).ToString()
                + " ; y: " + ((float)ScreenH - devY * Mcoord_Y - (zoom / 2)).ToString() + "]");

            AnT.Invalidate();
        }
        private void outputLabes() {
            printAlfaLabel.Text = alfa.ToString();
            printBetaLabel.Text = beta.ToString();
            printOmegaLabel.Text = omega.ToString();
        }
        private void trackBar1Scroll(object sender, EventArgs e) {
            alfa = (float)trackBar1.Value / 100;
            notCalculate = true;
        }
        private void trackBar2Scroll(object sender, EventArgs e) {
            beta = (float)trackBar2.Value / 100;
            notCalculate = true;
        }

        private void trackBar3Scroll(object sender, EventArgs e) {
            omega = (float)trackBar3.Value / 100;
            notCalculate = true;
        }
        private void listBox1SelectedIndexChanged(object sender, EventArgs e) {
            if (listBox1.SelectedIndex == 1)
                method.setCalculateMethod(new MethodRungeKutta());
            else method.setCalculateMethod(new MethodEulera());
            notCalculate = true;
        }

        private void textBoxX0TextChanged(object sender, EventArgs e) {
            try {
                x0 = float.Parse(textBoxX0.Text);
                notCalculate = true;
            }
            catch (FormatException) {
                notCalculate = false;
            }
        }

        private void textBoxY0TextChanged(object sender, EventArgs e) {
            try {
                y0 = float.Parse(textBoxY0.Text);
                notCalculate = true;
            }
            catch (FormatException) {
                notCalculate = false;
            }
        }
    }
}
