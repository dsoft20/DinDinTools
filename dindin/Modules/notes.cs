using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            if (noteText.Text != "")
            {
                if (noteName.Text.Length > 2)
                {
                    w = new StreamWriter("./data/notes/" + noteName.Text + ".txt");
                    w.Write(noteText.Text);
                    w.Close();
                    saveStateLabel.ForeColor = Color.Green;
                    cansave = false;
                }
            }
        }

        void loadNotes()
        {
            string[] d;
            string[] fn = Directory.GetFiles("./data/notes/");

            for (int i = 0; i < fn.Length; ++i)
            {
                d = fn[i].Split('/');
                d = d[d.Length - 1].Split('.');
                filenames.Add(d[0]);
            }
        }

        TextReader r;
        TextWriter w;

        void loadNotesOnText(string name)
        {
            r = new StreamReader(name);
            noteText.Text = r.ReadToEnd();
            r.Close();
            saveStateLabel.Text = "Last saved: " + File.GetLastWriteTime(name);
        }

        void notes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
            {
                this.Close();
            }
        }

        bool found = false;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            found = false;
            othersFiles.Text = "";

            if (noteName.Text.Length < 3)
            {
                saveStateLabel.Text = "";
                noteText.Text = "";
                noteLabelName.Text = "";
                return;
            }

            timer1.Start();

            for (int i = filenames.Count - 1; i >= 0; i -= 1)
            {
                if (filenames[i].Contains(noteName.Text))
                {
                    noteLabelName.Text = filenames[i];
                    loadNotesOnText("./data/notes/" + filenames[i] + ".txt");
                    found = true;

                    if (filenames[i] != noteName.Text) othersFiles.Text += filenames[i] + ",";
                }
            }

            saveStateLabel.ForeColor = Color.Black;
        }

        private void noteText_TextChanged(object sender, EventArgs e)
        {
            saveStateLabel.ForeColor = Color.Red;
        }
    }
}
