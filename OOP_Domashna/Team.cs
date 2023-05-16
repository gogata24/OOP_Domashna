using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Domashna
{
     public class Team
    {
        private Coach coach;
        private List<FootballPlayer> players;
        public Coach Coach
        {
            get { return coach; }
            set { coach = value; }
        }
        public List<FootballPlayer> Players
        {
            get { return players; }
            set
            {
                if(players.Count>=11&&Players.Count<=22)
                {
                    players = value;
                }
                else
                {
                    throw  new Exception("Players must be between 11 and 22");
                }
            }
        }
        public double AverageAge()
        {
            double sum = 0;
            foreach (var x in players)
            {
                sum += x.Age;
            }
            return sum/players.Count;
        }
        public  Team(Coach coach, List<FootballPlayer> footballPlayers)
        {
            Coach = coach;
            players = footballPlayers;
        }
    }
}
