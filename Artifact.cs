using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperSpigotServerBuilder
{
    class Artifact
    {
        public string FileName { get; }
        public string URL { get; }
        public Artifact(String fileName, String url)
        {
            FileName = fileName;
            URL = url;
        }
    }
}
