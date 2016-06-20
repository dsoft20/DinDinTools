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
    public partial class keyconfig : Form
    {
        public keyconfig()
        {
            InitializeComponent();

            noteWindow.Text = Settings.s.noteWindow;
            modwindow.Text = Settings.s.modWindow;
            conditionwindow.Text = Settings.s.conditionWindow;
            escape.Text = Settings.s.escapeKey;

            usedKeys = new String[5];
            usedKeys[0] = Settings.s.noteWindow;
            usedKeys[1] = Settings.s.modWindow;
            usedKeys[2] = Settings.s.conditionWindow;
            usedKeys[3] = Settings.s.escapeKey;
            usedKeys[4] = "S";

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(keyconfig_KeyDown);
        }

        int indexKey = -1;

        private void keyconfig_Load(object sender, EventArgs e)
        {

        }

        void keyconfig_KeyDown(object sender, KeyEventArgs e)
        {
            if (indexKey == -1)
            {
                if (e.KeyCode.ToString() == Settings.s.escapeKey)
                {
                    this.Close();
                }
            }

            switch (indexKey)
            {
                case 0:
                    if (isLegitKey(e.KeyCode.ToString(), 0))
                    {
                        noteWindow.Text = e.KeyCode.ToString();
                        noteWindow.ForeColor = Color.Black;
                        modwindow.ForeColor = Color.Red;
                        
                        indexKey++;
                    }
                    break;

                case 1:
                    if (isLegitKey(e.KeyCode.ToString(), 1))
                    {
                        modwindow.Text = e.KeyCode.ToString();
                        modwindow.ForeColor = Color.Black;
                        conditionwindow.ForeColor = Color.Red;
                        indexKey++;
                    }
                    break;

                case 2:
                    if (isLegitKey(e.KeyCode.ToString(), 2))
                    {
                        conditionwindow.Text = e.KeyCode.ToString();
                        conditionwindow.ForeColor = Color.Black;
                        escape.ForeColor = Color.Red;
                        indexKey++;
                    }
                    break;

                case 3:
                    if (isLegitKey(e.KeyCode.ToString(), 3))
                    {
                        escape.Text = e.KeyCode.ToString();
                        escape.ForeColor = Color.Black;
                        startConfig.Enabled = true;
                        indexKey = -1;

                        Settings.s.noteWindow = noteWindow.Text;
                        Settings.s.modWindow = modwindow.Text;
                        Settings.s.conditionWindow = conditionwindow.Text;
                        Settings.s.escapeKey = escape.Text;

                        Settings.s.saveConfig();
                        Settings.s.loadConfig();
                    }
                    break;

                case 4:

                    break;
            }
        }

        string[] usedKeys;

        bool isLegitKey(string _key, int _index)
        {
            if (usedKeys[_index] == _key)
            {
                usedKeys[_index] = _key;
                return true;
            }

            for (int i = 0; i < usedKeys.Length; ++i)
            {
                if (_key == usedKeys[i])
                {
                    return false;
                }
            }

            usedKeys[_index] = _key;
            return true;
        }

        private void startConfig_Click(object sender, EventArgs e)
        {
            startConfig.Enabled = false;
            indexKey = 0;
            noteWindow.ForeColor = Color.Red;
        }
    }
}
