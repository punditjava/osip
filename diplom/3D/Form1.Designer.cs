namespace _3D
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
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.RenderTime = new System.Windows.Forms.Timer(this.components);
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.Z = new System.Windows.Forms.TrackBar();
            this.X = new System.Windows.Forms.TrackBar();
            this.Y = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.entropy_box = new System.Windows.Forms.CheckBox();
            this.balance_box = new System.Windows.Forms.CheckBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.metric_entropy_entropy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.metric_entropy_balance = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
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
            this.AnT.Location = new System.Drawing.Point(50, 10);
            this.AnT.Margin = new System.Windows.Forms.Padding(2);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(1010, 714);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            // 
            // RenderTime
            // 
            this.RenderTime.Interval = 30;
            this.RenderTime.Tick += new System.EventHandler(this.RenderTime_Tick);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(1064, 154);
            this.trackBar.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar.Maximum = 360;
            this.trackBar.Minimum = -360;
            this.trackBar.Name = "trackBar";
            this.trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar.Size = new System.Drawing.Size(45, 363);
            this.trackBar.TabIndex = 1;
            // 
            // Z
            // 
            this.Z.Location = new System.Drawing.Point(3, 120);
            this.Z.Margin = new System.Windows.Forms.Padding(2);
            this.Z.Maximum = 360;
            this.Z.Minimum = -360;
            this.Z.Name = "Z";
            this.Z.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Z.Size = new System.Drawing.Size(45, 363);
            this.Z.TabIndex = 2;
            this.Z.Value = -50;
            this.Z.Scroll += new System.EventHandler(this.Z_Scroll);
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(470, 727);
            this.X.Margin = new System.Windows.Forms.Padding(2);
            this.X.Maximum = 360;
            this.X.Minimum = -360;
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(362, 45);
            this.X.TabIndex = 3;
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(88, 728);
            this.Y.Margin = new System.Windows.Forms.Padding(2);
            this.Y.Maximum = 360;
            this.Y.Minimum = -360;
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(362, 45);
            this.Y.TabIndex = 5;
            this.Y.Value = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 62);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 54);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(9, 727);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(74, 46);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.WaitOnLoad = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1123, 10);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(346, 152);
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(1358, 237);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(49, 26);
            this.textBox8.TabIndex = 40;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(1324, 237);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 20);
            this.label11.TabIndex = 39;
            this.label11.Text = "b = ";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(1262, 237);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(49, 26);
            this.textBox7.TabIndex = 38;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(1229, 237);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "a = ";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(1295, 394);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(88, 26);
            this.textBox6.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(1146, 396);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Обратных вершин = ";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(1177, 237);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(49, 26);
            this.textBox5.TabIndex = 34;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(1144, 237);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "R = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(1139, 214);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Изменить коэффициенты:";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(1285, 340);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(88, 26);
            this.textBox4.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1244, 344);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "D = ";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(1371, 305);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(36, 26);
            this.textBox3.TabIndex = 29;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(1275, 309);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Y области = ";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(1228, 305);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(36, 26);
            this.textBox2.TabIndex = 27;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1142, 309);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "X области = ";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(1196, 341);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(30, 26);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(1146, 344);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Iter = ";
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox9.Location = new System.Drawing.Point(1248, 467);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(111, 26);
            this.textBox9.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1146, 469);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Энтропия = ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1143, 626);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 61);
            this.button1.TabIndex = 44;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // entropy_box
            // 
            this.entropy_box.AutoSize = true;
            this.entropy_box.BackColor = System.Drawing.Color.Transparent;
            this.entropy_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entropy_box.Location = new System.Drawing.Point(1148, 437);
            this.entropy_box.Name = "entropy_box";
            this.entropy_box.Size = new System.Drawing.Size(188, 24);
            this.entropy_box.TabIndex = 45;
            this.entropy_box.Text = "Мера макс. энтропии";
            this.entropy_box.UseVisualStyleBackColor = false;
            this.entropy_box.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // balance_box
            // 
            this.balance_box.AutoSize = true;
            this.balance_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.balance_box.Location = new System.Drawing.Point(1152, 539);
            this.balance_box.Name = "balance_box";
            this.balance_box.Size = new System.Drawing.Size(137, 24);
            this.balance_box.TabIndex = 46;
            this.balance_box.Text = "Балансировка";
            this.balance_box.UseVisualStyleBackColor = true;
            this.balance_box.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.Blue;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox10.Location = new System.Drawing.Point(1285, 537);
            this.textBox10.Margin = new System.Windows.Forms.Padding(2);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(23, 26);
            this.textBox10.TabIndex = 47;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.Red;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox11.Location = new System.Drawing.Point(1341, 435);
            this.textBox11.Margin = new System.Windows.Forms.Padding(2);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(23, 26);
            this.textBox11.TabIndex = 48;
            // 
            // metric_entropy_entropy
            // 
            this.metric_entropy_entropy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metric_entropy_entropy.Location = new System.Drawing.Point(1356, 497);
            this.metric_entropy_entropy.Margin = new System.Windows.Forms.Padding(2);
            this.metric_entropy_entropy.Name = "metric_entropy_entropy";
            this.metric_entropy_entropy.Size = new System.Drawing.Size(111, 26);
            this.metric_entropy_entropy.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1149, 503);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Метрическая энтропия = ";
            // 
            // metric_entropy_balance
            // 
            this.metric_entropy_balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metric_entropy_balance.Location = new System.Drawing.Point(1356, 570);
            this.metric_entropy_balance.Margin = new System.Windows.Forms.Padding(2);
            this.metric_entropy_balance.Name = "metric_entropy_balance";
            this.metric_entropy_balance.Size = new System.Drawing.Size(111, 26);
            this.metric_entropy_balance.TabIndex = 52;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(1149, 576);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(203, 20);
            this.label12.TabIndex = 51;
            this.label12.Text = "Метрическая энтропия = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 804);
            this.Controls.Add(this.metric_entropy_balance);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.metric_entropy_entropy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.balance_box);
            this.Controls.Add(this.entropy_box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.Z);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.AnT);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.Timer RenderTime;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.TrackBar Z;
        private System.Windows.Forms.TrackBar X;
        private System.Windows.Forms.TrackBar Y;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox entropy_box;
        private System.Windows.Forms.CheckBox balance_box;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox metric_entropy_entropy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox metric_entropy_balance;
        private System.Windows.Forms.Label label12;
    }
}

