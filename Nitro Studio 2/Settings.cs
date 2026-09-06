using NAudio.CoreAudioApi;
using NAudio.Midi;
using NAudio.Wave;
using NitroStudio2.Functions;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NitroStudio2
{
    public partial class Settings : Form
    {
        Configuration config;
        List<string> devices = new List<string>();
        public Settings(Configuration c)
        {
            config = c;
            InitializeComponent();
        }

        private void comboExport_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
            btnApply.Enabled = true;
        }

        private void comboImport_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
            btnApply.Enabled = true;
        }

        private void writeNames_CheckedChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
            btnApply.Enabled = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            btnOk.Enabled = true;
            Functions.Global.c.Settings["importTool"] = comboImport.Text.Replace(" ", "");
            Functions.Global.c.Settings["exportTool"] = comboExport.Text.Replace(" ", "");
            Functions.Global.c.Settings["writeNames"] = writeNames.Checked.ToString();

            Functions.Global.c.Settings["inputMidiDevice"] = cbMidiInput.SelectedIndex.ToString();
            Functions.Global.c.Settings["outputWaveDevice"] = devices[cbWaveOutput.SelectedIndex];

            Functions.Global.c.WriteConfig();
            btnApply.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            MMDeviceEnumerator MMdevEnum = new MMDeviceEnumerator();
            foreach (MMDevice device in MMdevEnum.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.All))
            {
                cbWaveOutput.Items.Add(device.FriendlyName + " (" + device.State + ")");
                devices.Add(device.ID);
            }

            for (int i = 0; i < MidiIn.NumberOfDevices; i++)
            {
                MidiInCapabilities deviceInfo = MidiIn.DeviceInfo(i);
                cbMidiInput.Items.Add(deviceInfo.ProductName);
            }

            writeNames.Checked = bool.Parse(config.Settings["writeNames"]);
            switch (config.Settings["importTool"])
            {
                case "NitroStudio":
                    comboImport.SelectedText = "Nitro Studio";
                    comboImport.Text = "Nitro Studio";
                    break;
                case "Midi2Sseq":
                    comboImport.SelectedText = "Midi2Sseq";
                    comboImport.Text = "Midi2Sseq";
                    break;
                case "NintendoTools":
                    comboImport.SelectedText = "Nintendo Tools";
                    comboImport.Text = "Nintendo Tools";
                    break;
            }

            int x = 0;
            foreach(var s in devices)
            {
                if(s == config.Settings["outputWaveDevice"])
                {
                    cbWaveOutput.SelectedIndex = x;
                }
                x++;
            }

            cbMidiInput.SelectedIndex = int.Parse(config.Settings["inputMidiDevice"]);

            switch (config.Settings["exportTool"])
            {
                case "NitroStudio":
                    comboExport.SelectedText = "Nitro Studio";
                    comboExport.Text = "Nitro Studio";
                    break;
                case "Sseq2Midi":
                    comboExport.SelectedText = "Sseq2Midi";
                    comboExport.Text = "Sseq2Midi";
                    break;
            }
            btnApply.Enabled = false;
            btnOk.Enabled = true;
        }

        private void cbMidiInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
            btnApply.Enabled = true;
        }

        private void cbWaveOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
            btnApply.Enabled = true;
        }

        private void comboImport_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
            btnApply.Enabled = true;
        }

        private void comboExport_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOk.Enabled = false;
            btnApply.Enabled = true;
        }
    }
}
