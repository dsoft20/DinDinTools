using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "F12")
            {
                Modules.calculateMod cm = new Modules.calculateMod();
                cm.Show();
              
            }

            if (e.KeyCode.ToString() == "F11")
            {
                Modules.conditions cd = new Modules.conditions();
                cd.Show();                
            }

            if (e.KeyCode.ToString()=="F1")
            {
                Modules.notes nt = new Modules.notes();
                nt.Show();
            }
        }
    }
}
