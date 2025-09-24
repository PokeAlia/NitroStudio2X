using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NitroStudio2.Functions
{
    public class Configuration
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\NitroStudio2\\config.ini";
        public Dictionary<string, string> Settings = new Dictionary<string, string>();

        public void ReadConfig(StreamReader r)
        {
            if (r.ReadLine() == "[NitroStudio2]") {
                r.Close();
                foreach (string l in File.ReadAllLines(path))
                {
                    if (l != "[NitroStudio2]")
                    {
                        if(!l.StartsWith("#"))
                        {
                            string[] setting = l.Replace(" ", "").Replace("\t", "").Split('=');
                            Settings.Add(setting.First(), setting.Last().Split('#').First());
                        }
                    }
                }
            } else
            {
                r.Close();
                GenerateConfig();
            }
        }

        public void GenerateConfig()
        {
            Settings.Add("writeNames", "true");         // Write Names
            Settings.Add("importTool", "NitroStudio");  // Import Mode
            Settings.Add("exportTool", "NitroStudio");  // Export Mode
            WriteConfig();
        }

        public void WriteConfig()
        {
            if (!Directory.Exists(path.Replace("\\config.ini", "")))
            {
                Directory.CreateDirectory(path.Replace("\\config.ini", ""));
            }
            using (StreamWriter w = new StreamWriter(path))
            {
                w.WriteLine("[NitroStudio2]");
                foreach(var s in Settings.Keys)
                {
                    w.WriteLine(s + " = " + Settings[s]);
                }
            }
        }

        public Configuration()
        {
            if (File.Exists(path))
            {
                ReadConfig(new StreamReader(path));
            }
            else
            {
                GenerateConfig();
            }
        }
    }
}

