namespace NitroStudio2
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            this.lImportTool = new System.Windows.Forms.Label();
            this.lExportTool = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.writeNames = new System.Windows.Forms.CheckBox();
            this.comboImport = new System.Windows.Forms.ComboBox();
            this.comboExport = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.saSettings = new System.Windows.Forms.TabPage();
            this.sdSettings = new System.Windows.Forms.TabPage();
            this.cbMidiInput = new System.Windows.Forms.ComboBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbWaveOutput = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.saSettings.SuspendLayout();
            this.sdSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // lImportTool
            // 
            this.lImportTool.AutoSize = true;
            this.lImportTool.Location = new System.Drawing.Point(4, 37);
            this.lImportTool.Name = "lImportTool";
            this.lImportTool.Size = new System.Drawing.Size(75, 13);
            this.lImportTool.TabIndex = 1;
            this.lImportTool.Text = "Import Method";
            // 
            // lExportTool
            // 
            this.lExportTool.AutoSize = true;
            this.lExportTool.Location = new System.Drawing.Point(4, 64);
            this.lExportTool.Name = "lExportTool";
            this.lExportTool.Size = new System.Drawing.Size(76, 13);
            this.lExportTool.TabIndex = 2;
            this.lExportTool.Text = "Export Method";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(4, 326);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(216, 326);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 4;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(297, 326);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // writeNames
            // 
            this.writeNames.AutoSize = true;
            this.writeNames.Checked = true;
            this.writeNames.CheckState = System.Windows.Forms.CheckState.Checked;
            this.writeNames.Location = new System.Drawing.Point(6, 6);
            this.writeNames.Name = "writeNames";
            this.writeNames.Size = new System.Drawing.Size(129, 17);
            this.writeNames.TabIndex = 6;
            this.writeNames.Text = "Write Names of Files?";
            this.writeNames.UseVisualStyleBackColor = true;
            this.writeNames.CheckedChanged += new System.EventHandler(this.writeNames_CheckedChanged);
            // 
            // comboImport
            // 
            this.comboImport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboImport.FormattingEnabled = true;
            this.comboImport.Items.AddRange(new object[] {
            "Nitro Studio",
            "Midi2Sseq",
            "Nintendo Tools"});
            this.comboImport.Location = new System.Drawing.Point(85, 34);
            this.comboImport.Name = "comboImport";
            this.comboImport.Size = new System.Drawing.Size(202, 21);
            this.comboImport.TabIndex = 7;
            this.comboImport.SelectionChangeCommitted += new System.EventHandler(this.comboImport_SelectionChangeCommitted);
            // 
            // comboExport
            // 
            this.comboExport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboExport.FormattingEnabled = true;
            this.comboExport.Items.AddRange(new object[] {
            "Nitro Studio",
            "Sseq2Midi"});
            this.comboExport.Location = new System.Drawing.Point(85, 61);
            this.comboExport.Name = "comboExport";
            this.comboExport.Size = new System.Drawing.Size(202, 21);
            this.comboExport.TabIndex = 8;
            this.comboExport.SelectionChangeCommitted += new System.EventHandler(this.comboExport_SelectionChangeCommitted);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.saSettings);
            this.tabControl1.Controls.Add(this.sdSettings);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(390, 320);
            this.tabControl1.TabIndex = 9;
            // 
            // saSettings
            // 
            this.saSettings.Controls.Add(this.writeNames);
            this.saSettings.Controls.Add(this.comboExport);
            this.saSettings.Controls.Add(this.lImportTool);
            this.saSettings.Controls.Add(this.comboImport);
            this.saSettings.Controls.Add(this.lExportTool);
            this.saSettings.Location = new System.Drawing.Point(4, 22);
            this.saSettings.Name = "saSettings";
            this.saSettings.Padding = new System.Windows.Forms.Padding(3);
            this.saSettings.Size = new System.Drawing.Size(382, 294);
            this.saSettings.TabIndex = 0;
            this.saSettings.Text = "Sound Archive";
            this.saSettings.UseVisualStyleBackColor = true;
            // 
            // sdSettings
            // 
            this.sdSettings.Controls.Add(this.label1);
            this.sdSettings.Controls.Add(this.cbWaveOutput);
            this.sdSettings.Controls.Add(this.lblInput);
            this.sdSettings.Controls.Add(this.cbMidiInput);
            this.sdSettings.Location = new System.Drawing.Point(4, 22);
            this.sdSettings.Name = "sdSettings";
            this.sdSettings.Padding = new System.Windows.Forms.Padding(3);
            this.sdSettings.Size = new System.Drawing.Size(382, 294);
            this.sdSettings.TabIndex = 1;
            this.sdSettings.Text = "Sound Device";
            this.sdSettings.UseVisualStyleBackColor = true;
            // 
            // cbMidiInput
            // 
            this.cbMidiInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMidiInput.FormattingEnabled = true;
            this.cbMidiInput.Location = new System.Drawing.Point(83, 3);
            this.cbMidiInput.Name = "cbMidiInput";
            this.cbMidiInput.Size = new System.Drawing.Size(285, 21);
            this.cbMidiInput.TabIndex = 0;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(6, 6);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(57, 13);
            this.lblInput.TabIndex = 1;
            this.lblInput.Text = "MIDI Input";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wave Output";
            // 
            // cbWaveOutput
            // 
            this.cbWaveOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWaveOutput.FormattingEnabled = true;
            this.cbWaveOutput.Location = new System.Drawing.Point(83, 27);
            this.cbWaveOutput.Name = "cbWaveOutput";
            this.cbWaveOutput.Size = new System.Drawing.Size(285, 21);
            this.cbWaveOutput.TabIndex = 2;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 357);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.tabControl1.ResumeLayout(false);
            this.saSettings.ResumeLayout(false);
            this.saSettings.PerformLayout();
            this.sdSettings.ResumeLayout(false);
            this.sdSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lImportTool;
        private System.Windows.Forms.Label lExportTool;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox writeNames;
        private System.Windows.Forms.ComboBox comboImport;
        private System.Windows.Forms.ComboBox comboExport;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage saSettings;
        private System.Windows.Forms.TabPage sdSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbWaveOutput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.ComboBox cbMidiInput;
    }
}