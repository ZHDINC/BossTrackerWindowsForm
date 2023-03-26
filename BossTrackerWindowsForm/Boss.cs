using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BossTrackerWindowsForm
{
    internal class Boss : INotifyPropertyChanged
    {
        private string bossName;
        private int timesFought;
        private int timesWon;
        private bool victoryAchieved;

        public event PropertyChangedEventHandler PropertyChanged;

        public Boss(string bossName, int timesFought,  bool victoryAchieved, int timesWon)
        {
            this.bossName = bossName;
            this.timesFought = timesFought;
            this.victoryAchieved = victoryAchieved;
            this.timesWon = timesWon;
        }

        public Boss(string parseString)
        {
            var tempString = parseString.Split(',');
            this.bossName = tempString[0];
            this.timesFought = Int32.Parse(tempString[1]);
            this.timesWon = Int32.Parse(tempString[2]);
            this.victoryAchieved = bool.Parse(tempString[3]);

        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string BossName { get { return bossName; } set { bossName = value; NotifyPropertyChanged("BossName"); } }
        public int TimesFought { get { return timesFought; } set { timesFought = value; } }
        public bool VictoryAchieved { get { return victoryAchieved; } set { victoryAchieved = value; } }
        public int TimesWon { get { return timesWon; } set { timesWon = value; } }
    }
}
