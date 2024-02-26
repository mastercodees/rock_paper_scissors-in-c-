using System;



     class Program
    {
        public static void Main()
        {
            string inputPlayer;
            string inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;
            
            Console.WriteLine("Choose between ROCK, PAPER and SCISSORS");
            inputPlayer = Console.ReadLine();
            Random random_number = new Random();

            randomInt = random_number.Next(1, 4);

            switch (randomInt)
            {
                case 1:
                    inputCPU = "ROCK";
                    Console.WriteLine("Computer chose ROCK");
                    if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("DRAW");
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("player WINS!");
                        scorePlayer++;
                    }
                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("CPU WINS!");
                        scoreCPU++; 
                    }
                        
                    break;
                case 2:
                    inputCPU = "PAPER";
                    
                    Console.WriteLine("Computer chose PAPER");
                    if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("DRAW");
                    }
                    else if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("CPU WINS!");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("player WINS!");
                        scorePlayer++; 
                    }

                    break;
                case 3:
                    inputCPU = "SCISSORS";
                    Console.WriteLine("Computer chose SCISSORS");
                    if (inputPlayer == "SCISSORS")
                    {
                        Console.WriteLine("DRAW");
                    }
                    else if (inputPlayer == "PAPER")
                    {
                        Console.WriteLine("CPU WINS!");
                        scoreCPU++;
                    }
                    else if (inputPlayer == "ROCK")
                    {
                        Console.WriteLine("PLAYER WINS!");
                        scorePlayer++; 
                    }

                    break;
                    
                default:
                    Console.WriteLine("Invalid entry!");
                    break;
                        
                
            }

        }
    }
