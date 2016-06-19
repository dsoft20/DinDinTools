using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dindin.Modules
{
    public partial class calculateMod : Form
    {
        public calculateMod()
        {
            InitializeComponent();
            // numericUpDown1.Select(0, 1);
            textBox1.Select(0, 1);
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(calculateMod_KeyDown);
            timer1.Stop();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             textBox1.Text = checkValid(textBox1.Text);

            if (textBox1.Text == "") textBox1.Text =""+ 0;

            if (label1.Text.Length != 0)
            {
                try
                {
                    timer1.Stop();
                    timer1.Start();
                    label1.Text = "Mod: " + Math.Floor(((decimal.Parse(textBox1.Text) - 10) / 2));
                }catch
                {

                }
            }         
        }

        void calculateMod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == Settings.s.escapeKey)
            {
                this.Close();
            }
        }

        string temp = "";
        int timp = 0;
        string checkValid(string _in)
        {
            temp = "";

            for (int i = 0; i < _in.Length; ++i)
            {
                if (int.TryParse(_in.Substring(i, 1),out timp))
                {
                    temp += "" + _in.Substring(i, 1);
                }
            }

            return temp;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Select(0, textBox1.Text.Length);
            timer1.Stop();
        }

        private void calculateMod_Load(object sender, EventArgs e)
        {

        }
    }
}
