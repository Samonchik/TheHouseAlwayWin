namespace TheHouseAlwayWin
{
    class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();
            double odds = 0.54;
            Guy player = new Guy() { Name = "the player", Cash = 100 };
            Console.WriteLine($"Welcom to the casino. The odds are {odds}");
            while (player.Cash > 0)
            {
                player.WriteMyInfo();
                Console.Write("How much do you want to bet: ");
                string howMuch = Console.ReadLine();
                if (int.TryParse(howMuch, out int amount))
                {
                    int pot = player.GiveCash(amount) * 2;
                    if (pot > 0)
                    {

                        if (random.NextDouble() > odds)
                        {
                            player.ReciveCash(pot);
                            Console.WriteLine($"\tYou win {pot}");
                        }
                        else
                        {
                            Console.WriteLine("\tBad Luck. You lose.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter correct number");
                    }

                }
            }

            Console.WriteLine("The house always win.");
        }
    }
}
