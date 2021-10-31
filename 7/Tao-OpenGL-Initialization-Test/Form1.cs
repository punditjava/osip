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

        private bool notCalculate = false;
        private int pointPosition = 0;

        private Algoritm algoritm = new Algoritm();

        private float Mcoord_X = 0, Mcoord_Y = 0;

        private readonly int countOfMas = 10000;

        private readonly float zoom = 2f;
        private int[] comp;
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


            algoritm.x_0 = -1f;
            algoritm.y_0 = 1f;
            algoritm.z_0 = 1f;
            algoritm.iter = 2;
            textBoxX0.Text = algoritm.x_0.ToString();
            textBoxY0.Text = algoritm.y_0.ToString();
            textBox1.Text = algoritm.iter.ToString();
            //Thread thread = new Thread(new ThreadStart(calculate_mesure));
            //thread.Start();
            //thread.Join();
            algoritm.x1 = 1;
            algoritm.y1 = 0;
            algoritm.z1 = 0;
            algoritm.x2 = 0;
            algoritm.y2 = 1;
            algoritm.z2 = 0;
            algoritm.x3 = 0;
            algoritm.y3 = 0;
            algoritm.z3 = 1;
            x1.Text = algoritm.x1.ToString();
            y1.Text = algoritm.y1.ToString();
            x2.Text = algoritm.x2.ToString();
            y2.Text = algoritm.y2.ToString();
            x3.Text = algoritm.x3.ToString();
            y3.Text = algoritm.y3.ToString();
            z1.Text = algoritm.z1.ToString();
            z2.Text = algoritm.z2.ToString();
            z3.Text = algoritm.z3.ToString();

            algoritm.calculate_mesure();
            textBoxD.Text = algoritm.d.ToString();
            textBoxT.Text = algoritm.timer.ToString();
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
          
            pointPosition++;
        }

        private void draw() {

            if (notCalculate)
            {
                Thread thread = new Thread(new ThreadStart(calculate_mesure), 54000000);
                thread.Start();
                thread.Join();

                textBoxD.Text = algoritm.d.ToString();
                textBoxT.Text = algoritm.timer.ToString();
                notCalculate = false;
            }

            Draw draw = new Draw(zoom / 2, algoritm.comp, algoritm.d, algoritm.N, algoritm.x_0, algoritm.y_0);

            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);
            draw.drawSystemOfCoordinates(1);
            draw.drawSystemOfCoordinates(3);
            draw.drawSystemOfCoordinates(5);
            draw.drawSystemOfCoordinates(7);
            //outputLabes();


            //Gl.glPopMatrix();

            PrintText2D.PrintText(devX * Mcoord_X + 0.2f,
                (float)ScreenH - devY * Mcoord_Y + 0.4f,
                "[ x: " + (devX * Mcoord_X - zoom / 2f).ToString()
                + " ; y: " + ((float)ScreenH - devY * Mcoord_Y - (zoom / 2)).ToString() + "]");

            AnT.Invalidate();
        }

        private void calculate_mesure()
        {
            algoritm.calculate_mesure();
        }

        //private void outputLabes() {
        //    printAlfaLabel.Text = algoritm.alfa.ToString();
        //    printBetaLabel.Text = algoritm.beta.ToString();
        //}
        //private void trackBar1Scroll(object sender, EventArgs e) {
        //    algoritm.alfa = (float)trackBar1.Value / 100;
        //    notCalculate = true;
        //}
        //private void trackBar2Scroll(object sender, EventArgs e) {
        //    algoritm.beta = (float)trackBar2.Value / 100;
        //    notCalculate = true;
        //}

        private void textBoxI_TextChanged(object sender, EventArgs e)
        {
            try
            {
                algoritm.iter = int.Parse(textBox1.Text);
            }
            catch (FormatException)
            {
            }
        }

        private void x1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                algoritm.x1 = float.Parse(x1.Text);
            }
            catch (FormatException)
            {
            }
        }

        private void y1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                algoritm.y1 = float.Parse(y1.Text);
            }
            catch (FormatException)
            {
            }
        }

        private void x2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                algoritm.x2 = float.Parse(x2.Text);
            }
            catch (FormatException)
            {
            }
        }

        private void y2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                algoritm.y2 = float.Parse(y2.Text);
            }
            catch (FormatException)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notCalculate = true;
        }

        private void z1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                algoritm.z1 = float.Parse(z1.Text);
            }
            catch (FormatException)
            {
            }
        }

        private void z2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                algoritm.z2 = float.Parse(z2.Text);
            }
            catch (FormatException)
            {
            }
        }

        private void x3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                algoritm.x3 = float.Parse(x3.Text);
            }
            catch (FormatException)
            {
            }
        }

        private void y3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                algoritm.y3 = float.Parse(y3.Text);
            }
            catch (FormatException)
            {
            }
        }

        private void z3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                algoritm.z3 = float.Parse(z3.Text);
            }
            catch (FormatException)
            {
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBoxX0TextChanged(object sender, EventArgs e) {
            algoritm.x_0 = float.Parse(textBoxX0.Text);
        }

        private void textBoxY0TextChanged(object sender, EventArgs e) {
            algoritm.y_0 = float.Parse(textBoxY0.Text);
        }
    }
}
