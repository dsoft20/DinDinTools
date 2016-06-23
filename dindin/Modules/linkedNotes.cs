using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;

namespace dindin.Modules
{
    public partial class linkedNotes : Form
    {
        public linkedNotes(string _textToCheck, notes _n)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(linkedNotes_KeyDown);
            parseLinks(_textToCheck);
            n = _n;
        }

        private void linkedNotes_Load(object sender, EventArgs e)
        {
            this.Left = 32;
        }

        List<string> links = new List<string>();
        notes n;

        void addLinkedNote(string _s)
        {
            string nn = _s;
            nn = nn.Replace('\n', ' ');
            nn = nn.Replace('\r', ' ');
            nn = nn.TrimEnd();

            if (links.Contains(nn)) return;

            links.Add(nn);
        }

        void parseLinks(string _textToCheck)
        {
            string t = _textToCheck;
            bool note = false;
            int index = 0;
            int delta = 0;
            bool eof = false;

            for (int i = 0; i < t.Length; i++)
            {
                if (note == false)
                {
                    if (t[i] == '%')
                    {
                        note = true;
                        index = i;
                    }
                }

                if (note == true)
                {
                    while (t[i] != ' ')
                    {   
                        if (i >= t.Length - 1)
                        {
                            eof = true;
                            break;
                        }

                        if(t[i] =='%' && index !=i)
                        {
                            i -= 1;           
                            break;
                        }
                        delta++;
                        ++i;
                    }

                    if (eof)
                    {
                        addLinkedNote(t.Substring(index + 1, delta));
                    }
                    else
                    {
                        addLinkedNote(t.Substring(index + 1, delta - 1));
                    }

                    index = 0;
                    delta = 0;
                    note = false;
                }
            }

            for (int i=0;i<links.Count;i++)
            {
                lnks.Items.Add(links[i]);
            }

            if (links.Count != 0) lnks.SelectedIndex = 0;
        }

        void loadLinkedNote(string noteName)
        {
            string nn = noteName;
            nn = nn.Replace('\n', ' ');
            nn = nn.Replace('\r', ' ');
            nn = nn.TrimEnd();
          
            if (!File.Exists("./Data/Notes/" + nn + ".txt"))
            {
                TextWriter tw = new StreamWriter("./Data/Notes/" + nn + ".txt");
                tw.Write("");
                tw.Close();
            }

            n.noteName.Text = nn;
            n.noteName.SelectionStart = n.noteName.Text.Length;
            n.loadNotesOnText("./Data/Notes/" + nn + ".txt");
            n.noteText.Focus();
            n.noteText.SelectionStart = n.noteText.Text.Length;
            links.Clear();
        }

        void linkedNotes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == Settings.s.escapeKey)
            {
                this.Close();
            }

            if (e.KeyCode.ToString()=="Return")
            {                
                n.saveNote();
                loadLinkedNote((string)lnks.SelectedItem);
                this.Close();
            }
        }
    }
}
