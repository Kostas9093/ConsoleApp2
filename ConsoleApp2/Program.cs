using System;

  class Programm
  {
      static void Main(string[] args)
      {
             Random random = new Random();
             bool playAgain = true;
             string player;
             string computer;
             string answer;

        while (playAgain)
        {
            player = "";
            computer = "";
            answer = "";

            while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
            {
                Console.Write("ENTER ROCK, PAPER, OR SCISSORS : ");
                player = Console.ReadLine();
                player = player.ToUpper();

            }

            switch (random.Next(1, 4))
            {
                case 1:
                    computer = "ROCK";
                    break;
                case 2:
                    computer = "PAPER";
                    break;
                case 3:
                    computer = "SCISSORS";
                    break;
            }

            Console.WriteLine("Player " + player);
            Console.WriteLine("Computer " + computer);

            switch (player)
            {
                case "ROCK":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("You lose!");
                    }
                    else
                    {
                        Console.WriteLine("You win!");
                    }
                    break;
                case "PAPER":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("You win!");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else
                    {
                        Console.WriteLine("You lose!");
                    }
                    break;
                case "SCISSORS":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("You lose!");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("You win!");
                    }
                    else
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    break;
            }

            Console.WriteLine("WOULD YOU LIKE TO PLAY AGAIN (Y/N):");
            answer = Console.ReadLine();
            answer = answer.ToUpper();

            if (answer == "Y")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }
            
        }
           
            Console.WriteLine("THANK YOU FOR PLAYING!!!! ");

            Console.ReadKey();
      }
  }

