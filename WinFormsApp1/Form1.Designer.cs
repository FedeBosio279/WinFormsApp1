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
            button1 = new Button();
            label1 = new Label();
            checkBox1 = new CheckBox();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
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
            // 
            // btnLoadVideo
            // 
            btnLoadVideo.Location = new Point(12, 430);
            btnLoadVideo.Name = "btnLoadVideo";
            btnLoadVideo.Size = new Size(150, 30);
            btnLoadVideo.TabIndex = 1;
            btnLoadVideo.Text = "Carica Video";
            btnLoadVideo.UseVisualStyleBackColor = true;
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
            btnPlayVideo.Click += btnPlayVideo_Click;
            // 
            // button1
            // 
            button1.Location = new Point(336, 430);
            button1.Name = "button1";
            button1.Size = new Size(185, 29);
            button1.TabIndex = 3;
            button1.Text = "Ferma Registrazione";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 1);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 4;
            label1.Text = "Nesun File Selezionato";
            label1.Click += label1_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(539, 433);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 24);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Silenzia";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(17, 470);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(604, 29);
            progressBar1.TabIndex = 6;
            progressBar1.Click += progressBar1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(progressBar1);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnPlayVideo);
            Controls.Add(btnLoadVideo);
            Controls.Add(axWindowsMediaPlayer1);
            Name = "Form1";
            Text = "Lettore Video";
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private CheckBox checkBox1;
        private ProgressBar progressBar1;
    }
}
