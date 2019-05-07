using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    public class RoshamboApp
    {
        public void Start()
        {
            PlayerUser playerUser = new PlayerUser();
            Player computer = SelectPlayer();
            bool repeat = true;

            while (repeat)
            {
                Console.Clear();
                ShowGameStats(computer, playerUser);
                playerUser.GenerateRoshambo();
                computer.GenerateRoshambo();

                if(playerUser.IsWinner(computer))
                {
                    UserInput.Display($"\n\n{playerUser.GetName()} wins!\n\n");
                    computer.Lost();
                }
                else if(computer.IsWinner(playerUser))
                {
                    UserInput.Display($"\n\n{computer.GetName()} wins!\n\n");
                }
                else
                {
                    UserInput.Display("\n\nGame draw!\n\n");
                }                
                repeat = UserInput.UserConfirmationPrompt("Play again(Y/N)? ");
            }

            UserInput.Display($"Thanks for playing {playerUser.GetName()}\n\n");
            
        }


        public void ShowGameStats(Player player1, Player Player2)
        {
            Console.Write(string.Format("{0,-30}{1,-6}{2}\n", "Name", "Wins", "Losses"));
            UserInput.Display(player1.ToString());
            UserInput.Display(Player2.ToString());
        }

        public Player SelectPlayer()
        {
            UserInput.Display("1................Rock Player");
            UserInput.Display("2................Random Player");

            int player = UserInput.GetUserInputAsInteger("\n\nSelect a player: ");
            if(player == 1)
            {
                return new PlayerRock();
            }
            else if (player == 2)
            {
                return new PlayerRandom();
            }
            return SelectPlayer();
        }
    }
}
