namespace WinFormsApp3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Button btnLoadVideo;
        private Button btnPlayVideo;

        /// <summary>
        /// Pulizia delle risorse usate.
        /// </summary>
        /// <param name="disposing">true se le risorse gestite devono essere eliminate; false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Windows Form Designer

        /// <summary>
        /// Metodo richiesto per il supporto al designer.
        /// Non modificare il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            btnLoadVideo = new Button();
            btnPlayVideo = new Button();
            stopReg = new Button();
            selFileName = new Label();
            mute = new CheckBox();
            vidProgress = new ProgressBar();
            mediaPlayer = new Button();
            returnBut = new Button();
            panel1 = new Panel();
            sqr = new Button();
            multip = new Button();
            equals = new Button();
            num0 = new Button();
            panel2 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            C = new Button();
            divide = new Button();
            minus = new Button();
            num9 = new Button();
            num8 = new Button();
            num7 = new Button();
            num6 = new Button();
            num5 = new Button();
            num4 = new Button();
            plus = new Button();
            num3 = new Button();
            num2 = new Button();
            num1 = new Button();
            calc = new Button();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(12, 24);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(760, 400);
            axWindowsMediaPlayer1.TabIndex = 0;
            axWindowsMediaPlayer1.Visible = false;
            // 
            // btnLoadVideo
            // 
            btnLoadVideo.Location = new Point(12, 430);
            btnLoadVideo.Name = "btnLoadVideo";
            btnLoadVideo.Size = new Size(150, 30);
            btnLoadVideo.TabIndex = 1;
            btnLoadVideo.Text = "Carica Video";
            btnLoadVideo.UseVisualStyleBackColor = true;
            btnLoadVideo.Visible = false;
            btnLoadVideo.Click += btnLoadVideo_Click;
            // 
            // btnPlayVideo
            // 
            btnPlayVideo.Location = new Point(168, 430);
            btnPlayVideo.Name = "btnPlayVideo";
            btnPlayVideo.Size = new Size(150, 30);
            btnPlayVideo.TabIndex = 2;
            btnPlayVideo.Text = "Riproduci Video";
            btnPlayVideo.UseVisualStyleBackColor = true;
            btnPlayVideo.Visible = false;
            btnPlayVideo.Click += btnPlayVideo_Click;
            // 
            // stopReg
            // 
            stopReg.Location = new Point(336, 430);
            stopReg.Name = "stopReg";
            stopReg.Size = new Size(185, 29);
            stopReg.TabIndex = 3;
            stopReg.Text = "Ferma Registrazione";
            stopReg.UseVisualStyleBackColor = true;
            stopReg.Visible = false;
            stopReg.Click += stopReg_Click;
            // 
            // selFileName
            // 
            selFileName.AutoSize = true;
            selFileName.ForeColor = Color.Black;
            selFileName.Location = new Point(12, 1);
            selFileName.Name = "selFileName";
            selFileName.Size = new Size(159, 20);
            selFileName.TabIndex = 4;
            selFileName.Text = "Nesun File Selezionato";
            selFileName.Visible = false;
            selFileName.Click += selFileName_Click;
            // 
            // mute
            // 
            mute.AutoSize = true;
            mute.Location = new Point(539, 433);
            mute.Name = "mute";
            mute.Size = new Size(82, 24);
            mute.TabIndex = 5;
            mute.Text = "Silenzia";
            mute.UseVisualStyleBackColor = true;
            mute.Visible = false;
            mute.CheckedChanged += mute_CheckedChanged;
            // 
            // vidProgress
            // 
            vidProgress.Location = new Point(17, 470);
            vidProgress.Name = "vidProgress";
            vidProgress.RightToLeftLayout = true;
            vidProgress.Size = new Size(604, 29);
            vidProgress.Style = ProgressBarStyle.Continuous;
            vidProgress.TabIndex = 6;
            vidProgress.Visible = false;
            vidProgress.Click += vidProgress_Click;
            // 
            // mediaPlayer
            // 
            mediaPlayer.Location = new Point(0, 0);
            mediaPlayer.Name = "mediaPlayer";
            mediaPlayer.Size = new Size(162, 29);
            mediaPlayer.TabIndex = 7;
            mediaPlayer.Text = "Riproduci Video";
            mediaPlayer.UseVisualStyleBackColor = true;
            mediaPlayer.Click += mediaPlayer_Click_1;
            // 
            // returnBut
            // 
            returnBut.Location = new Point(819, 498);
            returnBut.Name = "returnBut";
            returnBut.Size = new Size(94, 29);
            returnBut.TabIndex = 8;
            returnBut.Text = "Indietro";
            returnBut.UseVisualStyleBackColor = true;
            returnBut.Visible = false;
            returnBut.Click += returnBut_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(sqr);
            panel1.Controls.Add(multip);
            panel1.Controls.Add(equals);
            panel1.Controls.Add(num0);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(C);
            panel1.Controls.Add(divide);
            panel1.Controls.Add(minus);
            panel1.Controls.Add(num9);
            panel1.Controls.Add(num8);
            panel1.Controls.Add(num7);
            panel1.Controls.Add(num6);
            panel1.Controls.Add(num5);
            panel1.Controls.Add(num4);
            panel1.Controls.Add(plus);
            panel1.Controls.Add(num3);
            panel1.Controls.Add(num2);
            panel1.Controls.Add(num1);
            panel1.Location = new Point(406, 35);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Size = new Size(252, 492);
            panel1.TabIndex = 9;
            panel1.Visible = false;
            panel1.Paint += panel1_Paint;
            // 
            // sqr
            // 
            sqr.Location = new Point(131, 141);
            sqr.Name = "sqr";
            sqr.Size = new Size(60, 60);
            sqr.TabIndex = 19;
            sqr.Text = "sqr";
            sqr.UseVisualStyleBackColor = true;
            sqr.Visible = false;
            sqr.Click += sqr_Click;
            // 
            // multip
            // 
            multip.Location = new Point(190, 141);
            multip.Name = "multip";
            multip.Size = new Size(60, 60);
            multip.TabIndex = 18;
            multip.Text = "X";
            multip.UseVisualStyleBackColor = true;
            multip.Visible = false;
            multip.Click += multip_Click;
            // 
            // equals
            // 
            equals.Location = new Point(191, 405);
            equals.Name = "equals";
            equals.Size = new Size(60, 60);
            equals.TabIndex = 16;
            equals.Text = "=";
            equals.UseVisualStyleBackColor = true;
            equals.Visible = false;
            equals.Click += equals_Click;
            // 
            // num0
            // 
            num0.Location = new Point(65, 405);
            num0.Name = "num0";
            num0.Size = new Size(60, 60);
            num0.TabIndex = 15;
            num0.Text = "0";
            num0.UseVisualStyleBackColor = true;
            num0.Visible = false;
            num0.Click += num0_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(16, 22);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 113);
            panel2.TabIndex = 14;
            panel2.Visible = false;
            panel2.Paint += panel2_Paint;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(6, 91);
            textBox1.Margin = new Padding(0);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(193, 20);
            textBox1.TabIndex = 1;
            textBox1.Visible = false;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 93);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // C
            // 
            C.Location = new Point(-1, 141);
            C.Name = "C";
            C.Size = new Size(120, 60);
            C.TabIndex = 13;
            C.Text = "C";
            C.UseVisualStyleBackColor = true;
            C.Visible = false;
            C.Click += C_Click;
            // 
            // divide
            // 
            divide.Location = new Point(190, 207);
            divide.Name = "divide";
            divide.Size = new Size(60, 60);
            divide.TabIndex = 11;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = true;
            divide.Visible = false;
            divide.Click += divide_Click;
            // 
            // minus
            // 
            minus.Location = new Point(191, 273);
            minus.Name = "minus";
            minus.Size = new Size(60, 60);
            minus.TabIndex = 10;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Visible = false;
            minus.Click += minus_Click;
            // 
            // num9
            // 
            num9.Location = new Point(131, 207);
            num9.Name = "num9";
            num9.Size = new Size(60, 60);
            num9.TabIndex = 9;
            num9.Text = "9";
            num9.UseVisualStyleBackColor = true;
            num9.Visible = false;
            num9.Click += num9_Click;
            // 
            // num8
            // 
            num8.Location = new Point(65, 207);
            num8.Name = "num8";
            num8.Size = new Size(60, 60);
            num8.TabIndex = 8;
            num8.Text = "8";
            num8.UseVisualStyleBackColor = true;
            num8.Visible = false;
            num8.Click += num8_Click;
            // 
            // num7
            // 
            num7.Location = new Point(-1, 207);
            num7.Name = "num7";
            num7.Size = new Size(60, 60);
            num7.TabIndex = 7;
            num7.Text = "7";
            num7.UseVisualStyleBackColor = true;
            num7.Visible = false;
            num7.Click += num7_Click;
            // 
            // num6
            // 
            num6.Location = new Point(131, 273);
            num6.Name = "num6";
            num6.Size = new Size(60, 60);
            num6.TabIndex = 6;
            num6.Text = "6";
            num6.UseVisualStyleBackColor = true;
            num6.Visible = false;
            num6.Click += num6_Click;
            // 
            // num5
            // 
            num5.Location = new Point(65, 273);
            num5.Name = "num5";
            num5.Size = new Size(60, 60);
            num5.TabIndex = 5;
            num5.Text = "5";
            num5.UseVisualStyleBackColor = true;
            num5.Visible = false;
            num5.Click += num5_Click;
            // 
            // num4
            // 
            num4.Location = new Point(-1, 273);
            num4.Name = "num4";
            num4.Size = new Size(60, 60);
            num4.TabIndex = 4;
            num4.Text = "4";
            num4.UseVisualStyleBackColor = true;
            num4.Visible = false;
            num4.Click += num4_Click;
            // 
            // plus
            // 
            plus.Location = new Point(191, 339);
            plus.Name = "plus";
            plus.Size = new Size(60, 60);
            plus.TabIndex = 3;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Visible = false;
            plus.Click += plus_Click;
            // 
            // num3
            // 
            num3.Location = new Point(131, 339);
            num3.Name = "num3";
            num3.Size = new Size(60, 60);
            num3.TabIndex = 2;
            num3.Text = "3";
            num3.UseVisualStyleBackColor = true;
            num3.Visible = false;
            num3.Click += num3_Click;
            // 
            // num2
            // 
            num2.Location = new Point(65, 339);
            num2.Name = "num2";
            num2.Size = new Size(60, 60);
            num2.TabIndex = 1;
            num2.Text = "2";
            num2.UseVisualStyleBackColor = true;
            num2.Visible = false;
            num2.Click += num2_Click;
            // 
            // num1
            // 
            num1.Location = new Point(-1, 339);
            num1.Name = "num1";
            num1.Size = new Size(60, 60);
            num1.TabIndex = 0;
            num1.Text = "1";
            num1.UseVisualStyleBackColor = true;
            num1.Visible = false;
            num1.Click += num1_Click;
            // 
            // calc
            // 
            calc.Location = new Point(0, 35);
            calc.Name = "calc";
            calc.Size = new Size(103, 29);
            calc.TabIndex = 10;
            calc.Text = "Calcolatrice";
            calc.UseVisualStyleBackColor = true;
            calc.Click += calc_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 694);
            Controls.Add(calc);
            Controls.Add(panel1);
            Controls.Add(returnBut);
            Controls.Add(mediaPlayer);
            Controls.Add(vidProgress);
            Controls.Add(mute);
            Controls.Add(selFileName);
            Controls.Add(stopReg);
            Controls.Add(btnPlayVideo);
            Controls.Add(btnLoadVideo);
            Controls.Add(axWindowsMediaPlayer1);
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Show;
            Text = "Lettore Video";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button stopReg;
        private Label selFileName;
        private CheckBox mute;
        private ProgressBar vidProgress;
        private Button mediaPlayer;
        private Button returnBut;
        private Panel panel1;
        private Panel panel2;
        private Button C;
        private Button divide;
        private Button minus;
        private Button num9;
        private Button num8;
        private Button num7;
        private Button num6;
        private Button num5;
        private Button num4;
        private Button plus;
        private Button num3;
        private Button num2;
        private Button num1;
        private Button equals;
        private Button num0;
        private Button multip;
        private Button sqr;
        private Label label1;
        private TextBox textBox1;
        private Button calc;
    }
}