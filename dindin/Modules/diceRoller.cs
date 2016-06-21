using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace dindin.Modules
{
    public partial class diceRoller : Form
    {
        public diceRoller()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(diceRoller_KeyDown);
            r = new Random();

            totalPerDie = new int[7];

            for (int i = 0; i < 7; ++i)
            {
                totalPerDie[i] = 0;
            }
        }

        private void diceRoller_Load(object sender, EventArgs e)
        {

        }

        List<int> dice = new List<int>();
        int[] totalPerDie;
        Random r;
        int subtotal = 0;
        int total = 0;

        int manyD4 = 0;
        int manyD6 = 0;
        int manyD8 = 0;
        int manyD10 = 0;
        int manyD12 = 0;
        int manyD20 = 0;
        int manyD100 = 0;
        
        void diceRoller_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == Settings.s.escapeKey) this.Close();

            if (e.KeyCode.ToString() == "Back")
            {
                dice.Clear();
                manyD4 = 0;
                manyD6 = 0;
                manyD8 = 0;
                manyD10 = 0;
                manyD12 = 0;
                manyD20 = 0;
                manyD100 = 0;
                total = 0;
                subtotal = 0;
                diceText.Text = "";
            }

            if (e.KeyCode.ToString() == "D4")
            {
                diceText.Text += "D4; ";
                dice.Add(4);
                manyD4++;
            }

            if (e.KeyCode.ToString() == "D6")
            {
                diceText.Text += "D6; ";
                dice.Add(6);
                manyD6++;
            }

            if (e.KeyCode.ToString() == "D8")
            {
                diceText.Text += "D8; ";
                dice.Add(8);
                manyD8++;
            }

            if (e.KeyCode.ToString() == "D1")
            {
                diceText.Text += "D10; ";
                dice.Add(10);
                manyD10++;
            }

            if (e.KeyCode.ToString() == "D2")
            {
                diceText.Text += "D20; ";
                dice.Add(20);
                manyD20++;
            }

            if (e.KeyCode.ToString() == "D3")
            {
                diceText.Text += "D12; ";
                dice.Add(12);
                manyD12++;     
            }

            if (e.KeyCode.ToString() == "D0")
            {
                diceText.Text += "D100; ";
                dice.Add(100);
                manyD100++;
            }

          

            if (e.KeyCode.ToString() == "Return")
            {
                if (dice.Count == 0) return;

                diceSummary.Text = "";

                manyD4 = 0;
                manyD6 = 0;
                manyD8 = 0;
                manyD10 = 0;
                manyD12 = 0;
                manyD20 = 0;
                manyD100 = 0;
                total = 0;
                subtotal = 0;

                for (int i=0;i<7;++i)
                {
                    totalPerDie[i] = 0;
                }

                for (int i = 0; i < dice.Count; i++)
                {
                    subtotal = 0;
                    subtotal = r.Next(1, dice[i]);
                    total += subtotal;

                    switch (dice[i])
                    {
                        case 4:
                            totalPerDie[0] += subtotal;
                            manyD4++;
                            break;

                        case 6:
                            totalPerDie[1] += subtotal;
                            manyD6++;
                            break;

                        case 8:
                            totalPerDie[2] += subtotal;
                            manyD8++;
                            break;

                        case 10:
                            totalPerDie[3] += subtotal;
                            manyD10++;
                            break;

                        case 12:
                            totalPerDie[4] += subtotal;
                            manyD12++;
                            break;

                        case 20:
                            totalPerDie[5] += subtotal;
                            manyD20++;
                            break;

                        case 100:
                            totalPerDie[6] += subtotal;
                            manyD100++;
                            break;
                    }
                }

                diceSummary.Text += manyD4 + "d4: " + totalPerDie[0] + "\r\n";
                diceSummary.Text += manyD6 + "d6: " + totalPerDie[1] + "\r\n";
                diceSummary.Text += manyD8 + "d8: " + totalPerDie[2] + "\r\n";
                diceSummary.Text += manyD10 + "d10: " + totalPerDie[3] + "\r\n";
                diceSummary.Text += manyD12 + "d12: " + totalPerDie[4] + "\r\n";
                diceSummary.Text += manyD20 + "d20: " + totalPerDie[5] + "\r\n";
                diceSummary.Text += manyD100 + "d100: " + totalPerDie[6] + "\r\n";
                diceSum.Text = "Total: " + total;
            }
        }

        private void diceSum_Click(object sender, EventArgs e)
        {

        }
    }
}
