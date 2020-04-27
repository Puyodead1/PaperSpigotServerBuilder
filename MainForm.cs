using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaperSpigotServerBuilder
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void selectVersionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var software = Program.GetServerSoftware();
            List<String> software2 = new List<String>(software);
            software2.Remove("Waterfall"); // remove waterfall
            software2.Reverse(); // reverse array so the latest is first

            JObject latestPaperVersion = Program.GetLatestSuccessfulBuildForJob(software2.First());
            JObject latestWaterfallVersion = Program.GetLatestSuccessfulBuildForJob("Waterfall");
            /*Console.WriteLine(latestPaperVersion["artifacts"].ToString());
            Console.WriteLine(latestWaterfallVersion["artifacts"].ToString());*/
            latestPSVersionText.Text = String.Format("{1}: #{0}", latestPaperVersion["number"].ToString(), software2.First().Replace("Paper-", "MC "));
            latestWaterfallVersionText.Text = String.Format("#{0}", latestWaterfallVersion["number"].ToString());

            // ensure the array is not null
            if(software != null)
            {
                foreach (var version in software)
                {
                    serverSoftwareSelect.Items.Add(version);
                }
            }
        }

        private void serverSoftwareSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectVersionPanel.Enabled = false;
            selectSoftwarePanel.Enabled = false;
            var selectedSoftware = serverSoftwareSelect.SelectedItem.ToString().Replace("Paper-1.12", "Paper");
            var buildsArray = Program.GetBuildsForJob(selectedSoftware);
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
        }
    }
}
