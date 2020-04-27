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

namespace PaperSpigotServerBuilder
{
    static class Program
    {
        public static string JOB_LATEST_SUCCESSFUL_BUILD_URL = "https://papermc.io/ci/job/{0}/lastSuccessfulBuild/api/json";
        public static string JOBS_URL = "https://papermc.io/ci/api/json?tree=jobs[name]";
        public static string JOB_BUILDS_URL = "https://papermc.io/ci/job/{0}/api/json?tree=builds[number,url,artifacts[fileName,relativePath]]";

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


        public static JObject GetLatestSuccessfulBuildForJob(string job)
        {
            String url = string.Format(JOB_LATEST_SUCCESSFUL_BUILD_URL, job);
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                // success
                var dataObjects = response.Content.ReadAsStringAsync().Result;
                return JObject.Parse(dataObjects);
            }
            else
            {
                // fail
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                var errorForm = new Error(String.Format("An error occurred while fetching latest build for {0}!\nStatus Code: {1}\nResponse Phrase: {2}", job, (int)response.StatusCode, response.ReasonPhrase));
                errorForm.ShowDialog();
                return null;
            }
        }

        public static List<String> GetServerSoftware()
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
                software.Add("Waterfall");
                return software;
            }
            else
            {
                // fail
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                var errorForm = new Error(String.Format("An error occurred while fetching server software!\nStatus Code: {0}\nResponse Phrase: {1}", (int)response.StatusCode, response.ReasonPhrase));
                errorForm.Show();
                return null;
            }
        }

        public static JArray GetBuildsForJob(string job)
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
                return JArray.Parse(obj["builds"].ToString());
            }
            else
            {
                // fail
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                var errorForm = new Error(String.Format("An error occurred while fetching builds for {0}!\nStatus Code: {1}\nResponse Phrase: {2}", job, (int)response.StatusCode, response.ReasonPhrase));
                errorForm.ShowDialog();
                return null;
            }
        }
    }
}
