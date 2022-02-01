using MathNet.Numerics.LinearAlgebra;
using osiptest;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;
using Tao_OpenGL_Initialization_Test;
using System.Linq;
using MathNet.Numerics.Statistics;
namespace _3D
{
    public partial class Form1 : Form
    {
        private List<int> geometricArray;
        Vector<double> vec;
        private double[] gr;
        private float[,] coor;
        double[] vs;
        private Dictionary<int, double> valuesBal;
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
            //formula = new FormulaJuliaModel();
            calcuteMethods = new MethodIteration(formula);

            calcuteMethods.X_0 = -3.5f;
            calcuteMethods.Y_0 = 3.5f;
            textBox7.Text = formula.Alfa.ToString();
            textBox8.Text = formula.Beta.ToString();
            textBox5.Text = formula.RR.ToString();
            textBox2.Text = calcuteMethods.X_0.ToString();
            textBox3.Text = calcuteMethods.Y_0.ToString();
            calcuteMethods.Iter = 4;
            textBox1.Text = calcuteMethods.Iter.ToString();

            RenderTime.Start();
        }

        private void RenderTime_Tick(object sender, EventArgs e) {
            draw();
            
        }

        private void draw() {

            if (notCalculate) {
                Thread t = new Thread(new ThreadStart(calculate_mesure), 900000000);
                t.Start();
                t.Join();
                SparseMatrix sm = new SparseMatrix(calcuteMethods.Graph);
                EigenValues ev = new EigenValues(sm);
                double lambda;
                ev.Power(1e-10, out vec, out lambda);
                textBox9.Text = Math.Log(lambda).ToString();
                gr = sm.get_result(vec, lambda);

                metric_entropy(sm.sparse_array, gr, metric_entropy_entropy, lambda);

                SparseMatrixBal smb = new SparseMatrixBal(calcuteMethods.Graph);
                Balance balance = new Balance(smb, 1e-2);

                valuesBal = balance.balancing();
                metric_entropy_balance.Text = balance.get_M().ToString();
                vs = valuesBal.Values.ToArray();
                normalize(calcuteMethods.D);
                put_coor();
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

            Gl.glBegin(Gl.GL_QUADS);

            Gl.glColor3d(0, 0, 0);

            ///////////////////

            int N = calcuteMethods.N1;
            float d = calcuteMethods.D;
            textBox4.Text = d.ToString();
            float x_0 = calcuteMethods.X_0;
            float y_0 = calcuteMethods.Y_0;
            float d_2 = d * d;
            double z = 0, z_bal = 0;
            //var correlation = Correlation.Pearson(gr, vs);
            //Console.WriteLine(correlation);
            Gl.glColor3d(0, 0, 0);
            for (int i = 0; i < coor.Length / 4; i++)
            {
                //Gl.glColor3d(0, 0, 0);
                Gl.glVertex3d(coor[i, 0], coor[i, 1], 0);
                Gl.glVertex3d(coor[i, 2], coor[i, 1], 0);
                Gl.glVertex3d(coor[i, 2], coor[i, 3], 0);
                Gl.glVertex3d(coor[i, 0], coor[i, 3], 0);
            }

            if (entropy_box.Checked)
            {
                Gl.glColor3d(1, 0, 0);
                for (int i = 0; i < coor.Length / 4; i++)
                {
                    //Gl.glColor3d(1, 0, 0);
                    z = gr[i];
                    Gl.glVertex3d(coor[i, 0], coor[i, 1], z);
                    Gl.glVertex3d(coor[i, 2], coor[i, 1], z);
                    Gl.glVertex3d(coor[i, 2], coor[i, 3], z);
                    Gl.glVertex3d(coor[i, 0], coor[i, 3], z);
                }
                Gl.glColor3d(0, 0, 0);
            }
            if (balance_box.Checked)
            {
                Gl.glColor3d(0, 0, 1);
                for (int i = 0; i < coor.Length / 4; i++)
                {
                    
                    z_bal = vs[i];
                    Gl.glVertex3d(coor[i, 0], coor[i, 1], z_bal);
                    Gl.glVertex3d(coor[i, 2], coor[i, 1], z_bal);
                    Gl.glVertex3d(coor[i, 2], coor[i, 3], z_bal);
                    Gl.glVertex3d(coor[i, 0], coor[i, 3], z_bal);

                }
                Gl.glColor3d(0, 0, 0);
            }
            //////////////////
            //Gl.glBegin(Gl.GL_LINE_STRIP);
            Gl.glEnd();

            Gl.glPopMatrix();
            Gl.glFlush();
            AnT.Invalidate();
        }

        private void metric_entropy(int[][] sm, double[] gr, TextBox metric_entropy_entropy, double lama)
        {
            double all_sum = 0;
            double all_str = 0;
            for (int i=0; i < sm.Length; i++)
            {
                foreach(int j in sm[i])
                {
                    double pi =  gr[j] / lama;
                    all_str += pi * Math.Log(pi);
                }
                all_sum += gr[i] * Math.Log(gr[i]);
            }
            double metr_entr = all_sum - all_str;
            metric_entropy_entropy.Text = metr_entr.ToString();

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
            Gl.glRotated(Z.Value, 1, 0, 0);
        }

        private void normalize(float d)
        {
            float d_2 = d * d;
            double[] result = new double[gr.Length];
            for (int i = 0; i < gr.Length; i++)
            {
                gr[i] = gr[i] / d_2;
                vs[i] = vs[i] / d_2;
            }
            //double max = result.Max();
            //double min = result.Min();
            //for (int k= 0; k < gr.Length; k++)
            //{
            //    gr[k] = (result[k] - min) / (max - min);
            //}
        }

        private void put_coor()
        {
            int k = 0;

            int N = calcuteMethods.N1;
            float d = calcuteMethods.D;
            float x_0 = calcuteMethods.X_0;
            float y_0 = calcuteMethods.Y_0;

            float y, x;
            coor = new float[geometricArray.Count, 4];
            foreach (int comp in geometricArray)
            {
                y = y_0 - (comp - 1) / N * d;
                x = x_0 + (comp - 1) % N * d;
                coor[k, 0] = x;
                coor[k, 1] = y;
                coor[k, 2] = x + d;
                coor[k, 3] = y - d;
                k++;
            }
            textBox6.Text = (coor.Length / 4).ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                calcuteMethods.X_0 = float.Parse(textBox2.Text);
            }
            catch (FormatException)
            {
                notCalculate = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                calcuteMethods.Y_0 = float.Parse(textBox3.Text);
            }
            catch (FormatException)
            {
                notCalculate = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                calcuteMethods.Iter = int.Parse(textBox1.Text);
            }
            catch (FormatException)
            {
                notCalculate = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            notCalculate = true;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                formula.Alfa = float.Parse(textBox7.Text);
            }
            catch (FormatException)
            {
                notCalculate = false;
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                formula.Beta = float.Parse(textBox8.Text);
            }
            catch (FormatException)
            {
                notCalculate = false;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {
                formula.RR = float.Parse(textBox5.Text);
            }
            catch (FormatException)
            {
                notCalculate = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
