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
    public partial class InternetCheckInProgress : Form
    {
        public InternetCheckInProgress()
        {
            InitializeComponent();
        }

        private void InternetCheckInProgress_Load(object sender, EventArgs e)
        {
            var connection = Program.CheckForInternetConnection();
            this.Hide();
            if (connection)
            {
                var mainForm = new MainForm();
                mainForm.ShowDialog();
                this.Close();
            } else
            {
                var noInternet = new NoInternet();
                noInternet.ShowDialog();
                this.Close();
            }
        }
    }
}
