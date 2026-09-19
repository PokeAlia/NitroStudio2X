using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.CoreAudioApi;
using NitroStudio2.Functions;
using GotaSoundIO.Sound;

namespace NitroStudio2 {
    public partial class StreamPlayer : Form
    {
        public MainWindow MainWindow;
        byte[] File;
        static Configuration Config = new Configuration();
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        GotaSoundIO.Sound.Playback.StreamPlayer Player = new GotaSoundIO.Sound.Playback.StreamPlayer(Config.Settings["outputWaveDevice"]);

        public StreamPlayer(MainWindow m, string stream, string name)
        {
            InitializeComponent();
            Text = "Stream Player - " + name + ".strm";
            MainWindow = m;
            // Load stream into GotaSoundIO Player and initialise values
            Player.LoadStream(new RiffWave(stream));
            trackBar1.Maximum = (int)Player.GetLength();
            bPlay.Enabled = true;
            bStop.Enabled = false;
            bPause.Enabled = false;
            Player.Loop = true;
            // Setup visualiser from NAudio
            waveViewer1.WaveStream = new NAudio.Wave.WaveFileReader(stream);
            // Setup player for proper handling of playback status
            t.Tick += T_Tick;
            t.Interval = 1000 / 30;
            t.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            trackBar1.Value = (int)Player.GetPosition();
        }

        private void onClose(object sender, EventArgs e)
        {
            Player.Stop();
            Player.Dispose();
        }

        private void StreamPlayer_Load(object sender, EventArgs e)
        {

        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            Player.Play();
            bPlay.Enabled = false;
            bStop.Enabled = true;
            bPause.Enabled = true;
        }

        private void bPause_Click_1(object sender, EventArgs e)
        {
            Player.Pause();
            bPlay.Enabled = true;
            bStop.Enabled = true;
            bPause.Enabled = false;
        }

        private void bStop_Click_1(object sender, EventArgs e)
        {
            Player.Stop();
            bPlay.Enabled = true;
            bStop.Enabled = false;
            bPause.Enabled = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Player.SetPosition((uint)trackBar1.Value);
        }
    }
}
