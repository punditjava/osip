namespace Tao_OpenGL_Initialization_Test
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label3;
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.calcuteMethodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.methodRungeKuttaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calcuteMethodsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.methodEuleraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxX0 = new System.Windows.Forms.TextBox();
            this.textBoxY0 = new System.Windows.Forms.TextBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.x1 = new System.Windows.Forms.TextBox();
            this.y1 = new System.Windows.Forms.TextBox();
            this.x2 = new System.Windows.Forms.TextBox();
            this.y2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.z1 = new System.Windows.Forms.TextBox();
            this.z2 = new System.Windows.Forms.TextBox();
            this.x3 = new System.Windows.Forms.TextBox();
            this.y3 = new System.Windows.Forms.TextBox();
            this.z3 = new System.Windows.Forms.TextBox();
            this.methodRungeKuttaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.calcuteMethodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodRungeKuttaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcuteMethodsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodEuleraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodRungeKuttaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(26, 565);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(71, 29);
            label1.TabIndex = 15;
            label1.Text = "x_0 = ";
            label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(183, 561);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 33);
            label2.TabIndex = 16;
            label2.Text = "y_0 = ";
            label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.Location = new System.Drawing.Point(26, 672);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(139, 60);
            label4.TabIndex = 23;
            label4.Text = "Диаметр разбиения = ";
            label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label5.Location = new System.Drawing.Point(26, 759);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(124, 60);
            label5.TabIndex = 25;
            label5.Text = "Время = ";
            label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label6.Location = new System.Drawing.Point(715, 565);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(124, 60);
            label6.TabIndex = 31;
            label6.Text = "Матрица";
            label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label7.Location = new System.Drawing.Point(145, -4);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(94, 29);
            label7.TabIndex = 38;
            label7.Text = "z = 1  ";
            label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label8
            // 
            label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label8.Location = new System.Drawing.Point(624, -4);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(94, 29);
            label8.TabIndex = 39;
            label8.Text = "y = 1  ";
            label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label9
            // 
            label9.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label9.Location = new System.Drawing.Point(1041, -4);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(94, 29);
            label9.TabIndex = 40;
            label9.Text = "x = 1  ";
            label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label10
            // 
            label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label10.Location = new System.Drawing.Point(1526, -4);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(94, 29);
            label10.TabIndex = 41;
            label10.Text = "t = 1  ";
            label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // AnT
            // 
            this.AnT.AccumBits = ((byte)(0));
            this.AnT.AutoCheckErrors = false;
            this.AnT.AutoFinish = false;
            this.AnT.AutoMakeCurrent = true;
            this.AnT.AutoSwapBuffers = true;
            this.AnT.BackColor = System.Drawing.Color.Black;
            this.AnT.ColorBits = ((byte)(32));
            this.AnT.DepthBits = ((byte)(16));
            this.AnT.Location = new System.Drawing.Point(12, 28);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(1816, 485);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            this.AnT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.simpleOpenGlControl1MouseMove);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1Tick);
            // 
            // textBoxX0
            // 
            this.textBoxX0.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxX0.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX0.Location = new System.Drawing.Point(90, 565);
            this.textBoxX0.Name = "textBoxX0";
            this.textBoxX0.Size = new System.Drawing.Size(51, 29);
            this.textBoxX0.TabIndex = 19;
            this.textBoxX0.TextChanged += new System.EventHandler(this.textBoxX0TextChanged);
            // 
            // textBoxY0
            // 
            this.textBoxY0.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxY0.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxY0.Location = new System.Drawing.Point(248, 565);
            this.textBoxY0.Name = "textBoxY0";
            this.textBoxY0.Size = new System.Drawing.Size(53, 29);
            this.textBoxY0.TabIndex = 20;
            this.textBoxY0.TextChanged += new System.EventHandler(this.textBoxY0TextChanged);
            // 
            // textBoxD
            // 
            this.textBoxD.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxD.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxD.Location = new System.Drawing.Point(179, 697);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(85, 29);
            this.textBoxD.TabIndex = 24;
            // 
            // textBoxT
            // 
            this.textBoxT.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxT.Location = new System.Drawing.Point(179, 784);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(85, 29);
            this.textBoxT.TabIndex = 26;
            // 
            // x1
            // 
            this.x1.BackColor = System.Drawing.SystemColors.Menu;
            this.x1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x1.Location = new System.Drawing.Point(720, 642);
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(51, 29);
            this.x1.TabIndex = 27;
            this.x1.TextChanged += new System.EventHandler(this.x1_TextChanged);
            // 
            // y1
            // 
            this.y1.BackColor = System.Drawing.SystemColors.Menu;
            this.y1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y1.Location = new System.Drawing.Point(777, 642);
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(51, 29);
            this.y1.TabIndex = 28;
            this.y1.TextChanged += new System.EventHandler(this.y1_TextChanged);
            // 
            // x2
            // 
            this.x2.BackColor = System.Drawing.SystemColors.Menu;
            this.x2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x2.Location = new System.Drawing.Point(720, 683);
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(51, 29);
            this.x2.TabIndex = 29;
            this.x2.TextChanged += new System.EventHandler(this.x2_TextChanged);
            // 
            // y2
            // 
            this.y2.BackColor = System.Drawing.SystemColors.Menu;
            this.y2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y2.Location = new System.Drawing.Point(777, 683);
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(51, 29);
            this.y2.TabIndex = 30;
            this.y2.TextChanged += new System.EventHandler(this.y2_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(914, 597);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(418, 90);
            this.button1.TabIndex = 32;
            this.button1.Text = "Рисовать!!!!!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // z1
            // 
            this.z1.BackColor = System.Drawing.SystemColors.Menu;
            this.z1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.z1.Location = new System.Drawing.Point(834, 642);
            this.z1.Name = "z1";
            this.z1.Size = new System.Drawing.Size(51, 29);
            this.z1.TabIndex = 33;
            this.z1.TextChanged += new System.EventHandler(this.z1_TextChanged);
            // 
            // z2
            // 
            this.z2.BackColor = System.Drawing.SystemColors.Menu;
            this.z2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.z2.Location = new System.Drawing.Point(834, 683);
            this.z2.Name = "z2";
            this.z2.Size = new System.Drawing.Size(51, 29);
            this.z2.TabIndex = 34;
            this.z2.TextChanged += new System.EventHandler(this.z2_TextChanged);
            // 
            // x3
            // 
            this.x3.BackColor = System.Drawing.SystemColors.Menu;
            this.x3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x3.Location = new System.Drawing.Point(720, 724);
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(51, 29);
            this.x3.TabIndex = 35;
            this.x3.TextChanged += new System.EventHandler(this.x3_TextChanged);
            // 
            // y3
            // 
            this.y3.BackColor = System.Drawing.SystemColors.Menu;
            this.y3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.y3.Location = new System.Drawing.Point(777, 724);
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(51, 29);
            this.y3.TabIndex = 36;
            this.y3.TextChanged += new System.EventHandler(this.y3_TextChanged);
            // 
            // z3
            // 
            this.z3.BackColor = System.Drawing.SystemColors.Menu;
            this.z3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.z3.Location = new System.Drawing.Point(834, 724);
            this.z3.Name = "z3";
            this.z3.Size = new System.Drawing.Size(51, 29);
            this.z3.TabIndex = 37;
            this.z3.TextChanged += new System.EventHandler(this.z3_TextChanged);
            // 
            // methodRungeKuttaBindingSource1
            // 
            this.methodRungeKuttaBindingSource1.DataSource = typeof(Tao_OpenGL_Initialization_Test.MethodRungeKutta);
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(26, 607);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(139, 60);
            label3.TabIndex = 42;
            label3.Text = "Итерации = ";
            label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(171, 638);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(53, 29);
            this.textBox1.TabIndex = 43;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1840, 1032);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(label3);
            this.Controls.Add(label10);
            this.Controls.Add(label9);
            this.Controls.Add(label8);
            this.Controls.Add(label7);
            this.Controls.Add(this.z3);
            this.Controls.Add(this.y3);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.z2);
            this.Controls.Add(this.z1);
            this.Controls.Add(this.button1);
            this.Controls.Add(label6);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x1);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(label5);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(label4);
            this.Controls.Add(this.textBoxY0);
            this.Controls.Add(this.textBoxX0);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.AnT);
            this.Name = "Form1";
            this.Text = "a";
            this.Load += new System.EventHandler(this.form1Load);
            ((System.ComponentModel.ISupportInitialize)(this.calcuteMethodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodRungeKuttaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcuteMethodsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodEuleraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodRungeKuttaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    
        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource calcuteMethodsBindingSource;
        private System.Windows.Forms.BindingSource methodRungeKuttaBindingSource;
        private System.Windows.Forms.BindingSource calcuteMethodsBindingSource1;
        private System.Windows.Forms.BindingSource methodEuleraBindingSource;
        private System.Windows.Forms.BindingSource methodRungeKuttaBindingSource1;
        private System.Windows.Forms.TextBox textBoxX0;
        private System.Windows.Forms.TextBox textBoxY0;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.TextBox x1;
        private System.Windows.Forms.TextBox y1;
        private System.Windows.Forms.TextBox x2;
        private System.Windows.Forms.TextBox y2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox z1;
        private System.Windows.Forms.TextBox z2;
        private System.Windows.Forms.TextBox x3;
        private System.Windows.Forms.TextBox y3;
        private System.Windows.Forms.TextBox z3;
        private System.Windows.Forms.TextBox textBox1;
    }
}

