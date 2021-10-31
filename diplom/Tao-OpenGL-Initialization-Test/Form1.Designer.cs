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
            this.AnT = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.calcuteMethodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.methodRungeKuttaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calcuteMethodsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.methodEuleraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.methodRungeKuttaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.calcuteMethodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodRungeKuttaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calcuteMethodsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodEuleraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodRungeKuttaBindingSource1)).BeginInit();
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
            this.AnT.Location = new System.Drawing.Point(12, 12);
            this.AnT.Name = "AnT";
            this.AnT.Size = new System.Drawing.Size(1563, 1250);
            this.AnT.StencilBits = ((byte)(0));
            this.AnT.TabIndex = 0;
            this.AnT.MouseMove += new System.Windows.Forms.MouseEventHandler(this.simpleOpenGlControl1MouseMove);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1Tick);
            // 
            // methodRungeKuttaBindingSource1
            // 
            this.methodRungeKuttaBindingSource1.DataSource = typeof(Tao_OpenGL_Initialization_Test.MethodRungeKutta);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1905, 1067);
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

        }

        #endregion
    
        private Tao.Platform.Windows.SimpleOpenGlControl AnT;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource calcuteMethodsBindingSource;
        private System.Windows.Forms.BindingSource methodRungeKuttaBindingSource;
        private System.Windows.Forms.BindingSource calcuteMethodsBindingSource1;
        private System.Windows.Forms.BindingSource methodEuleraBindingSource;
        private System.Windows.Forms.BindingSource methodRungeKuttaBindingSource1;
    }
}

