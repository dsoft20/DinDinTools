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
    public partial class notes : Form
    {
        public notes()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(notes_KeyDown);
            loadNotes();
            timer1.Stop();
            noteName.Enter += OnFocus;
            noteText.Enter += OnFocus2;  
        }

        List<string> filenames = new List<string>();

        private void notes_Load(object sender, EventArgs e)
        {

        }

        bool cansave = false;

        private void OnFocus2(object sender, EventArgs e)
        {
            cansave = true;
            noteText.SelectionStart = noteText.Text.Length;
        }

        private void OnFocus(object sender, EventArgs e)
        {
            if (cansave == false) return;
            saveNote();
            loadNote();
        }

        public void saveNote()
        {
            if (noteText.Text != "")
            {
                if (noteName.Text.Length > 0)
                {
                    bool exists = true;
                    if (!File.Exists("./Data/Notes/" + noteName.Text + ".txt")) exists = false;

                    w = new StreamWriter("./Data/Notes/" + noteName.Text + ".txt");
                    w.Write(noteText.Text);
                    w.Close();
                    saveStateLabel.ForeColor = Color.Green;
                    cansave = false;

                    if (!exists) loadNotes();
                }
            }
        }

        public void loadNotes()
        {
            if (!Directory.Exists("./Data/Notes/")) Directory.CreateDirectory("./Data/Notes/");
                      
            string[] d;
            string[] fn = Directory.GetFiles("./Data/Notes/");
            filenames.Clear();

            for (int i = 0; i < fn.Length; ++i)
            {
                d = fn[i].Split('/');
                d = d[d.Length - 1].Split('.');
                filenames.Add(d[0]);
            }
        }

        TextReader r;
        TextWriter w;

        public void loadNotesOnText(string name)
        {
            r = new StreamReader(name);
            noteText.Text = r.ReadToEnd();
            r.Close();
            saveStateLabel.Text = "Last saved: " + File.GetLastWriteTime(name);
        }

        void notes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "ControlKey")
            {
                if (noteText.Focused)
                {
                    linkedNotes ln = new linkedNotes(noteText.Text, this);
                    ln.ShowDialog();
                }
            }

            if (e.KeyCode.ToString() == Settings.s.escapeKey)
            {
                this.Close();
            }

            if (e.KeyCode.ToString() == Settings.s.autocompletion)
            {
                if (!noteName.Focused) return;
                noteName.Text = autoCompletion;
                noteName.SelectionStart = noteName.Text.Length;
            }
        }

        string autoCompletion = "";

        int clamp(int _value, int _min, int _max)
        {
            if (_value < _min) return _min;
            if (_value > _max) return _max;

            return _value;
        }

        void loadNote()
        {
            othersFiles.Text = "";

            if (noteName.Text.Length == 0)
            {
                saveStateLabel.Text = "";
                noteText.Text = "";
                noteLabelName.Text = "";
                autoCompletion = "";
                return;
            }

            timer1.Start();

            for (int i = filenames.Count - 1; i >= 0; i -= 1)
            {      
                if (filenames[i].Substring(0, clamp(noteName.Text.Length, 0, filenames[i].Length)) == noteName.Text)
                {
                    noteLabelName.Text = filenames[i];
                    loadNotesOnText("./data/notes/" + filenames[i] + ".txt");
                    autoCompletion = filenames[i];

                    if (filenames[i] != noteName.Text) othersFiles.Text += filenames[i] + ";";
                }
            }

            saveStateLabel.ForeColor = Color.Black;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            loadNote();
        }

        private void noteText_TextChanged(object sender, EventArgs e)
        {
            saveStateLabel.ForeColor = Color.Red;
        }
    }
}
