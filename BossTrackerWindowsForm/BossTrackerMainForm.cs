using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BossTrackerWindowsForm
{
    public partial class BossTrackerMainForm : Form
    {
        BindingList<Boss> bosses { get; set; }
        BindingSource bindSource;
        public BossTrackerMainForm()
        {
            bosses = new BindingList<Boss>();
            bosses.AllowNew = true;
            bosses.AllowRemove = true;
            bosses.RaiseListChangedEvents = true;
            bosses.AllowEdit = true;
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedItems.Count > 0)
            {
                var selectedBoss = (Boss)listBox1.SelectedItem;
                bossNameLabel.Text = selectedBoss.BossName;
                bossFoughtInt.Value = selectedBoss.TimesFought;
                bossVictoryInt.Value = selectedBoss.TimesWon;
                beatenCheckBox.Checked = selectedBoss.VictoryAchieved;
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            var result = openFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                this.Text = openFileDialog.FileName;
                FileStream stream = new FileStream(openFileDialog.FileName, FileMode.Open);
                StreamReader streamReader = new StreamReader(stream);
                var filecontents = streamReader.ReadToEnd();
                if (filecontents.Length > 0)
                {
                    var splitstrings = filecontents.Split(';');
                    foreach (string splitstring in splitstrings)
                    { 
                        Boss boss = new Boss(splitstring.Trim());
                        bosses.Add(boss);
                    }
                }
                streamReader.Close();
                stream.Close();

                listBox1.DataSource = bosses;
                listBox1.DisplayMember = "bossName";
            }
        }

        private void bossFoughtInt_ValueChanged(object sender, EventArgs e)
        {
            var selectedBoss = (Boss)listBox1.SelectedItem;
            selectedBoss.TimesFought = (int)bossFoughtInt.Value;
        }

        private void bossVictoryInt_ValueChanged(object sender, EventArgs e)
        {
            var selectedBoss = (Boss)listBox1.SelectedItem;
            selectedBoss.TimesWon = (int)bossVictoryInt.Value;
        }

        private void bossAdd_Click(object sender, EventArgs e)
        {
            if (bossAddTextBox.Text != "" && !(bossAddTextBox.Text.Contains(',') || bossAddTextBox.Text.Contains(';')))
            {
                bosses.Add(new Boss(bossAddTextBox.Text, 0, false, 0));
                listBox1.DataSource = bosses;
                listBox1.DisplayMember = "bossName";
                bossAddTextBox.Text = "";
                bossAddTextBox.BackColor = Color.White;
            }
            if(bossAddTextBox.Text.Contains(',') || bossAddTextBox.Text.Contains(';'))
            {
                MessageBox.Show("Boss name text value cannot contain a comma or a semicolon. These characters are used to make the save file work. Sorry.", "Not allowed characters", MessageBoxButtons.OK, MessageBoxIcon.Error);
                bossAddTextBox.BackColor = Color.Red;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files | .txt";
            saveFileDialog.DefaultExt = ".txt";
            var result = saveFileDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                this.Text = saveFileDialog.FileName;
                string overallString = "";
                foreach(Boss boss in bosses)
                {
                    overallString += boss.BossName + "," + boss.TimesFought.ToString() + "," + boss.TimesWon.ToString() + "," + boss.VictoryAchieved.ToString() + ";";
                }
                
                FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.Write(overallString.TrimEnd(';'));
                streamWriter.Close();
                fileStream.Close();
            }
        }

        private void BossTrackerMainForm_Load(object sender, EventArgs e)
        {

        }

        private void beatenCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            var selectedBoss = (Boss)listBox1.SelectedItem;
            selectedBoss.VictoryAchieved = (bool)beatenCheckBox.Checked;
        }
    }
}
