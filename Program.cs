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

using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net;

namespace PaperSpigotServerBuilder
{
    static class Program
    {
        public static string JOB_LATEST_SUCCESSFUL_BUILD_URL = "https://papermc.io/ci/job/{0}/lastSuccessfulBuild/api/json";
        public static string JOBS_URL = "https://papermc.io/ci/api/json?tree=jobs[name]";
        public static string JOB_BUILDS_URL = "https://papermc.io/ci/job/{0}/api/json?tree=builds[number,url,artifacts[fileName,relativePath]]";
        public static string JOB_BUILD_URL = "https://papermc.io/ci/job/{0}/{1}/api/json";
        public static string JOB_BUILD_ARTIFACT_URL = "https://papermc.io/ci/job/{0}/{1}/artifact/{2}";
        public static string PAPER_11_BUILD_NUMBER = "1104";
        public static string PAPER_10_BUILD_NUMBER = "916.2";
        public static string PAPER_9_BUILD_NUMBER = "773";
        public static string PAPER_8_BUILD_NUMBER = "443";
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6) SetProcessDPIAware();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InternetCheckInProgress());
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new System.Net.WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }


        public static JObject GetLatestSuccessfulBuildForJob(string job, RichTextBox console, Func<String, Color, bool> log)
        {
            String url = string.Format(JOB_LATEST_SUCCESSFUL_BUILD_URL, job);
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                // success
                var dataObjects = response.Content.ReadAsStringAsync().Result;
                log(String.Format("Successfully fetched latest build for {0}", job), Color.LightGreen);
                return JObject.Parse(dataObjects);
            }
            else
            {
                // fail
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                var errorForm = new Error(String.Format("An error occurred while fetching latest build for {0}!\nStatus Code: {1}\nResponse Phrase: {2}", job, (int)response.StatusCode, response.ReasonPhrase));
                errorForm.ShowDialog();
                Environment.Exit(1);
                return null;
            }
        }

        public static List<String> GetServerSoftware(RichTextBox console, Func<String, Color, bool> log)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(JOBS_URL).Result;
            if (response.IsSuccessStatusCode)
            {
                // success
                List<String> software = new List<String>();
                var dataObjects = response.Content.ReadAsStringAsync().Result;
                JObject parsed = JObject.Parse(dataObjects);

                foreach(var job in parsed["jobs"])
                {
                    if (job["name"].ToString().StartsWith("Paper") && !job["name"].ToString().Contains("-Maven-Deploy") && !job["name"].ToString().Equals("PaperGradle"))
                    {
                        if (job["name"].ToString().Equals("Paper"))
                        {
                            software.Add("Paper-1.12");
                        }
                        else
                        {
                            software.Add(job["name"].ToString());
                        }
                    }

                }
                log("Successfully fetched software list", Color.LightGreen);
                return software;
            }
            else
            {
                // fail
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                var errorForm = new Error(String.Format("An error occurred while fetching server software!\nStatus Code: {0}\nResponse Phrase: {1}", (int)response.StatusCode, response.ReasonPhrase));
                errorForm.Show();
                Environment.Exit(1);
                return null;
            }
        }

        public static JArray GetBuildsForJob(string job, RichTextBox console, Func<String, Color, bool> log)
        {
            String url = string.Format(JOB_BUILDS_URL, job);
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                // success
                var dataObjects = response.Content.ReadAsStringAsync().Result;
                var obj = JObject.Parse(dataObjects);
                log(String.Format("Successfully fetched builds for {0}", job), Color.LightGreen);
                return JArray.Parse(obj["builds"].ToString());
            }
            else
            {
                // fail
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                var errorForm = new Error(String.Format("An error occurred while fetching builds for {0}!\nStatus Code: {1}\nResponse Phrase: {2}", job, (int)response.StatusCode, response.ReasonPhrase));
                errorForm.ShowDialog();
                Environment.Exit(1);
                return null;
            }
        }

        public static Artifact GetBuildArtifacts(string buildNumber, string job, RichTextBox console, Func<String, Color, bool> log)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(String.Format(JOB_BUILD_URL, job, buildNumber)).Result;
            if (response.IsSuccessStatusCode)
            {
                // success
                var dataObjects = response.Content.ReadAsStringAsync().Result;
                log(String.Format("Successfully fetched build {0} for {1}", buildNumber, job), Color.LightGreen);
                var obj = JObject.Parse(dataObjects);
                String fileName = obj["artifacts"][0]["fileName"].ToString();
                String url = String.Format(JOB_BUILD_ARTIFACT_URL, job.Replace("Paper-1.8.8", "Paper").Replace("Paper-1.9.4", "Paper").Replace("Paper-1.10.2", "Paper").Replace("Paper-1.11.2", "Paper"), buildNumber, fileName);
                Artifact artifact = new Artifact(fileName, url);
                return artifact;

            }
            else
            {
                // fail
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                var errorForm = new Error(String.Format("An error occurred while fetching build {0} for {1}!\nStatus Code: {2}\nResponse Phrase: {3}", buildNumber, job, (int)response.StatusCode, response.ReasonPhrase));
                errorForm.ShowDialog();
                Environment.Exit(1);
                return null;
            }
        }
    }
}
