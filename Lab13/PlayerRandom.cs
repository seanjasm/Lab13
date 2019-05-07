using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    public class PlayerRandom : Player
    {
        public PlayerRandom()
        {
            this.name = "Random Player";
        }

        public override Roshambo GenerateRoshambo()
        {       
            roshambo = (Roshambo)new Random().Next(3) + 1;
            return roshambo;
        }
    }
}
