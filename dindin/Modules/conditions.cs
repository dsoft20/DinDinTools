using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace dindin.Modules
{
    public partial class conditions : Form
    {
        public conditions()
        {
            InitializeComponent();

            string[] d;
            string[]fn = Directory.GetFiles("./data/conditions/");
            
            for (int i=0;i<fn.Length;++i)
            {
                d = fn[i].Split('/');
                d = d[d.Length - 1].Split('.');
                filenames.Add(d[0]);
              //  filenames.Add(fn[i].Replace(".txt", ""));
            }

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(conditions_KeyDown);
            timer1.Stop();
        }

        List<string> filenames = new List<string>();

        private void conditions_Load(object sender, EventArgs e)
        {
           
        }
       
        TextReader r;
        
        void loadDescOnLabel(string name)
        {
  
            r = new StreamReader(name);
           // label1.Text = r.ReadToEnd();
            conditionText.Text = r.ReadToEnd();
            r.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
            if (conditionName.Text.Length < 3)
            {
                conditionText.Text = "";
                conditionNameLabel.Text = "";
                return;
            }

            timer1.Start();
            for (int i=0;i<filenames.Count;++i)
            {
                if (filenames[i].Contains(conditionName.Text))
                {
                    conditionNameLabel.Text = filenames[i];
                    loadDescOnLabel("./data/conditions/"+filenames[i] + ".txt");
                }
            }
        }

        void conditions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "Escape")
            {
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            conditionName.Select(0, conditionName.Text.Length);
        }
    }
}
