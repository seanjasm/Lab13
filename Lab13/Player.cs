using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{

    public enum Roshambo
    {
        rock = 1,
        paper,
        scissors
    }


    public abstract class Player
    {
        protected string name;
        protected Roshambo roshambo;
        private int wins;
        private int losses;

        public Player()
        {
            losses = wins = 0;
        }

        public abstract Roshambo GenerateRoshambo();

        public string GetName()
        {
            return name;
        }       


        public bool IsWinner(Player obj)
        {
            if (this.roshambo == obj.roshambo)
            {
                return false;
            }
            else if (this.roshambo == Roshambo.paper && obj.roshambo == Roshambo.rock)
            {
                this.wins++;
                return true;
            }
            else if (this.roshambo == Roshambo.rock && obj.roshambo == Roshambo.scissors)
            {
                wins++;
                return true;
            }
            else if (this.roshambo == Roshambo.scissors && obj.roshambo == Roshambo.paper)
            {
                wins++;
                return true;
            }

            losses++;
            return false;
        }

        public int GetWins()
        {
            return wins;
        }

        public void Lost()
        {
            losses++;
        }

        public override string ToString()
        {
            return string.Format("{0,-32}{1,-6}{2}", name, wins, losses);
        }
    }
}
