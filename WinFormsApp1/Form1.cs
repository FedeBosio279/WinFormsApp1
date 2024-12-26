using System;
using System.Windows.Forms;
using AxWMPLib;
using Microsoft.VisualBasic;
using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        string FileName1 = "";
        private System.Windows.Forms.Timer timer;
        double firstNumber = 0;
        double secondNumber = 0;
        string operation = "";
        double result = 0;

        public Form1()
        {
            InitializeComponent(); // Inizializza i controlli grafici del form
            axWindowsMediaPlayer1.PlayStateChange += AxWindowsMediaPlayer1_PlayStateChange;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1; // Aggiornamento ogni 1 ms
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                // Ottieni la durata totale del video
                double duration = axWindowsMediaPlayer1.currentMedia.duration;
                if (duration > 0)
                {
                    // Sincronizza la posizione del TrackBar con la posizione attuale del video
                    vidProgress.Maximum = (int)duration;
                    vidProgress.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                }
            }
            UpdateMuteButton();
        }

        private void trackBarProgress_Scroll(object sender, EventArgs e)
        {
            // Imposta la posizione del video in base alla posizione del TrackBar
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = vidProgress.Value;
        }


        private void btnLoadVideo_Click(object sender, EventArgs e)
        {
            // Apri una finestra di dialogo per scegliere un file video
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.wmv|All Files|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName1 = openFileDialog.FileName;
                    axWindowsMediaPlayer1.URL = openFileDialog.FileName;
                    selFileName.Text = FileName1;
                }
            }
        }

        private void btnPlayVideo_Click(object sender, EventArgs e)
        {
            // Avvia la riproduzione del video
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void stopReg_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void selFileName_Click(object sender, EventArgs e)
        {

        }
        private void UpdateMuteButton()
        {
            // Controlla lo stato del muto e aggiorna il testo del pulsante
            if (axWindowsMediaPlayer1.settings.mute)
            {
                mute.Text = "Riattiva Audio";
            }
            else
            {
                mute.Text = "Silenzia";
            }
        }
        private void AxWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            // Aggiorna il pulsante ogni volta che lo stato cambia
            UpdateMuteButton();
        }

        private void vidProgress_Click(object sender, EventArgs e)
        {

        }

        private void mediaPlayer_Click_1(object sender, EventArgs e)
        {
            stopReg.Visible = true;
            mediaPlayer.Visible = false;
            vidProgress.Visible = true;
            mute.Visible = true;
            selFileName.Visible = true;
            btnPlayVideo.Visible = true;
            btnLoadVideo.Visible = true;
            axWindowsMediaPlayer1.Visible = true;
            returnBut.Visible = true;
            calc.Visible = false;
            num1.Visible = false;
            num2.Visible = false;
            num3.Visible = false;
            num4.Visible = false;
            num5.Visible = false;
            num6.Visible = false;
            num7.Visible = false;
            num8.Visible = false;
            num9.Visible = false;
            num0.Visible = false;
            equals.Visible = false;
            minus.Visible = false;
            plus.Visible = false;
            multip.Visible = false;
            divide.Visible = false;
            C.Visible = false;
            sqr.Visible = false;
            textBox1.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            calc.Visible = false;
        }

        private void returnBut_Click(object sender, EventArgs e)
        {
            stopReg.Visible = false;
            mediaPlayer.Visible = true;
            vidProgress.Visible = false;
            mute.Visible = false;
            selFileName.Visible = false;
            btnPlayVideo.Visible = false;
            btnLoadVideo.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
            returnBut.Visible = false;
            calc.Visible = false;
            num1.Visible = false;
            num2.Visible = false;
            num3.Visible = false;
            num4.Visible = false;
            num5.Visible = false;
            num6.Visible = false;
            num7.Visible = false;
            num8.Visible = false;
            num9.Visible = false;
            num0.Visible = false;
            equals.Visible = false;
            minus.Visible = false;
            plus.Visible = false;
            multip.Visible = false;
            divide.Visible = false;
            C.Visible = false;
            sqr.Visible = false;
            textBox1.Visible = false;
            panel1.Visible = false;
            panel2.Visible = false;
            calc.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void num1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            firstNumber = 0;
            secondNumber = 0;
            operation = "";
        }

        private void sqr_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Math.Sqrt(number).ToString();
        }

        private void multip_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operation = "*";
            textBox1.Clear();
        }

        private void num7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void equals_Click(object sender, EventArgs e)
        {
            secondNumber = Convert.ToDouble(textBox1.Text);

            switch (operation)
            {
                case "+":
                    textBox1.Text = (firstNumber + secondNumber).ToString();
                    break;
                case "-":
                    textBox1.Text = (firstNumber - secondNumber).ToString();
                    break;
                case "*":
                    textBox1.Text = (firstNumber * secondNumber).ToString();
                    break;
                case "/":
                    if (secondNumber != 0)
                        textBox1.Text = (firstNumber / secondNumber).ToString();
                    else
                        textBox1.Text = "Errore: Divisione per zero";
                    break;
            }
        }

        private void plus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operation = "+";
            textBox1.Clear();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operation = "-";
            textBox1.Clear();
        }

        private void num6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textBox1.Text);
            operation = "/";
            textBox1.Clear();
        }

        private void num9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void calc_Click(object sender, EventArgs e)
        {
            stopReg.Visible = false;
            mediaPlayer.Visible = false;
            vidProgress.Visible = false;
            mute.Visible = false;
            selFileName.Visible = false;
            btnPlayVideo.Visible = false;
            btnLoadVideo.Visible = false;
            axWindowsMediaPlayer1.Visible = false;
            returnBut.Visible = true;
            num1.Visible = true;
            num2.Visible = true;
            num3.Visible = true;
            num4.Visible = true;
            num5.Visible = true;
            num6.Visible = true;
            num7.Visible = true;
            num8.Visible = true;
            num9.Visible = true;
            num0.Visible = true;
            equals.Visible = true;
            minus.Visible = true;
            plus.Visible = true;
            multip.Visible = true;
            divide.Visible = true;
            C.Visible = true;
            sqr.Visible = true;
            textBox1.Visible = true;
            panel1.Visible = true;
            panel2.Visible = true;
            calc.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
        }

        private void mute_click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.mute = !axWindowsMediaPlayer1.settings.mute;
            UpdateMuteButton();
        }
    }
}
