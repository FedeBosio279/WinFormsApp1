using System;
using System.Windows.Forms;
using AxWMPLib;
using Microsoft.VisualBasic;
using System.Timers;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        string FileName1 = "";
        private System.Windows.Forms.Timer timer;

        private void Timer_Tick(object sender, EventArgs e)
        {dddd
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                // Ottieni la durata totale del video
                double duration = axWindowsMediaPlayer1.currentMedia.duration;
                if (duration > 0)
                {
                    // Sincronizza la posizione del TrackBar con la posizione attuale del video
                    progressBar1.Maximum = (int)duration;
                    progressBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
                }
            }
        }

        public Form1()
        {
            InitializeComponent(); // Inizializza i controlli grafici del form
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1; // Aggiornamento ogni 1 ms
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void trackBarProgress_Scroll(object sender, EventArgs e)
        {
            // Imposta la posizione del video in base alla posizione del TrackBar
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = progressBar1.Value;
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
                    label1.Text = FileName1;
                }
            }
        }

        private void btnPlayVideo_Click(object sender, EventArgs e)
        {
            // Avvia la riproduzione del video
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.mute = checkBox1.Checked;
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Riattiva audio";
            }
            else
            {
                checkBox1.Text = "Silenzia";
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
