using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    public class PlayerUser : Player
    {
        public PlayerUser()
        {
            name = UserInput.GetUserInput("What is your name: ");
        }

        public override Roshambo GenerateRoshambo()
        {
            DisplayMenu();
            int choice = UserInput.GetUserInputAsInteger("Make a selection: ");
            if(choice > 0 && choice < 4)
            {
                roshambo = (Roshambo)choice;
            }
            else
            {
                Console.Clear();
                return GenerateRoshambo();
            }

            return roshambo;
        }

        private void DisplayMenu()
        {
            UserInput.Display("\n1................Rock");
            UserInput.Display("2................Paper");
            UserInput.Display("3................Scissors");
        }
    }
}
