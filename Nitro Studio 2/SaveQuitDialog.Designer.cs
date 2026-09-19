namespace NitroStudio2
{
    partial class SaveQuitDialog
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
            label1 = new System.Windows.Forms.Label();
            YesButton = new System.Windows.Forms.Button();
            NoButton = new System.Windows.Forms.Button();
            CancelButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(85, 10);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(183, 13);
            label1.TabIndex = 0;
            label1.Text = "Do you want to save before you exit?\r\n";
            // 
            // YesButton
            // 
            YesButton.Location = new System.Drawing.Point(14, 54);
            YesButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            YesButton.Name = "YesButton";
            YesButton.Size = new System.Drawing.Size(111, 35);
            YesButton.TabIndex = 1;
            YesButton.Text = "Save and Quit";
            YesButton.UseVisualStyleBackColor = true;
            YesButton.Click += YesButton_Click;
            // 
            // NoButton
            // 
            NoButton.Location = new System.Drawing.Point(132, 54);
            NoButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            NoButton.Name = "NoButton";
            NoButton.Size = new System.Drawing.Size(111, 35);
            NoButton.TabIndex = 2;
            NoButton.Text = "Quit";
            NoButton.UseVisualStyleBackColor = true;
            NoButton.Click += NoButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new System.Drawing.Point(250, 54);
            CancelButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new System.Drawing.Size(111, 35);
            CancelButton.TabIndex = 3;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // SaveQuitDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(373, 101);
            Controls.Add(CancelButton);
            Controls.Add(NoButton);
            Controls.Add(YesButton);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SaveQuitDialog";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Warning";
            Load += SaveQuitDialog_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button YesButton;
        private System.Windows.Forms.Button NoButton;
        private System.Windows.Forms.Button CancelButton;
    }
}