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
            this.SuspendLayout();
            // 
            // lImportTool
            // 
            this.lImportTool.AutoSize = true;
            this.lImportTool.Location = new System.Drawing.Point(13, 43);
            this.lImportTool.Name = "lImportTool";
            this.lImportTool.Size = new System.Drawing.Size(75, 13);
            this.lImportTool.TabIndex = 1;
            this.lImportTool.Text = "Import Method";
            // 
            // lExportTool
            // 
            this.lExportTool.AutoSize = true;
            this.lExportTool.Location = new System.Drawing.Point(13, 70);
            this.lExportTool.Name = "lExportTool";
            this.lExportTool.Size = new System.Drawing.Size(76, 13);
            this.lExportTool.TabIndex = 2;
            this.lExportTool.Text = "Export Method";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(16, 94);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(140, 94);
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
            this.btnOk.Location = new System.Drawing.Point(221, 94);
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
            this.writeNames.Location = new System.Drawing.Point(15, 12);
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
            this.comboImport.Location = new System.Drawing.Point(94, 40);
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
            this.comboExport.Location = new System.Drawing.Point(94, 67);
            this.comboExport.Name = "comboExport";
            this.comboExport.Size = new System.Drawing.Size(202, 21);
            this.comboExport.TabIndex = 8;
            this.comboExport.SelectionChangeCommitted += new System.EventHandler(this.comboExport_SelectionChangeCommitted);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 131);
            this.Controls.Add(this.comboExport);
            this.Controls.Add(this.comboImport);
            this.Controls.Add(this.writeNames);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lExportTool);
            this.Controls.Add(this.lImportTool);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.ShowIcon = false;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}