namespace PaperSpigotServerBuilder
{
    partial class MainForm
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
            this.serverSoftwareSelect = new System.Windows.Forms.ComboBox();
            this.latestPSVersionLabel = new System.Windows.Forms.Label();
            this.selectServerSoftwareLabel = new System.Windows.Forms.Label();
            this.latestStableBuildsPanel = new System.Windows.Forms.Panel();
            this.latestWaterfallVersionLabel = new System.Windows.Forms.Label();
            this.latestStableBuildsLabel = new System.Windows.Forms.Label();
            this.selectSoftwarePanel = new System.Windows.Forms.Panel();
            this.selectVersionPanel = new System.Windows.Forms.Panel();
            this.selectVersionComboBox = new System.Windows.Forms.ComboBox();
            this.selectVersionLabel = new System.Windows.Forms.Label();
            this.step1 = new System.Windows.Forms.Label();
            this.step2 = new System.Windows.Forms.Label();
            this.copyright = new System.Windows.Forms.Label();
            this.latestPSVersionText = new System.Windows.Forms.Label();
            this.latestWaterfallVersionText = new System.Windows.Forms.Label();
            this.latestStableBuildsPanel.SuspendLayout();
            this.selectSoftwarePanel.SuspendLayout();
            this.selectVersionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // serverSoftwareSelect
            // 
            this.serverSoftwareSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serverSoftwareSelect.FormattingEnabled = true;
            this.serverSoftwareSelect.Location = new System.Drawing.Point(26, 56);
            this.serverSoftwareSelect.Name = "serverSoftwareSelect";
            this.serverSoftwareSelect.Size = new System.Drawing.Size(149, 24);
            this.serverSoftwareSelect.TabIndex = 0;
            this.serverSoftwareSelect.SelectedIndexChanged += new System.EventHandler(this.serverSoftwareSelect_SelectedIndexChanged);
            // 
            // latestPSVersionLabel
            // 
            this.latestPSVersionLabel.AutoSize = true;
            this.latestPSVersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.latestPSVersionLabel.ForeColor = System.Drawing.Color.White;
            this.latestPSVersionLabel.Location = new System.Drawing.Point(26, 38);
            this.latestPSVersionLabel.Name = "latestPSVersionLabel";
            this.latestPSVersionLabel.Size = new System.Drawing.Size(90, 17);
            this.latestPSVersionLabel.TabIndex = 2;
            this.latestPSVersionLabel.Text = "Paper Spigot";
            // 
            // selectServerSoftwareLabel
            // 
            this.selectServerSoftwareLabel.AutoSize = true;
            this.selectServerSoftwareLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectServerSoftwareLabel.ForeColor = System.Drawing.Color.White;
            this.selectServerSoftwareLabel.Location = new System.Drawing.Point(23, 18);
            this.selectServerSoftwareLabel.Name = "selectServerSoftwareLabel";
            this.selectServerSoftwareLabel.Size = new System.Drawing.Size(152, 17);
            this.selectServerSoftwareLabel.TabIndex = 3;
            this.selectServerSoftwareLabel.Text = "Select Server Software";
            this.selectServerSoftwareLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // latestStableBuildsPanel
            // 
            this.latestStableBuildsPanel.BackColor = System.Drawing.Color.Gray;
            this.latestStableBuildsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.latestStableBuildsPanel.Controls.Add(this.latestWaterfallVersionText);
            this.latestStableBuildsPanel.Controls.Add(this.latestPSVersionText);
            this.latestStableBuildsPanel.Controls.Add(this.latestWaterfallVersionLabel);
            this.latestStableBuildsPanel.Controls.Add(this.latestStableBuildsLabel);
            this.latestStableBuildsPanel.Controls.Add(this.latestPSVersionLabel);
            this.latestStableBuildsPanel.Location = new System.Drawing.Point(12, 12);
            this.latestStableBuildsPanel.Name = "latestStableBuildsPanel";
            this.latestStableBuildsPanel.Size = new System.Drawing.Size(320, 94);
            this.latestStableBuildsPanel.TabIndex = 4;
            // 
            // latestWaterfallVersionLabel
            // 
            this.latestWaterfallVersionLabel.AutoSize = true;
            this.latestWaterfallVersionLabel.BackColor = System.Drawing.Color.Transparent;
            this.latestWaterfallVersionLabel.ForeColor = System.Drawing.Color.White;
            this.latestWaterfallVersionLabel.Location = new System.Drawing.Point(195, 38);
            this.latestWaterfallVersionLabel.Name = "latestWaterfallVersionLabel";
            this.latestWaterfallVersionLabel.Size = new System.Drawing.Size(64, 17);
            this.latestWaterfallVersionLabel.TabIndex = 5;
            this.latestWaterfallVersionLabel.Text = "Waterfall";
            // 
            // latestStableBuildsLabel
            // 
            this.latestStableBuildsLabel.AutoSize = true;
            this.latestStableBuildsLabel.BackColor = System.Drawing.Color.Transparent;
            this.latestStableBuildsLabel.ForeColor = System.Drawing.Color.White;
            this.latestStableBuildsLabel.Location = new System.Drawing.Point(92, 8);
            this.latestStableBuildsLabel.Name = "latestStableBuildsLabel";
            this.latestStableBuildsLabel.Size = new System.Drawing.Size(133, 17);
            this.latestStableBuildsLabel.TabIndex = 3;
            this.latestStableBuildsLabel.Text = "Latest Stable Builds";
            this.latestStableBuildsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // selectSoftwarePanel
            // 
            this.selectSoftwarePanel.BackColor = System.Drawing.Color.Gray;
            this.selectSoftwarePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectSoftwarePanel.Controls.Add(this.step1);
            this.selectSoftwarePanel.Controls.Add(this.serverSoftwareSelect);
            this.selectSoftwarePanel.Controls.Add(this.selectServerSoftwareLabel);
            this.selectSoftwarePanel.Location = new System.Drawing.Point(349, 12);
            this.selectSoftwarePanel.Name = "selectSoftwarePanel";
            this.selectSoftwarePanel.Size = new System.Drawing.Size(200, 94);
            this.selectSoftwarePanel.TabIndex = 5;
            // 
            // selectVersionPanel
            // 
            this.selectVersionPanel.BackColor = System.Drawing.Color.Gray;
            this.selectVersionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectVersionPanel.Controls.Add(this.step2);
            this.selectVersionPanel.Controls.Add(this.selectVersionLabel);
            this.selectVersionPanel.Controls.Add(this.selectVersionComboBox);
            this.selectVersionPanel.Enabled = false;
            this.selectVersionPanel.Location = new System.Drawing.Point(567, 12);
            this.selectVersionPanel.Name = "selectVersionPanel";
            this.selectVersionPanel.Size = new System.Drawing.Size(186, 94);
            this.selectVersionPanel.TabIndex = 6;
            // 
            // selectVersionComboBox
            // 
            this.selectVersionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectVersionComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.selectVersionComboBox.FormattingEnabled = true;
            this.selectVersionComboBox.Location = new System.Drawing.Point(38, 57);
            this.selectVersionComboBox.Name = "selectVersionComboBox";
            this.selectVersionComboBox.Size = new System.Drawing.Size(108, 24);
            this.selectVersionComboBox.TabIndex = 0;
            this.selectVersionComboBox.SelectedIndexChanged += new System.EventHandler(this.selectVersionComboBox_SelectedIndexChanged);
            // 
            // selectVersionLabel
            // 
            this.selectVersionLabel.AutoSize = true;
            this.selectVersionLabel.ForeColor = System.Drawing.Color.White;
            this.selectVersionLabel.Location = new System.Drawing.Point(35, 19);
            this.selectVersionLabel.Name = "selectVersionLabel";
            this.selectVersionLabel.Size = new System.Drawing.Size(111, 17);
            this.selectVersionLabel.TabIndex = 1;
            this.selectVersionLabel.Text = "Select a Version";
            // 
            // step1
            // 
            this.step1.AutoSize = true;
            this.step1.BackColor = System.Drawing.Color.Transparent;
            this.step1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step1.ForeColor = System.Drawing.Color.White;
            this.step1.Location = new System.Drawing.Point(0, 0);
            this.step1.Name = "step1";
            this.step1.Size = new System.Drawing.Size(17, 18);
            this.step1.TabIndex = 4;
            this.step1.Text = "1";
            // 
            // step2
            // 
            this.step2.AutoSize = true;
            this.step2.BackColor = System.Drawing.Color.Transparent;
            this.step2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.step2.ForeColor = System.Drawing.Color.White;
            this.step2.Location = new System.Drawing.Point(1, 1);
            this.step2.Name = "step2";
            this.step2.Size = new System.Drawing.Size(17, 18);
            this.step2.TabIndex = 5;
            this.step2.Text = "2";
            // 
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.BackColor = System.Drawing.Color.Transparent;
            this.copyright.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.ForeColor = System.Drawing.Color.LightGray;
            this.copyright.Location = new System.Drawing.Point(271, 421);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(239, 19);
            this.copyright.TabIndex = 7;
            this.copyright.Text = "Copyright (©) 2020 Puyodead1";
            // 
            // latestPSVersionText
            // 
            this.latestPSVersionText.AutoSize = true;
            this.latestPSVersionText.BackColor = System.Drawing.Color.White;
            this.latestPSVersionText.ForeColor = System.Drawing.Color.Black;
            this.latestPSVersionText.Location = new System.Drawing.Point(14, 58);
            this.latestPSVersionText.Margin = new System.Windows.Forms.Padding(3);
            this.latestPSVersionText.MaximumSize = new System.Drawing.Size(123, 2);
            this.latestPSVersionText.MinimumSize = new System.Drawing.Size(123, 22);
            this.latestPSVersionText.Name = "latestPSVersionText";
            this.latestPSVersionText.Size = new System.Drawing.Size(123, 22);
            this.latestPSVersionText.TabIndex = 6;
            this.latestPSVersionText.Text = "N/A";
            this.latestPSVersionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // latestWaterfallVersionText
            // 
            this.latestWaterfallVersionText.AutoSize = true;
            this.latestWaterfallVersionText.BackColor = System.Drawing.Color.White;
            this.latestWaterfallVersionText.ForeColor = System.Drawing.Color.Black;
            this.latestWaterfallVersionText.Location = new System.Drawing.Point(166, 58);
            this.latestWaterfallVersionText.Margin = new System.Windows.Forms.Padding(3);
            this.latestWaterfallVersionText.MaximumSize = new System.Drawing.Size(123, 2);
            this.latestWaterfallVersionText.MinimumSize = new System.Drawing.Size(123, 22);
            this.latestWaterfallVersionText.Name = "latestWaterfallVersionText";
            this.latestWaterfallVersionText.Size = new System.Drawing.Size(123, 22);
            this.latestWaterfallVersionText.TabIndex = 7;
            this.latestWaterfallVersionText.Text = "N/A";
            this.latestWaterfallVersionText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(770, 450);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.selectVersionPanel);
            this.Controls.Add(this.selectSoftwarePanel);
            this.Controls.Add(this.latestStableBuildsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Builder Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.latestStableBuildsPanel.ResumeLayout(false);
            this.latestStableBuildsPanel.PerformLayout();
            this.selectSoftwarePanel.ResumeLayout(false);
            this.selectSoftwarePanel.PerformLayout();
            this.selectVersionPanel.ResumeLayout(false);
            this.selectVersionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox serverSoftwareSelect;
        private System.Windows.Forms.Label latestPSVersionLabel;
        private System.Windows.Forms.Label selectServerSoftwareLabel;
        private System.Windows.Forms.Panel latestStableBuildsPanel;
        private System.Windows.Forms.Label latestStableBuildsLabel;
        private System.Windows.Forms.Label latestWaterfallVersionLabel;
        private System.Windows.Forms.Panel selectSoftwarePanel;
        private System.Windows.Forms.Panel selectVersionPanel;
        private System.Windows.Forms.ComboBox selectVersionComboBox;
        private System.Windows.Forms.Label selectVersionLabel;
        private System.Windows.Forms.Label step1;
        private System.Windows.Forms.Label step2;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.Label latestPSVersionText;
        private System.Windows.Forms.Label latestWaterfallVersionText;
    }
}

