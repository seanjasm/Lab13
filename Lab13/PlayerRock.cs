using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class PlayerRock : Player
    {            
        public PlayerRock()
        {
            name = "Rock Player";
            roshambo = Roshambo.rock;
        }

        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.rock;
        }
    }
}
