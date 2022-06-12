namespace PalindromePossibility
{
    using System;
    class PalindromePossibility
    {
        static void Main(string[] args)
        {
            string Pal = "OoveoO"; //or Console.ReadLine();
            string symbol = null;

            int counter = 0;

            for (int i = 0; i < Pal.Length / 2; i++)
            {
                if (Pal[i] != Pal[Pal.Length - i - 1])
                {
                    symbol += Pal[i];
                    if (counter > 1) break;
                    else counter++;
                }
                else { continue; }
            }
            Console.WriteLine("In the word \"" + Pal + "\" if you remove \"" + symbol + "\" it will become Palindrome.");
        }
    }
}