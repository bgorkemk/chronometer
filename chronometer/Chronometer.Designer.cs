namespace chronometer
{
    partial class Chronometer
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelDkal = new System.Windows.Forms.Label();
            this.labelSnal = new System.Windows.Forms.Label();
            this.buttonBasla = new System.Windows.Forms.Button();
            this.numericUpDownDK = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSN = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonDur = new System.Windows.Forms.Button();
            this.textBoxdk = new System.Windows.Forms.TextBox();
            this.textBoxsn = new System.Windows.Forms.TextBox();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labelOran = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSN)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDkal
            // 
            this.labelDkal.AutoSize = true;
            this.labelDkal.Location = new System.Drawing.Point(70, 80);
            this.labelDkal.Name = "labelDkal";
            this.labelDkal.Size = new System.Drawing.Size(99, 13);
            this.labelDkal.TabIndex = 2;
            this.labelDkal.Text = "Dakika Gir          >>";
            // 
            // labelSnal
            // 
            this.labelSnal.AutoSize = true;
            this.labelSnal.Location = new System.Drawing.Point(69, 108);
            this.labelSnal.Name = "labelSnal";
            this.labelSnal.Size = new System.Drawing.Size(100, 13);
            this.labelSnal.TabIndex = 3;
            this.labelSnal.Text = "Kac Saniye Kala >>";
            // 
            // buttonBasla
            // 
            this.buttonBasla.Location = new System.Drawing.Point(70, 145);
            this.buttonBasla.Name = "buttonBasla";
            this.buttonBasla.Size = new System.Drawing.Size(80, 25);
            this.buttonBasla.TabIndex = 4;
            this.buttonBasla.Text = "Basla";
            this.buttonBasla.UseVisualStyleBackColor = true;
            this.buttonBasla.Click += new System.EventHandler(this.buttonBasla_Click);
            // 
            // numericUpDownDK
            // 
            this.numericUpDownDK.Location = new System.Drawing.Point(184, 78);
            this.numericUpDownDK.Name = "numericUpDownDK";
            this.numericUpDownDK.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownDK.TabIndex = 5;
            // 
            // numericUpDownSN
            // 
            this.numericUpDownSN.Location = new System.Drawing.Point(184, 106);
            this.numericUpDownSN.Name = "numericUpDownSN";
            this.numericUpDownSN.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownSN.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonDur
            // 
            this.buttonDur.Location = new System.Drawing.Point(149, 145);
            this.buttonDur.Name = "buttonDur";
            this.buttonDur.Size = new System.Drawing.Size(80, 25);
            this.buttonDur.TabIndex = 7;
            this.buttonDur.Text = "Dur";
            this.buttonDur.UseVisualStyleBackColor = true;
            this.buttonDur.Click += new System.EventHandler(this.buttonDur_Click);
            // 
            // textBoxdk
            // 
            this.textBoxdk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxdk.Location = new System.Drawing.Point(110, 193);
            this.textBoxdk.Name = "textBoxdk";
            this.textBoxdk.ReadOnly = true;
            this.textBoxdk.Size = new System.Drawing.Size(43, 38);
            this.textBoxdk.TabIndex = 9;
            this.textBoxdk.Text = "0";
            this.textBoxdk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxsn
            // 
            this.textBoxsn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxsn.Location = new System.Drawing.Point(159, 193);
            this.textBoxsn.Name = "textBoxsn";
            this.textBoxsn.ReadOnly = true;
            this.textBoxsn.Size = new System.Drawing.Size(43, 38);
            this.textBoxsn.TabIndex = 10;
            this.textBoxsn.Text = "0";
            this.textBoxsn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 300;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.InnerMargin = 0;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(0, 0);
            this.circularProgressBar1.Margin = new System.Windows.Forms.Padding(5);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.OuterMargin = 0;
            this.circularProgressBar1.OuterWidth = 0;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.Green;
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.circularProgressBar1.Size = new System.Drawing.Size(300, 300);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.Step = 1;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = ".23";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "°C";
            this.circularProgressBar1.TabIndex = 11;
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.circularProgressBar1.Value = 68;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            // 
            // labelOran
            // 
            this.labelOran.AutoSize = true;
            this.labelOran.BackColor = System.Drawing.SystemColors.Info;
            this.labelOran.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOran.Location = new System.Drawing.Point(125, 241);
            this.labelOran.Name = "labelOran";
            this.labelOran.Size = new System.Drawing.Size(0, 24);
            this.labelOran.TabIndex = 12;
            // 
            // Chronometer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightYellow;
            this.ClientSize = new System.Drawing.Size(299, 300);
            this.Controls.Add(this.labelOran);
            this.Controls.Add(this.textBoxsn);
            this.Controls.Add(this.textBoxdk);
            this.Controls.Add(this.buttonDur);
            this.Controls.Add(this.numericUpDownSN);
            this.Controls.Add(this.numericUpDownDK);
            this.Controls.Add(this.buttonBasla);
            this.Controls.Add(this.labelSnal);
            this.Controls.Add(this.labelDkal);
            this.Controls.Add(this.circularProgressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Chronometer";
            this.Text = "chronometer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelDkal;
        private System.Windows.Forms.Label labelSnal;
        private System.Windows.Forms.Button buttonBasla;
        private System.Windows.Forms.NumericUpDown numericUpDownDK;
        private System.Windows.Forms.NumericUpDown numericUpDownSN;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonDur;
        private System.Windows.Forms.TextBox textBoxdk;
        private System.Windows.Forms.TextBox textBoxsn;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labelOran;
    }
}

