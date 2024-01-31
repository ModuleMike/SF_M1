namespace HuntingTheManticore
{
    public class ConsoleIO
    {
        public static int SetManticoreLocation(int min, int max)
        {
            while (true)
            {
                Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
                if (int.TryParse(Console.ReadLine(), out int manticoreLoc) && manticoreLoc <= max && manticoreLoc >= min)
                {
                    return manticoreLoc;
                }
                Console.WriteLine($"Invalid input. The Manticore muse be located between {min} and {max}.");
            }
        }
        public static int CannonLocation(string input, int min, int max)
        {
            while (true)
            {
                Console.Write(input);
                if (int.TryParse(Console.ReadLine(), out int cannonLoc) && cannonLoc <= max && cannonLoc >= min)
                {
                    return cannonLoc;
                }
                else
                {
                    Console.WriteLine($"Invalid input. The Cannon muse be located between {min} and {max}.");
                }
            }
        }
        public static bool RoundStatus(int manticoreLoc, int cannonLoc)
        {
            if (manticoreLoc == cannonLoc)
            {
                Console.WriteLine("That round was a DIRECT HIT!");
                return true;
            }
            else if (manticoreLoc < cannonLoc)
            {
                Console.WriteLine("That round OVER SHOT of the target.");
                return false;
            }
            else
            {
                Console.WriteLine("That round FELL SHORT of the target.");
                return false;
            }
        }
        public static void WinOrLose(int city, int manticore)
        {
            if (city == 0)
            {
                Console.WriteLine("The Manticore has destroyed the city of Consolas!!!");
                Console.WriteLine("------------------Game Over------------------------");
            }
            else if (manticore <= 0)
            {
                Console.WriteLine("The Manticore has been destroyed! The city of Consolas has been saved!!!");
                Console.WriteLine("--------------------------------You Win---------------------------------");
            }
        }
        public static bool Replay()
        {
            while (true)
            {
                Console.Write("Would you like to play again (Yes) or (No): ");
                string replay = Console.ReadLine().ToUpper();
                if (!string.IsNullOrEmpty(replay))
                {
                    if (replay == "YES")
                    {
                        return true;
                    }
                    else if (replay == "NO")
                    {
                        return false;
                    }
                    Console.WriteLine("Invalid input. Must enter 'Yes' or 'No'!");
                }
            }
        }
    }
}
