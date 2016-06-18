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

namespace dindin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            settings = new Settings();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        Settings settings;

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Settings.s.ok == false) return;

            if (e.KeyCode.ToString() == Settings.s.modWindow)
            {
                Modules.calculateMod cm = new Modules.calculateMod();
                cm.Show();
              
            }

            if (e.KeyCode.ToString() == Settings.s.conditionWindow)
            {
                Modules.conditions cd = new Modules.conditions();
                cd.Show();                
            }

            if (e.KeyCode.ToString() == Settings.s.noteWindow)
            {
                Modules.notes nt = new Modules.notes();
                nt.Show();
            }
        }
    }
}
