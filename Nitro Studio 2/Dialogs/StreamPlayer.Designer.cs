namespace NitroStudio2 {
    partial class StreamPlayer {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StreamPlayer));
            trackBar1 = new System.Windows.Forms.TrackBar();
            bPlay = new System.Windows.Forms.Button();
            bStop = new System.Windows.Forms.Button();
            bPause = new System.Windows.Forms.Button();
            waveViewer1 = new NAudio.Gui.WaveViewer();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Location = new System.Drawing.Point(12, 273);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new System.Drawing.Size(713, 45);
            trackBar1.TabIndex = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // bPlay
            // 
            bPlay.Location = new System.Drawing.Point(357, 324);
            bPlay.Name = "bPlay";
            bPlay.Size = new System.Drawing.Size(75, 30);
            bPlay.TabIndex = 2;
            bPlay.Text = "Play";
            bPlay.UseVisualStyleBackColor = true;
            bPlay.Click += bPlay_Click;
            // 
            // bStop
            // 
            bStop.Location = new System.Drawing.Point(276, 324);
            bStop.Name = "bStop";
            bStop.Size = new System.Drawing.Size(75, 30);
            bStop.TabIndex = 3;
            bStop.Text = "Stop";
            bStop.UseVisualStyleBackColor = true;
            bStop.Click += bStop_Click_1;
            // 
            // bPause
            // 
            bPause.Location = new System.Drawing.Point(438, 324);
            bPause.Name = "bPause";
            bPause.Size = new System.Drawing.Size(75, 30);
            bPause.TabIndex = 4;
            bPause.Text = "Pause";
            bPause.UseVisualStyleBackColor = true;
            bPause.Click += bPause_Click_1;
            // 
            // waveViewer1
            // 
            waveViewer1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            waveViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            waveViewer1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            waveViewer1.Location = new System.Drawing.Point(12, 12);
            waveViewer1.Name = "waveViewer1";
            waveViewer1.SamplesPerPixel = 128;
            waveViewer1.Size = new System.Drawing.Size(713, 255);
            waveViewer1.StartPosition = 0L;
            waveViewer1.TabIndex = 5;
            waveViewer1.WaveStream = null;
            // 
            // StreamPlayer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(737, 366);
            Controls.Add(waveViewer1);
            Controls.Add(bPause);
            Controls.Add(bStop);
            Controls.Add(bPlay);
            Controls.Add(trackBar1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "StreamPlayer";
            Text = "s";
            FormClosing += onClose;
            Load += StreamPlayer_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button bPlay;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Button bPause;
        private NAudio.Gui.WaveViewer waveViewer1;

        #endregion

        //internal AxWMPLib.AxWindowsMediaPlayer wmp;
    }
}