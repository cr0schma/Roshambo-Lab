using Roshambo;
using System.Reflection.Emit;

bool playagain;

Console.WriteLine("Welcome to Rock Paper Scissors!");
Console.Write("Enter your name: ");
HumanPlayer player1 = new HumanPlayer();
player1.Name = Console.ReadLine();

do
{
    playagain = false;
    string playerValidate;
    string opponent;
    do
    {
        playerValidate = "n";
        Console.Write("Would you like to play against The RockPlayer or RandomPlayer? (rock/random): ");
        opponent = Console.ReadLine();
        if (opponent.ToLower() != "rock" && opponent.ToLower() != "random")
        {
            Console.Write("Invalid selection, try again? (y/n): ");
            playerValidate = Console.ReadLine();
        }
        else {
            string rpcValidate;
            do
            {
                rpcValidate = "n";
                Console.Write("Rock, paper, or scissors? (R/P/S): ");
                string rpc = Console.ReadLine();
                Roshambo.Roshambo rpcSwitch = new Roshambo.Roshambo();

                // Validate user input
                if (rpc.ToLower() != "r" && rpc.ToLower() != "p" && rpc.ToLower() != "s")
                {
                    Console.Write("Invalid selection, try again? (y/n): ");
                    rpcValidate = Console.ReadLine();
                }
                else
                {
                    // Determine which enum to choose and set player's choice
                    switch (rpc)
                    {
                        case "r":
                            rpcSwitch = Roshambo.Roshambo.rock;
                            break;
                        case "p":
                            rpcSwitch = Roshambo.Roshambo.paper;
                            break;
                        case "s":
                            rpcSwitch = Roshambo.Roshambo.scissors;
                            break;
                    }
                    player1.RoshamboValue = rpcSwitch;

                    // Begin match
                    Roshambo.Roshambo opponentDecision = new Roshambo.Roshambo();
                    string opponentName = string.Empty;
                    if (opponent == "rock")
                    {
                        RockPlayer rockPlayer = new RockPlayer();
                        opponentName = rockPlayer.Name = "RockPlayer";
                        opponentDecision = rockPlayer.GenerateRoshambo();
                    }
                    if (opponent == "random")
                    {
                        RandomPlayer randomPlayer = new RandomPlayer();
                        opponentName = randomPlayer.Name = "RandomPlayer";
                        opponentDecision = randomPlayer.GenerateRoshambo();
                    }

                    // Determine who wins
                    Console.WriteLine($"{player1.Name}: {player1.RoshamboValue}");
                    Console.WriteLine($"{opponentName}: {opponentDecision}");


                    switch (player1.RoshamboValue)
                    {
                        case Roshambo.Roshambo.paper:
                            if (opponentDecision == Roshambo.Roshambo.rock)
                            {
                                Console.WriteLine($"{player1.Name} Wins!");
                            }
                            else if (opponentDecision == Roshambo.Roshambo.paper)
                            {
                                Console.WriteLine("Draw!");
                            }
                            else
                            {
                                Console.WriteLine($"{opponentName} Wins!");
                            }
                            break;
                        case Roshambo.Roshambo.rock:
                            if (opponentDecision == Roshambo.Roshambo.rock)
                            {
                                Console.WriteLine("Draw!");
                            }
                            else if (opponentDecision == Roshambo.Roshambo.paper)
                            {
                                Console.WriteLine($"{opponentName} Wins!");
                            }
                            else
                            {
                                Console.WriteLine($"{player1.Name} Wins!");
                            }
                            break;
                        case Roshambo.Roshambo.scissors:
                            if (opponentDecision == Roshambo.Roshambo.rock)
                            {
                                Console.WriteLine($"{opponentName} Wins!");
                            }
                            else if (opponentDecision == Roshambo.Roshambo.paper)
                            {
                                Console.WriteLine($"{player1.Name} Wins!");
                            }
                            else
                            {
                                Console.WriteLine("Draw!");
                            }
                            break;
                    }

                    Console.Write("Play again? (y/n): ");
                    string answer = Console.ReadLine();

                    //determine to loop depending on user's answer
                    if (answer.ToLower() == "y")
                    {
                        playagain = true;
                    }
                }
            } while (rpcValidate.ToLower() == "y");
        }
    } while (playerValidate.ToLower() == "y");
} while (playagain);