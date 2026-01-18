using NitroStudio2.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NitroStudio2
{
    public partial class Settings : Form
    {
        Configuration config;
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
            Functions.Global.c.WriteConfig();
            btnApply.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
           writeNames.Checked = bool.Parse(config.Settings["writeNames"]);
            switch(config.Settings["importTool"])
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
    }
}
