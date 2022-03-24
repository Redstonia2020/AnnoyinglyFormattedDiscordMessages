using System;

namespace AnnoyinglyFormattedDiscordMessages
{
    class Program
    {
        public static Random rnd = new Random();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type in your message below to be formatted");
                string message = Console.ReadLine();
                string formatted = "";

                foreach (char c in message)
                {
                    string addition = c.ToString();
                    if (Coin())
                    {
                        addition = "`" + addition + "`";
                    }

                    if (Coin())
                    {
                        addition = "_" + addition + "_";
                    }

                    if (Coin())
                    {
                        addition = "**" + addition + "**";
                    }

                    if (Coin())
                    {
                        addition = "__" + addition + "__";
                    }

                    formatted += addition + " ";
                }

                Console.WriteLine($"\nFormatted successfully!\n{formatted}\n");
            }
        }

        public static bool Coin()
        {
            return rnd.Next(0, 2) == 0;
        }
    }
}
