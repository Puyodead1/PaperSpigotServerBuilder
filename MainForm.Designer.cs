namespace PaperSpigotServerBuilder
{
    partial class mainForm
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
            this.latestWaterfallVersionText = new System.Windows.Forms.Label();
            this.latestPSVersionText = new System.Windows.Forms.Label();
            this.latestWaterfallVersionLabel = new System.Windows.Forms.Label();
            this.latestStableBuildsLabel = new System.Windows.Forms.Label();
            this.selectSoftwarePanel = new System.Windows.Forms.Panel();
            this.step1 = new System.Windows.Forms.Label();
            this.selectVersionPanel = new System.Windows.Forms.Panel();
            this.step2 = new System.Windows.Forms.Label();
            this.selectVersionLabel = new System.Windows.Forms.Label();
            this.selectVersionComboBox = new System.Windows.Forms.ComboBox();
            this.copyright = new System.Windows.Forms.Label();
            this.stepsPanel = new System.Windows.Forms.Panel();
            this.folderBrowserDialogPanel = new System.Windows.Forms.Panel();
            this.folderBrowserBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.selectFolderLocationLabel = new System.Windows.Forms.Label();
            this.startBuildPanel = new System.Windows.Forms.Panel();
            this.startBuildBtn = new System.Windows.Forms.Button();
            this.startBuildLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.consoleOutputText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.skipStepLabel = new System.Windows.Forms.Label();
            this.fileDownloadProgress = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.fileDownloadProgressPercent = new System.Windows.Forms.Label();
            this.eulaNotice = new System.Windows.Forms.Label();
            this.latestStableBuildsPanel.SuspendLayout();
            this.selectSoftwarePanel.SuspendLayout();
            this.selectVersionPanel.SuspendLayout();
            this.stepsPanel.SuspendLayout();
            this.folderBrowserDialogPanel.SuspendLayout();
            this.startBuildPanel.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.latestStableBuildsPanel.Location = new System.Drawing.Point(12, 6);
            this.latestStableBuildsPanel.Name = "latestStableBuildsPanel";
            this.latestStableBuildsPanel.Size = new System.Drawing.Size(320, 108);
            this.latestStableBuildsPanel.TabIndex = 4;
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
            this.selectSoftwarePanel.BackColor = System.Drawing.Color.DimGray;
            this.selectSoftwarePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectSoftwarePanel.Controls.Add(this.step1);
            this.selectSoftwarePanel.Controls.Add(this.serverSoftwareSelect);
            this.selectSoftwarePanel.Controls.Add(this.selectServerSoftwareLabel);
            this.selectSoftwarePanel.Location = new System.Drawing.Point(7, 6);
            this.selectSoftwarePanel.Name = "selectSoftwarePanel";
            this.selectSoftwarePanel.Size = new System.Drawing.Size(200, 94);
            this.selectSoftwarePanel.TabIndex = 5;
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
            // selectVersionPanel
            // 
            this.selectVersionPanel.BackColor = System.Drawing.Color.DimGray;
            this.selectVersionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectVersionPanel.Controls.Add(this.skipStepLabel);
            this.selectVersionPanel.Controls.Add(this.step2);
            this.selectVersionPanel.Controls.Add(this.selectVersionLabel);
            this.selectVersionPanel.Controls.Add(this.selectVersionComboBox);
            this.selectVersionPanel.Enabled = false;
            this.selectVersionPanel.Location = new System.Drawing.Point(218, 6);
            this.selectVersionPanel.Name = "selectVersionPanel";
            this.selectVersionPanel.Size = new System.Drawing.Size(186, 94);
            this.selectVersionPanel.TabIndex = 6;
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
            // copyright
            // 
            this.copyright.AutoSize = true;
            this.copyright.BackColor = System.Drawing.Color.Transparent;
            this.copyright.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyright.ForeColor = System.Drawing.Color.LightGray;
            this.copyright.Location = new System.Drawing.Point(136, 481);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(239, 19);
            this.copyright.TabIndex = 7;
            this.copyright.Text = "Copyright (©) 2020 Puyodead1";
            // 
            // stepsPanel
            // 
            this.stepsPanel.BackColor = System.Drawing.Color.Gray;
            this.stepsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stepsPanel.Controls.Add(this.folderBrowserDialogPanel);
            this.stepsPanel.Controls.Add(this.startBuildPanel);
            this.stepsPanel.Controls.Add(this.selectSoftwarePanel);
            this.stepsPanel.Controls.Add(this.selectVersionPanel);
            this.stepsPanel.Location = new System.Drawing.Point(339, 6);
            this.stepsPanel.Name = "stepsPanel";
            this.stepsPanel.Size = new System.Drawing.Size(850, 108);
            this.stepsPanel.TabIndex = 8;
            // 
            // folderBrowserDialogPanel
            // 
            this.folderBrowserDialogPanel.BackColor = System.Drawing.Color.DimGray;
            this.folderBrowserDialogPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.folderBrowserDialogPanel.Controls.Add(this.folderBrowserBtn);
            this.folderBrowserDialogPanel.Controls.Add(this.label3);
            this.folderBrowserDialogPanel.Controls.Add(this.selectFolderLocationLabel);
            this.folderBrowserDialogPanel.Enabled = false;
            this.folderBrowserDialogPanel.Location = new System.Drawing.Point(412, 6);
            this.folderBrowserDialogPanel.Name = "folderBrowserDialogPanel";
            this.folderBrowserDialogPanel.Size = new System.Drawing.Size(223, 94);
            this.folderBrowserDialogPanel.TabIndex = 7;
            // 
            // folderBrowserBtn
            // 
            this.folderBrowserBtn.BackColor = System.Drawing.Color.Transparent;
            this.folderBrowserBtn.Location = new System.Drawing.Point(42, 56);
            this.folderBrowserBtn.Name = "folderBrowserBtn";
            this.folderBrowserBtn.Size = new System.Drawing.Size(149, 25);
            this.folderBrowserBtn.TabIndex = 6;
            this.folderBrowserBtn.Text = "Browse";
            this.folderBrowserBtn.UseVisualStyleBackColor = false;
            this.folderBrowserBtn.Click += new System.EventHandler(this.folderBrowserBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "3";
            // 
            // selectFolderLocationLabel
            // 
            this.selectFolderLocationLabel.AutoSize = true;
            this.selectFolderLocationLabel.ForeColor = System.Drawing.Color.White;
            this.selectFolderLocationLabel.Location = new System.Drawing.Point(39, 19);
            this.selectFolderLocationLabel.Name = "selectFolderLocationLabel";
            this.selectFolderLocationLabel.Size = new System.Drawing.Size(152, 17);
            this.selectFolderLocationLabel.TabIndex = 1;
            this.selectFolderLocationLabel.Text = "Select Output Location";
            // 
            // startBuildPanel
            // 
            this.startBuildPanel.BackColor = System.Drawing.Color.DimGray;
            this.startBuildPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startBuildPanel.Controls.Add(this.startBuildBtn);
            this.startBuildPanel.Controls.Add(this.startBuildLabel);
            this.startBuildPanel.Controls.Add(this.label1);
            this.startBuildPanel.Enabled = false;
            this.startBuildPanel.Location = new System.Drawing.Point(642, 6);
            this.startBuildPanel.Name = "startBuildPanel";
            this.startBuildPanel.Size = new System.Drawing.Size(200, 93);
            this.startBuildPanel.TabIndex = 7;
            // 
            // startBuildBtn
            // 
            this.startBuildBtn.BackColor = System.Drawing.Color.Transparent;
            this.startBuildBtn.Location = new System.Drawing.Point(48, 56);
            this.startBuildBtn.Name = "startBuildBtn";
            this.startBuildBtn.Size = new System.Drawing.Size(114, 25);
            this.startBuildBtn.TabIndex = 7;
            this.startBuildBtn.Text = "Build";
            this.startBuildBtn.UseVisualStyleBackColor = false;
            this.startBuildBtn.Click += new System.EventHandler(this.startBuildBtn_Click);
            // 
            // startBuildLabel
            // 
            this.startBuildLabel.AutoSize = true;
            this.startBuildLabel.ForeColor = System.Drawing.Color.White;
            this.startBuildLabel.Location = new System.Drawing.Point(64, 17);
            this.startBuildLabel.Name = "startBuildLabel";
            this.startBuildLabel.Size = new System.Drawing.Size(73, 17);
            this.startBuildLabel.TabIndex = 6;
            this.startBuildLabel.Text = "Start Build";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "4";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.fileDownloadProgressPercent);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.consoleOutputText);
            this.panel1.Controls.Add(this.fileDownloadProgress);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 354);
            this.panel1.TabIndex = 9;
            // 
            // consoleOutputText
            // 
            this.consoleOutputText.BackColor = System.Drawing.Color.DimGray;
            this.consoleOutputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleOutputText.ForeColor = System.Drawing.Color.White;
            this.consoleOutputText.Location = new System.Drawing.Point(8, 43);
            this.consoleOutputText.Name = "consoleOutputText";
            this.consoleOutputText.ReadOnly = true;
            this.consoleOutputText.Size = new System.Drawing.Size(1160, 233);
            this.consoleOutputText.TabIndex = 11;
            this.consoleOutputText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(512, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Console Output";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Location where the server should be built";
            // 
            // skipStepLabel
            // 
            this.skipStepLabel.AutoSize = true;
            this.skipStepLabel.BackColor = System.Drawing.Color.Transparent;
            this.skipStepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipStepLabel.ForeColor = System.Drawing.Color.Red;
            this.skipStepLabel.Location = new System.Drawing.Point(28, 36);
            this.skipStepLabel.Name = "skipStepLabel";
            this.skipStepLabel.Size = new System.Drawing.Size(132, 25);
            this.skipStepLabel.TabIndex = 7;
            this.skipStepLabel.Text = "Skip this Step";
            this.skipStepLabel.Visible = false;
            // 
            // fileDownloadProgress
            // 
            this.fileDownloadProgress.Location = new System.Drawing.Point(3, 306);
            this.fileDownloadProgress.Name = "fileDownloadProgress";
            this.fileDownloadProgress.Size = new System.Drawing.Size(1169, 23);
            this.fileDownloadProgress.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(522, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "File Download Progress";
            // 
            // fileDownloadProgressPercent
            // 
            this.fileDownloadProgressPercent.AutoSize = true;
            this.fileDownloadProgressPercent.BackColor = System.Drawing.Color.Transparent;
            this.fileDownloadProgressPercent.ForeColor = System.Drawing.Color.Black;
            this.fileDownloadProgressPercent.Location = new System.Drawing.Point(601, 309);
            this.fileDownloadProgressPercent.Name = "fileDownloadProgressPercent";
            this.fileDownloadProgressPercent.Size = new System.Drawing.Size(28, 17);
            this.fileDownloadProgressPercent.TabIndex = 12;
            this.fileDownloadProgressPercent.Text = "0%";
            this.fileDownloadProgressPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eulaNotice
            // 
            this.eulaNotice.AutoSize = true;
            this.eulaNotice.BackColor = System.Drawing.Color.Transparent;
            this.eulaNotice.ForeColor = System.Drawing.Color.LightGray;
            this.eulaNotice.Location = new System.Drawing.Point(482, 481);
            this.eulaNotice.Name = "eulaNotice";
            this.eulaNotice.Size = new System.Drawing.Size(704, 17);
            this.eulaNotice.TabIndex = 10;
            this.eulaNotice.Text = "By using this program, you agree to the Mojang EULA (https://account.mojang.com/d" +
    "ocuments/minecraft_eula)\r\n";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1201, 505);
            this.Controls.Add(this.eulaNotice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stepsPanel);
            this.Controls.Add(this.copyright);
            this.Controls.Add(this.latestStableBuildsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Builder Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.latestStableBuildsPanel.ResumeLayout(false);
            this.latestStableBuildsPanel.PerformLayout();
            this.selectSoftwarePanel.ResumeLayout(false);
            this.selectSoftwarePanel.PerformLayout();
            this.selectVersionPanel.ResumeLayout(false);
            this.selectVersionPanel.PerformLayout();
            this.stepsPanel.ResumeLayout(false);
            this.folderBrowserDialogPanel.ResumeLayout(false);
            this.folderBrowserDialogPanel.PerformLayout();
            this.startBuildPanel.ResumeLayout(false);
            this.startBuildPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel stepsPanel;
        private System.Windows.Forms.Panel startBuildPanel;
        private System.Windows.Forms.Label startBuildLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startBuildBtn;
        private System.Windows.Forms.Panel folderBrowserDialogPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label selectFolderLocationLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button folderBrowserBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RichTextBox consoleOutputText;
        private System.Windows.Forms.Label skipStepLabel;
        private System.Windows.Forms.ProgressBar fileDownloadProgress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label fileDownloadProgressPercent;
        private System.Windows.Forms.Label eulaNotice;
    }
}

