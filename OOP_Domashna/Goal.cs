using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Domashna
{
    public class Goal
    {
        private int minute;
        private FootballPlayer player;
        public int Minute
        {
            get { return minute; }
            set { minute = value; }
        }
        public FootballPlayer Player
        {
            get { return player; }
            set { player = value; }
        }
        public Goal(int min, FootballPlayer player)
        {
            Minute= min;
            Player= player;
        }
    }
}
