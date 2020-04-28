/*
    Creates PaperSpigot/Waterfall servers with ease.
    Copyright (c) 2020 Puyodead1

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as published
    by the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.
*/

using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperSpigotServerBuilder
{
    public partial class mainForm : Form
    {
        private Color INFO_COLOR = Color.LightGreen;
        private Color ERROR_COLOR = Color.Red;
        private Artifact artifact = null;
        private String outputFolderPath = null;
        private static bool downloadComplete = false;

        public mainForm()
        {
            InitializeComponent();
        }

        private bool Log(String text, Color color)
        {  
            consoleOutputText.SelectionColor = color;
            if (consoleOutputText.Text.Length == 0)
                consoleOutputText.AppendText(text);
            else
                consoleOutputText.AppendText("\r\n" + text);
            consoleOutputText.SelectionColor = consoleOutputText.ForeColor;
            return true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var software = Program.GetServerSoftware(consoleOutputText, Log);
            List<String> software2 = new List<String>(software);
            software.Sort();
            software.Insert(0, "Paper-1.8.8");
            software.Insert(1, "Paper-1.9.4");
            software.Insert(2, "Paper-1.10.2");
            software.Insert(3, "Paper-1.11.2");
            software.Reverse(); // latest on top
            software.Add("Waterfall");
            software2.Reverse(); // reverse array so the latest is first

            JObject latestPaperVersion = Program.GetLatestSuccessfulBuildForJob(software2.First(), consoleOutputText, Log);
            JObject latestWaterfallVersion = Program.GetLatestSuccessfulBuildForJob("Waterfall", consoleOutputText, Log);
            /*Console.WriteLine(latestPaperVersion["artifacts"].ToString());
            Console.WriteLine(latestWaterfallVersion["artifacts"].ToString());*/
            latestPSVersionText.Text = String.Format("{1}: #{0}", latestPaperVersion["number"].ToString(), software2.First().Replace("Paper-", "MC "));
            latestWaterfallVersionText.Text = String.Format("#{0}", latestWaterfallVersion["number"].ToString());

            // ensure the array is not null
            if (software != null)
            {
                foreach (var version in software)
                {
                    serverSoftwareSelect.Items.Add(version);
                }
            }
            else
                Log("Failed to load software list!", ERROR_COLOR);
        }

        private void serverSoftwareSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectVersionPanel.Enabled = false;
            selectSoftwarePanel.Enabled = false;
            folderBrowserDialogPanel.Enabled = false;
            startBuildPanel.Enabled = false;
            skipStepLabel.Visible = false;
            var selectedSoftware = serverSoftwareSelect.SelectedItem.ToString().Replace("Paper-1.12", "Paper");
            if(!selectedSoftware.Equals("Paper-1.8.8") && !selectedSoftware.Equals("Paper-1.9.4") && !selectedSoftware.Equals("Paper-1.10.2") && !selectedSoftware.Equals("Paper-1.11.2"))
            {
                var buildsArray = Program.GetBuildsForJob(selectedSoftware, consoleOutputText, Log);
                if (buildsArray != null)
                {
                    // not null
                    selectVersionComboBox.Items.Clear();
                    foreach (var build in buildsArray)
                    {
                        selectVersionComboBox.Items.Add(build["number"]);
                    }

                    selectVersionPanel.Enabled = true;
                    selectSoftwarePanel.Enabled = true;
                }
                else
                    Log("Failed to load builds!", ERROR_COLOR);
            }
            else
            {
                // selected software requires getting a specific build number
                switch(selectedSoftware)
                {
                    case "Paper-1.8.8":
                        artifact = Program.GetBuildArtifacts(Program.PAPER_8_BUILD_NUMBER, selectedSoftware, consoleOutputText, Log);
                        break;
                    case "Paper-1.9.4":
                        artifact = Program.GetBuildArtifacts(Program.PAPER_9_BUILD_NUMBER, selectedSoftware, consoleOutputText, Log);
                        break;
                    case "Paper-1.10.2":
                        artifact = Program.GetBuildArtifacts(Program.PAPER_10_BUILD_NUMBER, selectedSoftware, consoleOutputText, Log);
                        break;
                    case "Paper-1.11.2":
                        artifact = Program.GetBuildArtifacts(Program.PAPER_11_BUILD_NUMBER, selectedSoftware, consoleOutputText, Log);
                        break;
                }
                if(artifact != null)
                {
                    skipStepLabel.Visible = true;
                    folderBrowserDialogPanel.Enabled = true;
                    selectSoftwarePanel.Enabled = true;
                } else
                {
                    Log("Failed to fetch build!", ERROR_COLOR);
                }
            }
        }

        private void selectVersionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            artifact = Program.GetBuildArtifacts(selectVersionComboBox.SelectedItem.ToString(), serverSoftwareSelect.SelectedItem.ToString(), consoleOutputText, Log);

            if (artifact != null)
            {
                folderBrowserDialogPanel.Enabled = true;
                selectSoftwarePanel.Enabled = true;
            }
            else
            {
                Log("Failed to fetch build!", ERROR_COLOR);
            }
        }

        private void folderBrowserBtn_Click(object sender, EventArgs e)
        {
            startBuildPanel.Enabled = false;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                Log(String.Format("Output location has been set to: {0}", folderBrowserDialog1.SelectedPath), INFO_COLOR);
                startBuildPanel.Enabled = true;
                outputFolderPath = folderBrowserDialog1.SelectedPath;
            }
        }

        private void startBuildBtn_Click(object sender, EventArgs e)
        {
            startBuildBtn.Enabled = false;
            Log("========================", Color.White);
            Log("Grab a soda, kick back, and watch the magic happen!", INFO_COLOR);
            if(DownloadPaperClipJar())
            {
                if(CopyFiles())
                {
                    if (ExecutePaperClip())
                    {
                        //
                    }
                }
            }
        }

        public bool DownloadPaperClipJar()
        {
            Log(String.Format("Attempting to download {0}...", artifact.FileName), INFO_COLOR);
            try
            {
                var jarPath = outputFolderPath + "\\" + artifact.FileName;

                using (WebClient client = new WebClient())
                {
                    client.DownloadProgressChanged += Client_DownloadProgressChanged;
                    client.DownloadFileAsync(new Uri(artifact.URL), jarPath);
                    client.DownloadFileCompleted += Client_DownloadFileCompleted;

                    while (!downloadComplete)
                    {
                        Application.DoEvents();
                    }

                    downloadComplete = false;
                    fileDownloadProgress.Value = 0;
                    fileDownloadProgressPercent.Text = "0%";
                    return true;
                }
            }
            catch (ArgumentNullException ex)
            {
                Log(String.Format("ArgumentNullException: {0} {1}", ex.Message, ex.InnerException), ERROR_COLOR);
                return false;
            }
            catch (WebException ex)
            {
                Log(String.Format("WebException: {0} {1}", ex.Message, ex.InnerException), ERROR_COLOR);
                return false;
            }
            catch (NotSupportedException ex)
            {
                Log(String.Format("NotSupportedException: {0} {1}", ex.Message, ex.InnerException), ERROR_COLOR);
                return false;
            }
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            fileDownloadProgress.Value = e.ProgressPercentage;
            fileDownloadProgressPercent.Text = String.Format("{0}%", e.ProgressPercentage);
        }

        private void Client_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            Log(String.Format("{0} downloaded successfully", artifact.FileName), INFO_COLOR);
            downloadComplete = true;
        }

        private bool CopyFiles()
        {
            try
            {
                File.Copy(@"Resources\eula.txt", outputFolderPath + "\\eula.txt");
                File.Copy(@"Resources\Launcher.bat", outputFolderPath + "\\Launcher.bat");
                return true;
            }catch(Exception ex)
            {
                Log(String.Format("Exception: {0} {1}", ex.Message, ex.InnerException), ERROR_COLOR);
                return false;
            }
        }

        private bool ExecutePaperClip()
        {
            try
            {
                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.FileName = @"c:\windows\system32\cmd.exe";
                p.StartInfo.Arguments = @"/k cd " + outputFolderPath + "&& Launcher.bat";
                p.OutputDataReceived += P_OutputDataReceived;
                p.ErrorDataReceived += P_ErrorDataReceived;
                p.Start();
                return true;
            }catch(Exception ex)
            {
                Log(String.Format("Exception: {0} {1}", ex.Message, ex.InnerException), ERROR_COLOR);
                return false;
            }
        }

        private void P_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                Console.WriteLine(e.Data);
                Log(e.Data, ERROR_COLOR);
            }
        }

        private void P_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if(e.Data != null)
            {
                Console.WriteLine(e.Data);
                Log(e.Data, INFO_COLOR);
            }
        }
    }
}
