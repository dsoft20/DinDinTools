using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace dindin
{
    class exporters
    {
        public void notesToHTML()
        {
            List<string> filenames = new List<string>();
            List<string> notes = new List<string>();
            List<string> links = new List<string>();
            bool note = false;
            int index = 0;
            int delta = 0;
            bool eof = false;
            TextReader n;
            TextWriter w;

            string[] d;
            string[] fn = Directory.GetFiles("./Data/Notes/");
            filenames.Clear();

            string tt;

            if (!Directory.Exists("./Data/Html/")) Directory.CreateDirectory("./Data/Html/");

            for (int i = 0; i < fn.Length; ++i)
            {
                d = fn[i].Split('/');
                d = d[d.Length - 1].Split('.');
                filenames.Add(d[0]);
            }

            for (int i = 0; i < filenames.Count; ++i)
            {
                string parse = "";             

                n = new StreamReader("./Data/Notes/"+filenames[i]+".txt");
                parse = n.ReadToEnd();
                n.Close();

                parse = parse.Replace(System.Environment.NewLine, "<br>");

                for (int x = 0; x < parse.Length; x++)
                {
                    if (note == false)
                    {
                        if (parse[x] == '%')
                        {
                            note = true;
                            index = x;
                        }
                    }

                    if (note == true)
                    {
                        while (parse[x] != ' ')
                        {
                            if (x >= parse.Length - 1)
                            {
                                eof = true;
                                break;
                            }

                            if (parse[x] == '%' && index != x)
                            {
                                x -= 1;
                                break;
                            }

                            delta++;
                            ++x;
                        }

                        if (eof)
                        {                     
                            tt = parse.Substring(index + 1, delta);
                        }
                        else
                        {
                            tt = parse.Substring(index + 1, delta - 1);
                        }

                        tt = tt.Replace(" ", "");
                        tt = tt.Replace("%", "");
                        tt = tt.Replace('\n', ' ');
                        tt = tt.Replace('\r', ' ');
                        tt = tt.Replace("<br>", "");
                        tt = tt.Replace(System.Environment.NewLine, "");
                        tt = tt.TrimEnd();

                        if (!links.Contains(tt)) links.Add(tt);

                        if (!File.Exists("./Data/Notes/"+tt+".txt"))
                        {
                            w = new StreamWriter("./Data/Notes/" + tt + ".txt");
                            w.Write("");
                            w.Close();
                            filenames.Add(tt);
                        }

                        index = 0;
                        delta = 0;
                        note = false;
                    }
                }


                for (int y=0;y<links.Count;y++)
                {                    
                    parse = parse.Replace(("%" + links[y]), "<a href=\"" + links[y] + ".html\">" + links[y] + "</a>");
                }

                w = new StreamWriter("./Data/Html/" + filenames[i] + ".html");

                w.Write("<font face=Calibri size = \"10\" color = \"red\"><i>" + filenames[i].Substring(0, 1).ToUpper() + filenames[i].Substring(1, filenames[i].Length - 1) + ":</i></font><br><hr><font face=Calibri size=4>");
                w.Write(parse);
                w.Write("</font><br><hr>");
                w.Write("<font size = \"2\" color = \"red\">Last saved:"  + File.GetLastWriteTime("./Data/Notes/" + filenames[i] + ".txt")+"</font>");
                w.Close();
            }
        }
    }
}
