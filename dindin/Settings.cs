using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace dindin
{
    class Settings
    {
        public string modWindow = "F12";
        public string conditionWindow = "F11";
        public string noteWindow = "F1";
        public string escapeKey = "Escape";
        public string autocompletion = "Return";

        public bool ok = false;
        TextReader tr;
        string[] d;

        public static Settings s;

        public Settings()
        {
            s = this;
            loadConfig();
        }

        public void loadConfig()
        {
            if (!Directory.Exists("./Data/")) Directory.CreateDirectory("./Data/");

            if (File.Exists("./Data/Config.txt") == false)
            {
                TextWriter tw = new StreamWriter("./Data/Config.txt");

                tw.WriteLine("notewindow=F1");
                tw.WriteLine("modwindow=F12");
                tw.WriteLine("conditionwindow=F11");
                tw.WriteLine("escape=Escape");
                tw.WriteLine("autocompletion=Return");

                tw.Close();
            }

            tr = new StreamReader("./Data/Config.txt");
            string line = tr.ReadLine();

            while (line != null)
            {
                d = line.Split('=');

                if (d[0] == "notewindow") noteWindow = d[1];
                if (d[0] == "modwindow") modWindow = d[1];
                if (d[0] == "conditionwindow") conditionWindow = d[1];
                if (d[0] == "escape") escapeKey = d[1];

                line = tr.ReadLine();
            }

            tr.Close();

            ok = true;
        }

        public void saveConfig()
        {
            TextWriter tw = new StreamWriter("./Data/Config.txt");

            tw.WriteLine("notewindow=" + noteWindow);
            tw.WriteLine("modwindow=" + modWindow);
            tw.WriteLine("conditionwindow=" + conditionWindow);
            tw.WriteLine("escape=" + escapeKey);
            tw.WriteLine("autocompletion=" + autocompletion);

            tw.Close();
        }
    }
}
