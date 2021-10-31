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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Y = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.AnT.Location = new System.Drawing.Point(66, 12);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(904, 855);
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
            this.trackBar.Location = new System.Drawing.Point(1024, 173);
            this.trackBar.Maximum = 360;
            this.trackBar.Minimum = -360;
            this.trackBar.Name = "trackBar";
            this.trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar.Size = new System.Drawing.Size(56, 447);
            this.trackBar.TabIndex = 1;
            this.trackBar.Value = 77;
            // 
            // Z
            // 
            this.Z.Location = new System.Drawing.Point(4, 148);
            this.Z.Maximum = 360;
            this.Z.Minimum = -360;
            this.Z.Name = "Z";
            this.Z.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Z.Size = new System.Drawing.Size(56, 447);
            this.Z.TabIndex = 2;
            this.Z.Value = -50;
            this.Z.Scroll += new System.EventHandler(this.Z_Scroll);
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(256, 873);
            this.X.Maximum = 360;
            this.X.Minimum = -360;
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(483, 56);
            this.X.TabIndex = 3;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Rossler Model",
            "Lorenz Model"});
            this.listBox1.Location = new System.Drawing.Point(1001, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 36);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(256, 935);
            this.Y.Maximum = 360;
            this.Y.Minimum = -360;
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(483, 56);
            this.Y.TabIndex = 5;
            this.Y.Value = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 66);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(152, 898);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(98, 56);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.WaitOnLoad = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 989);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.X);
            this.Controls.Add(this.Z);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.AnT);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.Timer RenderTime;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.TrackBar Z;
        private System.Windows.Forms.TrackBar X;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TrackBar Y;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

