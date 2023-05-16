using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Domashna
{
    public class FootballPlayer: Person
    {
        private string name;
        private int number, age;
        private double height;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public double Height
        {
            get { return height; }
            set
            {
                height = value;
            }
        }
        public FootballPlayer(string name, int number, int age, double height)
        { 
            Name = name;
            Number = number;
            Age = age;
            Height = height;
        }
    }
}
