using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BossTrackerWindowsForm
{
    public partial class changeBossName : Form
    {
        private string oldBossName;
        private string newBossName;
        private string currentName;
        public changeBossName(string bossName)
        {
            
            InitializeComponent();
            oldBossName = bossName;
            bossNameLabel.Text = bossName;
            newBossNameTextBox.Text = bossName;
        }

        public string BossName
        {
            get
            {
                return currentName;
            }
            set
            {
                currentName = value;
            }
        }

        private void acceptNewNameButton_Click(object sender, EventArgs e)
        {
            if (newBossNameTextBox.Text != "" && !(newBossNameTextBox.Text.Contains(";") || newBossNameTextBox.Text.Contains(",")))
            {
                BossName = newBossNameTextBox.Text.ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("New value for Boss Name either contains a semi-colon or comma (which is not allowed due to save file format) or is blank.", "Not allowed characters or blank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            BossName = oldBossName;
            this.Close();
        }
    }
}
