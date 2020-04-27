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
    public partial class Error : Form
    {
        private string MESSAGE;

        public Error(string message)
        {
            this.MESSAGE = message;
            InitializeComponent();
        }

        private void Error_Load(object sender, EventArgs e)
        {
            errorText.Text = this.MESSAGE;
        }
    }
}
