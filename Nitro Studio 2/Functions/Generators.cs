using NitroFileLoader;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NitroStudio2.Functions
{
    public static class Generators
    {
        public static SoundArchive MakeSdatFromSarc(string sarcFile)
        {
            // Firstly, we need to perform initalisers
            SoundArchive a = new SoundArchive();
            string type = "";
            string path = "";
            string[] sarc = File.ReadAllLines(sarcFile);

            foreach (string ln in sarc)
            {
                if(ln.StartsWith("@"))
                {
                    string[] syntax = ln.Split(' ');
                    if(syntax.First() == "@PATH")
                    {
                        syntax.Last().Replace("\"", "");
                        path = Environment.CurrentDirectory + syntax.Last();
                        Debug.WriteLine("Set path to " + path);
                    } else
                    {
                        type = syntax.First().Replace("@", "");
                    }
                } else
                {

                }
            }


            return a;
        }
    }
}
